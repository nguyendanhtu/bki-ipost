﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.Threading;
using System.Data.OleDb;

namespace test
{
    public partial class f108_QLGroup : Form
    {
        #region Member
        BackgroundWorker v_bgw;
        BackgroundWorker m_bgw;
        string access_token = "";
        string m_uid = "";
        string m_dtsg = "";
        bool m_status_search = true;
        List<groups> m_SortedList = new List<groups>();
        List<groups> me_groups = new List<groups>();
        #endregion

        #region public Method
        public f108_QLGroup()
        {
            InitializeComponent();
            this.CenterToScreen();
            m_wb.Navigate("https://facebook.com");
            v_bgw = new BackgroundWorker();
            v_bgw.WorkerReportsProgress = true;
            v_bgw.WorkerSupportsCancellation = true;

            m_bgw = new BackgroundWorker();
            m_bgw.WorkerReportsProgress = true;
            m_bgw.WorkerSupportsCancellation = true;

            v_bgw.DoWork += v_bgw_DoWork;
            v_bgw.ProgressChanged += v_bgw_ProgressChanged;
            v_bgw.RunWorkerCompleted += v_bgw_RunWorkerCompleted;

            m_bgw.DoWork += m_bgw_DoWork;
            m_bgw.ProgressChanged += m_bgw_ProgressChanged;
            m_bgw.RunWorkerCompleted += m_bgw_RunWorkerCompleted;
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
        #endregion

        #region private Method

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

        private void load_friend_list()
        {
            FacebookClient fb = new FacebookClient(access_token);

            dynamic data = fb.Get("/me/friends");

            foreach (var friend in (JsonArray)data["data"])
            {
                groups group = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                m_SortedList.Add(group);
            }
            m_SortedList = m_SortedList.OrderBy(o => o.Name).ToList();
            m_lb_friend_list.DataSource = m_SortedList;
            m_lb_friend_list.DisplayMember = "Name";
            m_lb_friend_list.ValueMember = "Id";
        }

        private void m_lb_friend_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_status_search)
            {
                load_group_list();
            }
        }

        private void load_group_list()
        {
            if (m_lb_friend_list.Items.Count > 0)
            {
                m_chk_all_group.Checked = false;
                FacebookClient fb = new FacebookClient(access_token);

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
                m_chk_all_group.Text = "Tất cả " + m_lb_group_list.Items.Count.ToString() + " group";
                // load group của tài khoản lên form tạo nhóm group.
                m_lb_me_list_group.DataSource = me_groups;
                m_lb_me_list_group.DisplayMember = "Name";
                m_lb_me_list_group.ValueMember = "ID";
            }
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
                string v_mess = "Thời gian ước tính hoàn thành khoảng " + (second / 60) + " phút " + (second % 60) + " giây";
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
                v_bgw.ReportProgress(i + 1);
                try
                {
                    request v_r = new request();
                    groups v_g = (groups)m_lb_group_list.CheckedItems[i];
                    v_r.group_id = v_g.Id;
                    v_r.user_id = m_uid;
                    v_r.dtsg = m_dtsg;
                    v_r.request_2_fb("https://www.facebook.com/ajax/groups/membership/r2j.php", "POST");
                    if (i + 1 < m_lb_group_list.CheckedItems.Count)
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

        private void m_bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            float length = m_cbl_group.CheckedItems.Count;
            m_pgb_group.Invoke((Action)(() => m_pgb_group.Maximum = m_cbl_group.CheckedItems.Count));
            for (int i = 0; i < length; i++)
            {
                m_bgw.ReportProgress(i + 1);
                try
                {
                    request v_r = new request();
                    groups v_g = (groups)m_cbl_group.CheckedItems[i];
                    v_r.group_id = v_g.Id;
                    v_r.user_id = m_uid;
                    v_r.dtsg = m_dtsg;
                    v_r.request_2_fb("https://www.facebook.com/ajax/groups/membership/r2j.php", "POST");
                    if (i + 1 < m_cbl_group.CheckedItems.Count)
                    {
                        Thread.Sleep(20000);
                    }
                }
                catch (Exception)
                {
                }
            }
            m_bgw.ReportProgress(100);
        }

        private void m_bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!m_bgw.CancellationPending)
            {
                if (e.ProgressPercentage == 100)
                {
                    m_pgb_group.PerformStep();
                }
                else
                {
                    m_pgb_group.Value = e.ProgressPercentage;
                }
            }
        }

        private void m_bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            m_cmd_join.Text = "Xin gia nhập";
        }

        private void m_txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_status_search = false;
                List<groups> v_filterList = new List<groups>();
                List<groups> v_checkedlist = new List<groups>();

                //1. Lấy danh sách các group thỏa mãn tìm kiếm
                foreach (groups v_friend in m_SortedList)
                {
                    //if (v_friend.Name.ToLower().IndexOf(m_txt_search.Text.ToLower()) >= 0) {
                    //    int index = v_filterList.FindIndex(item => item.Id == v_friend.Id);
                    //    if (index < 0) {
                    //        v_filterList.Add(v_friend);
                    //    }
                    //}

                    if (v_friend.Name.ToLower().Contains(m_txt_search.Text.ToLower()))
                    {
                        int index = v_filterList.FindIndex(item => item.Id == v_friend.Id);
                        if (index < 0)
                        {
                            v_filterList.Add(v_friend);
                        }
                    }
                }

                //2. Đưa danh sách lên LIST
                if (m_txt_search.Text.Trim().Length == 0)
                {
                    m_lb_friend_list.DataSource = m_SortedList;
                }
                else
                {
                    m_lb_friend_list.DataSource = v_filterList;
                }
                m_lb_friend_list.DisplayMember = "Name";
                m_lb_friend_list.ValueMember = "Id";
                m_status_search = true;
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_cmd_from_list_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();
            }
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fdlg.FileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Sheet1" + "$]", conn);
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);
            List<groups> v_list = new List<groups>();
            foreach (DataRow item in dt.Rows)
            {
                groups v_g = new groups();
                v_g.Id = item["Id"].ToString();
                v_g.Name = item["Name"].ToString();
                v_list.Add(v_g);
            }
            m_lb_group_list.DataSource = v_list;
            m_lb_group_list.ValueMember = "Id";
            m_lb_group_list.DisplayMember = "Name";
            m_chk_all_group.Text = "Tất cả " + v_list.Count.ToString() + " group";
        }
        #endregion

       

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            FacebookClient fb = new FacebookClient(globalInfo.access_token);
            List<groups> v_list_group = new List<groups>();
            if (m_txt_tim_kiem.Text.Trim().Length > 0)
            {
                dynamic result = fb.Get("search?q="+m_txt_tim_kiem.Text.Trim()+"&type=group");
                foreach (var g in (JsonArray)result["data"])
                {
                    groups group = new groups() { Id = (string)(((JsonObject)g)["id"]), Name = (string)(((JsonObject)g)["name"]) };
                    v_list_group.Add(group);
                }
                m_cbl_group.DataSource = v_list_group;
                m_cbl_group.DisplayMember = "Name";
                m_cbl_group.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Bạn phải nhập từ khóa tìm kiếm");
            }
        }

        private void m_cmd_join_Click(object sender, EventArgs e)
        {
            if (m_dtsg == "")
            {
                MessageBox.Show("Quá trình chuẩn bị chưa hoàn thành");
                m_wb.Navigate("https://facebook.com");
            }
            else
            {
                this.Controls.Remove(m_wb);
                int second = m_cbl_group.CheckedItems.Count / 3 * 90 + m_cbl_group.CheckedItems.Count % 3 * 15;
                string v_mess = "Thời gian ước tính hoàn thành khoảng " + (second / 60) + " phút " + (second % 60) + " giây";
                MessageBox.Show(v_mess);
                if (m_bgw.IsBusy)
                {
                    m_bgw.CancelAsync();
                }
                else
                {
                    m_pgb_group.Value = 0;
                    m_cmd_join.Text = "Stop";
                    m_bgw.RunWorkerAsync();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CsvRow row = new CsvRow();
                if (m_name_new_group.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên nhóm mới");
                    return;
                }
                if (m_lb_me_list_group.CheckedItems.Count <= 0)
                {
                    MessageBox.Show("Chưa chọn group");
                    return;
                }
                row.Add(m_name_new_group.Text.Trim());
                for (int i = 0; i < m_lb_me_list_group.CheckedItems.Count; i++)
                {
                    groups v_g = (groups)m_lb_me_list_group.CheckedItems[i];
                    row.Add(v_g.Id);
                }
                CsvFile writer = new CsvFile();
                writer.WriteRow(row, "Group.csv");
                MessageBox.Show("Tạo nhóm group thành công !");
                //load_nhom();
                       
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }
       
        
        private void m_text_search_group_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_status_search = false;
                List<groups> v_filterList = new List<groups>();
                List<groups> v_checkedlist = new List<groups>();

                //1. Lấy danh sách các group thỏa mãn tìm kiếm
                FacebookClient fb = new FacebookClient(access_token);
                var me_groups = new List<groups>();
                dynamic data = fb.Get("/me/groups");
                foreach (var friend in (JsonArray)data["data"])
                {
                    groups group = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                    me_groups.Add(group);
                }
                foreach (groups v_group in me_groups)
                {
                   
                    if (v_group.Name.ToLower().Contains(m_text_search_group.Text.ToLower()))
                    {
                        int index = v_filterList.FindIndex(item => item.Id == v_group.Id);
                        if (index < 0)
                        {
                            v_filterList.Add(v_group);
                        }
                    }
                }

                //2. Đưa danh sách lên LIST
                if (m_text_search_group.Text.Trim().Length == 0)
                {
                    m_lb_me_list_group.DataSource = me_groups;
                }
                else
                {
                    m_lb_me_list_group.DataSource = v_filterList;
                }
                m_lb_me_list_group.DisplayMember = "Name";
                m_lb_me_list_group.ValueMember = "Id";
                m_status_search = true;
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_chk_all_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_chk_all.Checked)
                {
                    for (int i = 0; i < m_lb_me_list_group.Items.Count; i++)
                    {
                        m_lb_me_list_group.SetItemChecked(i, true);
                    }
                    m_chk_all.Text = "Bỏ đánh dấu để hủy chọn tất cả nhóm ở dưới";
                }
                else
                {
                    for (int i = 0; i < m_lb_me_list_group.Items.Count; i++)
                    {
                        m_lb_me_list_group.SetItemChecked(i, false);
                    }
                    m_chk_all.Text = "Đánh dấu để chọn tất cả nhóm ở dưới";
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }
        
    }
}
