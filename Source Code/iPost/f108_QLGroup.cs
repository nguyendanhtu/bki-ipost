using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.Threading;

namespace test
{
    public partial class f108_QLGroup : Form
    {
        public f108_QLGroup()
        {
            InitializeComponent();
            this.CenterToScreen();
            m_wb.Navigate("https://facebook.com");
            v_bgw = new BackgroundWorker();
            v_bgw.WorkerReportsProgress = true;
            v_bgw.WorkerSupportsCancellation = true;

            v_bgw.DoWork += v_bgw_DoWork;
            v_bgw.ProgressChanged += v_bgw_ProgressChanged;
            v_bgw.RunWorkerCompleted += v_bgw_RunWorkerCompleted;
        }

        BackgroundWorker v_bgw;
        string access_token = "";
        string m_uid = "";
        string m_dtsg = "";

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f108_QLGroup_Load(object sender, EventArgs e)
        {
            access_token = globalInfo.access_token;
            FacebookClient fb = new FacebookClient(access_token);
            dynamic data = fb.Get("/me?fields=name");
            m_uid = data["id"];
            load_friend_list();
        }

        private void load_friend_list() {
            FacebookClient fb = new FacebookClient(access_token);
            var roles = new List<groups>();
            dynamic data = fb.Get("/me/friends");

            foreach (var friend in (JsonArray)data["data"])
            {
                groups group = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                roles.Add(group);
            }
            roles = roles.OrderBy(o => o.Name).ToList();
            m_lb_friend_list.DataSource = roles;
            m_lb_friend_list.DisplayMember = "Name";
            m_lb_friend_list.ValueMember = "Id";
        }

        private void m_lb_friend_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookClient fb = new FacebookClient(access_token);
            var me_groups = new List<groups>();
            dynamic data = fb.Get("/me/groups");
            foreach (var friend in (JsonArray)data["data"])
            {
                groups group = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                me_groups.Add(group);
            }

            var roles = new List<groups>();
            string pid = ((groups)m_lb_friend_list.SelectedItem).Id;
            data = fb.Get("/" + pid + "/groups");
            foreach (var friend in (JsonArray)data["data"])
            {
                groups gr = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                var s = (from a in me_groups where a.Id == gr.Id select a).ToList();
                if (s.Count == 0)
                {
                    roles.Add(gr);   
                }
            }

            roles = roles.OrderBy(o => o.Name).ToList();
            m_lb_group_list.DataSource = roles;
            m_lb_group_list.DisplayMember = "Name";
            m_lb_group_list.ValueMember = "Id";
            m_chk_all_group.Text = "Tất cả "+m_lb_group_list.Items.Count.ToString()+" group";
        }

        private void m_chk_all_group_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_chk_all_group.Checked)
                {
                    for (int i = 0; i < m_lb_group_list.Items.Count; i++)
                    {
                        m_lb_group_list.SetItemChecked(i, true);
                    }
                }
                else
                {
                    for (int i = 0; i < m_lb_group_list.Items.Count; i++)
                    {
                        m_lb_group_list.SetItemChecked(i, false);
                    }
                }
            }
            catch (Exception v_e)
            {


                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_cmd_get_info_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookClient fb = new FacebookClient(access_token);
                string pid = ((groups)m_lb_friend_list.SelectedItem).Id;
                dynamic data = fb.Get("/" + pid + "?fields=name,link");
                var friend = (JsonObject)data;
                dynamic pic = fb.Get("/" + pid + "/picture?width=160&redirect=false");
                var picture = (JsonObject)pic;
                f105_Info_Friend v_f = new f105_Info_Friend();
                v_f.display(friend, picture);

            }
            catch (Exception)
            {
                throw;
            }            
        }

        private void m_cmd_join_group_Click(object sender, EventArgs e)
        {
            if (m_dtsg == "")
            {
                MessageBox.Show("Quá trình chuẩn bị chưa hoàn thành");
                m_wb.Navigate("https://facebook.com");
            }
            else
            {
                this.Controls.Remove(m_wb);
                int second = m_lb_group_list.CheckedItems.Count / 3 * 90 + m_lb_group_list.CheckedItems.Count % 3 * 15;
                string v_mess = "Thời gian ước tính hoàn thành khoảng "+ (second/60)+ " phút "+ (second % 60)+ " giây";
                MessageBox.Show(v_mess);
                if (v_bgw.IsBusy)
                {
                    v_bgw.CancelAsync();
                }
                else
                {
                    m_prb_friends.Value = 0;
                    m_cmd_join_group.Text = "Stop";
                    v_bgw.RunWorkerAsync();
                }
            }
        }

        private void m_wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (m_dtsg == "")
            {
                HtmlDocument v_doc = m_wb.Document;
                HtmlElement v_e = v_doc.GetElementsByTagName("input")["fb_dtsg"];
                if (v_e != null)
                {
                    m_dtsg = v_e.GetAttribute("value").ToString();
                }   
            }
        }

        private void v_bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            float length = m_lb_group_list.CheckedItems.Count;
            m_prb_friends.Invoke((Action)(() => m_prb_friends.Maximum = m_lb_group_list.CheckedItems.Count));
            for (int i = 0; i < length; i++)
            {
                v_bgw.ReportProgress(i+1);
                try
                {
                    request v_r = new request();
                    groups v_g = (groups)m_lb_group_list.CheckedItems[i];
                    v_r.group_id = v_g.Id;
                    v_r.user_id = m_uid;
                    v_r.dtsg = m_dtsg;
                    v_r.request_2_fb("https://www.facebook.com/ajax/groups/membership/r2j.php", "POST");
                    if (i+1 < m_lb_group_list.CheckedItems.Count)
                    {
                        Thread.Sleep(20000);   
                    }                    
                }
                catch (Exception)
                {
                }
            }
            v_bgw.ReportProgress(100);
        }

        private void v_bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!v_bgw.CancellationPending)
            {
                if (e.ProgressPercentage == 100)
                {
                    m_prb_friends.PerformStep();
                }
                else
                {
                    m_prb_friends.Value = e.ProgressPercentage;
                }                
            }
        }

        private void v_bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            m_cmd_join_group.Text = "Xin gia nhập";
        }

        public void m_cmd_phan_tich_Click(object sender, EventArgs e)
        {
            f106_Phan_tich_group v_f = new f106_Phan_tich_group();
            List<groups> group_list = new List<groups>();
            foreach (var item in m_lb_group_list.CheckedItems)
            {
                group_list.Add((groups)item);
            }
            v_f.display(group_list);
        }
    }
}
