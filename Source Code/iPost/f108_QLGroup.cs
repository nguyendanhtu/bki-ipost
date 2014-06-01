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
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
        }

        string access_token = "";
        string m_uid = "";
        string m_dtdg = "";
        BackgroundWorker backgroundWorker1;

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            var roles = new List<groups>();
            FacebookClient fb = new FacebookClient(access_token);
            dynamic data = fb.Get("/search?q="+m_txt_tu_khoa.Text.Trim()+"&type=group");
            foreach (var g in (JsonArray)data["data"])
            {
                groups group = new groups() { Id = (string)(((JsonObject)g)["id"]), Name = (string)(((JsonObject)g)["name"]) };
                roles.Add(group);
            }
            m_clb_ket_qua.DataSource = roles;
            m_clb_ket_qua.DisplayMember = "Name";
            m_clb_ket_qua.ValueMember = "Id";
        }

        private void f108_QLGroup_Load(object sender, EventArgs e)
        {
            access_token = globalInfo.access_token;
            FacebookClient fb = new FacebookClient(access_token);
            dynamic data = fb.Get("/me?fields=name");
            m_uid = data["id"];
            load_friend_list();
        }
        private void m_cmd_join_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                m_cmd_join.Text = "Join Group";
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
                m_cmd_join.Text = "Stop";
                backgroundWorker1.RunWorkerAsync();
            }            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int length = m_clb_ket_qua.CheckedItems.Count;
            progressBar1.Invoke((Action)(() => progressBar1.Maximum = length));
            for (int i = 0; i < m_clb_ket_qua.CheckedItems.Count; i++)
            {
                try
                {
                    request v_r = new request();
                    groups v_g = (groups)m_clb_ket_qua.CheckedItems[i];
                    v_r.group_id = v_g.Id;
                    v_r.user_id = m_uid;
                    v_r.dtsg = m_dtdg;
                    v_r.request_2_fb("https://www.facebook.com/ajax/groups/membership/r2j.php", "POST");
                    //m_lbl_group.Text = "Đã xin gia nhập nhóm " + v_g.Name;
                }
                catch (Exception)
                {
                }
                
                backgroundWorker1.ReportProgress((int)(i / length * 100));
                if (i + 1 != m_clb_ket_qua.CheckedItems.Count)
                {
                    int time = 10000;
                    Thread.Sleep(time);
                }
            }
            backgroundWorker1.ReportProgress(100);
            MessageBox.Show("Đã gửi yêu cầu gia nhập đến " + m_clb_ket_qua.CheckedItems.Count.ToString() + " nhóm");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker1.CancellationPending)
            {
                m_lbl_group.Text = e.ProgressPercentage + "%";
                progressBar1.PerformStep();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            m_cmd_join.Text = "Join Group";
        }

        private void m_chk_all_CheckedChanged(object sender, EventArgs e)
        {
            if (m_chk_all.Checked)
            {
                for (int i = 0; i < m_clb_ket_qua.Items.Count; i++)
                {
                    m_clb_ket_qua.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < m_clb_ket_qua.Items.Count; i++)
                {
                    m_clb_ket_qua.SetItemChecked(i, false);
                }
            }
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
            m_lb_friend_list.DataSource = roles;
            m_lb_friend_list.DisplayMember = "Name";
            m_lb_friend_list.ValueMember = "Id";
        }
    }
}
