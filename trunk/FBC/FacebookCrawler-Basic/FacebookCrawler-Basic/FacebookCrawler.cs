using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookCrawler_Basic
{
    public partial class FacebookCrawler : Form
    {
        Stack<string> m_stk = new Stack<string>();

        public FacebookCrawler()
        {
            InitializeComponent();
            m_bgwk.WorkerSupportsCancellation = true;
            m_bgwk.WorkerReportsProgress = true;
        }

        private void m_cmd_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_bgwk.IsBusy != true)
                {
                    m_cmd_start.Text = "Dừng lại";
                    m_bgwk.RunWorkerAsync();
                }
                if (m_bgwk.WorkerSupportsCancellation == true)
                {
                    m_bgwk.CancelAsync();
                }
            }
            catch (Exception v_e)
            {
                
                throw v_e;
            }
        }

        private void layDanhSachBanBe()
        {
            if (!stackRong())
            {
                var v_user_id = m_stk.Pop();
                int v_start = 0;
                while (true)
                {
                    string v_url_request = "https://www.facebook.com/ajax/browser/list/allfriends/?uid=" + v_user_id + "&__user=" + c_user.Text.Trim() +"&__a=1&start=" + v_start.ToString();
                    var v_data = makeRequest(v_url_request);
                    if (!v_data.Contains("profile.php?id="))
                    {
                        break;
                    }
                    locIdUser(
                        v_data
                        , "profile.php?id="
                        , "&amp");
                    v_start += 24;
                }                
            }
        }

        private void layDanhSachBanBeAdmin()
        {
            locIdUser(makeRequest(
                "https://www.facebook.com/ajax/typeahead/first_degree.php?__a=1&filter[0]=user&lazy=0&viewer=100004685250081&token=v7&stale_ok=0&options[0]=friends_only&options[1]=nm")
                , "profile.php?id="
                , "\"");
        }

        private void locIdUser(string ip_str_data, string ip_str_start, string ip_str_end)
        {
            var v_lst_user_id = GetSubStrings(ip_str_data, ip_str_start, ip_str_end).ToList();
            addId2List(v_lst_user_id);
        }

        private void addId2List(List<string> v_lst_user_id)
        {
            foreach (var item in v_lst_user_id)
            {
                try
                {
                    insert2DB(item);
                    m_stk.Push(item);
                    Action action = () => m_lst_url.Items.Insert(0, item);
                    m_lst_url.Invoke(action);
                }
                catch (Exception)
                {
                    continue;
                }                
            }
        }

        private void insert2DB(string item)
        {
            FacebookCrawlerEntities fbe = new FacebookCrawlerEntities();
            FacebookUser v_fbu = new FacebookUser();
            v_fbu.ID = item;
            fbe.FacebookUsers.Add(v_fbu);
            fbe.SaveChanges();
        }

        private string makeRequest(string ip_url){
            CookieContainer v_c = new CookieContainer();
            v_c.Add(globalInfo.cookie_collection);
            var request = (HttpWebRequest)WebRequest.Create(ip_url);
            request.AllowAutoRedirect = true;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "GET";
            request.ProtocolVersion = HttpVersion.Version11;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.159 CoRom/33.0.1750.159 Safari/537.36";
            request.CookieContainer = v_c;
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString.ToString();
        }

        private bool denGioNghi() {
            if (DateTime.Now < m_dat.Value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool stackRong()
        {
            if (m_stk.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void nhapCookie()
        {
            Cookie c_act = new Cookie("act", act.Text); c_act.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_act);
            Cookie c_c_user = new Cookie("c_user", c_user.Text); c_c_user.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_c_user);
            Cookie c_csm = new Cookie("csm", csm.Text); c_csm.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_csm);
            Cookie c_datr = new Cookie("datr", datr.Text); c_datr.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_datr);
            Cookie c_fr = new Cookie("fr", fr.Text); c_fr.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_fr);
            Cookie c_lu = new Cookie("lu", lu.Text); c_lu.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_lu);
            Cookie c_p = new Cookie("p", p.Text); c_p.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_p);
            Cookie c_presence = new Cookie("presence", presence.Text); c_presence.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_presence);
            Cookie c_s = new Cookie("s", s.Text); c_s.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_s);
            Cookie c_xs = new Cookie("xs", xs.Text); c_xs.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_xs);
        }

        private IEnumerable<string> GetSubStrings(string input, string start, string end)
        {
            Regex r = new Regex(Regex.Escape(start) + "(.*?)" + Regex.Escape(end));
            MatchCollection matches = r.Matches(input);
            foreach (Match match in matches)
                yield return match.Groups[1].Value;
        }

        private void m_cmd_import_cookie_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file = openFileDialog1.FileName;
                    string text = File.ReadAllText(file);
                    ReadCookie2Form(text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void ReadCookie2Form(string myStream)
        {
            var v_lst = myStream.Split(';');
            foreach (var item in v_lst)
            {
                var name_value = item.Split('=');
                var v_control = (TextBox)this.Controls.Find(name_value[0], true)[0];
                v_control.Text = name_value[1];                
            }
        }

        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            nhapCookie();
            while (stackRong())
            {
                layDanhSachBanBeAdmin();
            }
            while (!stackRong() && !denGioNghi())
            {
                layDanhSachBanBe();
                worker.ReportProgress(1);
            }            
        }

        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.tbProgress.Text = m_lst_url.Items.Count.ToString();
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.tbProgress.Text = "Canceled!";
                m_cmd_start.Text = "Bắt đầu";
            }

            else if (!(e.Error == null))
            {
                this.tbProgress.Text = ("Error: " + e.Error.Message);
                m_cmd_start.Text = "Bắt đầu";
            }

            else
            {
                this.tbProgress.Text = "Done!";
                m_cmd_start.Text = "Bắt đầu";
            }
        }

        private void m_cmd_export_Click(object sender, EventArgs e)
        {
            string v_str = "";
            while (m_stk.Count > 0)
            {
                v_str += m_stk.Pop() + ",";
            }
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, v_str);
                    MessageBox.Show("Xuất danh sách thành công");
                }
            }
        }

        private void m_cmd_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file = openFileDialog1.FileName;
                    string text = File.ReadAllText(file);
                    ReadText2Stack(text);
                    MessageBox.Show("Nhập danh sách thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void ReadText2Stack(string text)
        {
            var v_lst = text.Split(',');
            foreach (var item in v_lst)
            {
                if (item.Trim() != "")
                {
                    m_stk.Push(item);
                    m_lst_url.Items.Insert(0,item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhapCookie();
            makeRequest("https://www.facebook.com/vu.gia.7505/about?section=work");
        }
    }
}
