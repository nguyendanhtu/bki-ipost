using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.Dynamic;
using System.Threading;

namespace test
{
    public partial class f104_post : Form
    {
        public f104_post()
        {
            InitializeComponent();
            this.CenterToScreen();
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int length = m_cbl_group.CheckedItems.Count;
            progressBar1.Invoke((Action)(() => progressBar1.Maximum = length));
            for (int i = 0; i < m_cbl_group.CheckedItems.Count; i++)
            {
                post_2_facebook((groups)m_cbl_group.CheckedItems[i]);
                backgroundWorker1.ReportProgress((int)(i / length * 100));
                if (i + 1 != m_cbl_group.CheckedItems.Count)
                {
                    int time = Convert.ToInt32(m_txt_time.Text) * 1000;
                    Thread.Sleep(time);
                }
            }
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Thay đổi trạng thái làm việc
            if (!backgroundWorker1.CancellationPending)
            {
                progressBar1.PerformStep();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            m_cmd_post.Text = "Đăng bài";
        }

        #region Members
        class groups
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
        string m_uid = "";
        string m_access_token = "";
        bool m_b_has_image = false;
        string link = "";
        string caption = "";
        string description = "";
        BackgroundWorker backgroundWorker1;
        #endregion        

        private void m_cmd_post_Click(object sender, EventArgs e)
        {
            if ((m_txt_time.Text == "")||(Convert.ToInt32(m_txt_time.Text) < 10))
            {
                MessageBox.Show("Nhập lại thời gian");
                return;
            }
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                m_cmd_post.Text = "Đăng bài";
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
                m_cmd_post.Text = "Stop";
                backgroundWorker1.RunWorkerAsync();
            }  
        }

        private void post_2_facebook(groups item)
        {
            dynamic result;
            try
            {
                if (m_b_has_image)
                {
                    FacebookClient fb = new FacebookClient(m_access_token);
                    dynamic parameters = new ExpandoObject();
                    parameters.url = m_txt_url_image.Text;
                    parameters.message = m_txt_message.Text;
                    result = fb.Post(item.Id + "/photos", parameters);
                }
                else
                {
                    FacebookClient fb = new FacebookClient(m_access_token);
                    dynamic parameters = new ExpandoObject();
                    parameters.message = m_txt_message.Text;
                    parameters.link = m_txt_url_image.Text;
                    parameters.picture = link;
                    parameters.caption = caption;
                    parameters.description = description;
                    result = fb.Post(item.Id + "/feed", parameters);
                }
                string p_id = result["id"];
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\BKIndex\AutoPostToGroup\postId.txt", true);
                file.WriteLine(m_uid + "_" + p_id);
                file.WriteLine(item.Name);
                if (m_txt_message.Text.Length > 30)
                {
                    file.WriteLine(m_txt_message.Text.Substring(0,30));
                }
                else
	            {
                    file.WriteLine(m_txt_message.Text.Trim());
	            }                
                file.Close();
            }
            catch (Exception v_e)
            {                
                
            }
        }

        //public void Display(string access_token)
        //{
        //    m_access_token = access_token;
        //    this.ShowDialog();
        //}

        private void m_chk_has_image_CheckedChanged(object sender, EventArgs e)
        {
            if (m_chk_has_image.Checked)
            {
                m_cmd_advance.Enabled = false;
                m_b_has_image = true;
                m_chk_has_image.Text = "Có ảnh";
                m_lbl_image_url.Text = "Ảnh đính kèm";
            }
            else
            {
                m_cmd_advance.Enabled = true;
                m_b_has_image = false;
                m_chk_has_image.Text = "Không có ảnh";
                m_lbl_image_url.Text = "Link đính kèm";
            }
        }        

        public void Display_post(string access_token)
        {
            FacebookClient fb = new FacebookClient(access_token);
            var roles = new List<groups>();
            dynamic data = fb.Get("/me/groups");
            
            foreach (var friend in (JsonArray)data["data"])
            {
                groups group = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                roles.Add(group);
            }
            m_cbl_group.DataSource = roles;
            m_cbl_group.DisplayMember = "Name";
            m_cbl_group.ValueMember = "Id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\BKIndex\AutoPostToGroup\at.txt");
            m_access_token = lines[0];
            FacebookClient fb = new FacebookClient(m_access_token);
            dynamic data = fb.Get("/me?fields=name");
            m_uid = data["id"];
            Display_post(m_access_token);
        }

        private void m_cmd_advance_Click(object sender, EventArgs e)
        {
            Advance v_f = new Advance();
            v_f.Display(this);
        }

        internal void Updating(string p, string p_2, string p_3)
        {
            link = p;
            caption = p_2;
            description = p_3;
        }

        private void m_chk_all_CheckedChanged(object sender, EventArgs e)
        {
            if (m_chk_all.Checked)
            {
                for (int i = 0; i < m_cbl_group.Items.Count; i++)
                {
                    m_cbl_group.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < m_cbl_group.Items.Count; i++)
                {
                    m_cbl_group.SetItemChecked(i, false);
                }
            }
        }
    }
}
