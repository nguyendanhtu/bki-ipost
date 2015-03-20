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
using System.IO;
using System.Net;

namespace test
{
    public partial class f104_post : Form
    {
        #region Members
        int m_count_items_checked = 0;
        class groups
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
        string m_uid = "";
        bool m_b_has_image = false;
        bool m_b_upload = false;
        string link = "";
        string caption = "";
        string description = "";
        BackgroundWorker backgroundWorker1;
        BackgroundWorker backgroundWorker2;
        List<groups> m_SortedList;
        List<string> m_list_color = new List<string>();
        #endregion

        #region Private Method
        private void post_2_facebook(groups item)
        {
            dynamic result;
            string v_path = Directory.GetCurrentDirectory();
            string v_url_image = "";
            try
            {
                if (m_b_upload)
                {
                    v_url_image = "http://bkindex.uphero.com/" + Path.GetFileName(m_txt_url_image.Text);
                    m_b_upload = false;
                }
                else
                {
                    v_url_image = m_txt_url_image.Text;
                }
                if (m_b_has_image)
                {
                    FacebookClient fb = new FacebookClient(globalInfo.access_token);
                    dynamic parameters = new ExpandoObject();
                    parameters.url = v_url_image;
                    parameters.message = m_txt_message.Text;
                    result = fb.Post(item.Id + "/photos", parameters);
                }
                else
                {
                    FacebookClient fb = new FacebookClient(globalInfo.access_token);
                    dynamic parameters = new ExpandoObject();
                    parameters.message = m_txt_message.Text;
                    parameters.link = m_txt_url_image.Text;
                    parameters.picture = link;
                    parameters.caption = caption;
                    parameters.description = description;
                    result = fb.Post(item.Id + "/feed", parameters);
                }
                string p_id = result["id"];
                System.IO.StreamWriter file = new System.IO.StreamWriter(v_path + "\\postId.txt", true);
                file.WriteLine(m_uid + "_" + p_id);
                file.WriteLine(item.Name);
                if (m_txt_message.Text.Length > 30)
                {
                    file.WriteLine(m_txt_message.Text.Substring(0, 30));
                }
                else
                {
                    file.WriteLine(m_txt_message.Text.Trim());
                }
                file.Close();
            }
            catch (Exception)
            {
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                int length = m_cbl_list_group.CheckedItems.Count;
                progressBar1.Invoke((Action)(() => progressBar1.Maximum = length));
                if (m_b_has_image && m_b_upload)
                {
                    upload v_up = new upload();
                    v_up.Upload(m_txt_url_image.Text);
                }
                //for (int i = 0; i < m_cbl_list_group.CheckedItems.Count; i++)
                //{
                int i = 0;
                    foreach (groups item in m_cbl_list_group.CheckedItems)
                    {
                        i++;
                        post_2_facebook(item);
                    
                    backgroundWorker1.ReportProgress((int)(i / length * 100));
                    if (i + 1 != m_cbl_list_group.CheckedItems.Count)
                    {
                        int time = Convert.ToInt32(m_txt_time.Text) * 1000;
                        Thread.Sleep(time);
                    }
                }
                backgroundWorker1.ReportProgress(100);
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            try
            {
                //Thay đổi trạng thái làm việc
                if (!backgroundWorker1.CancellationPending)
                {
                    progressBar1.PerformStep();
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            try
            {
                m_cmd_post.Text = "Đăng bài";
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                int length = m_cbl_list_group.CheckedItems.Count;
                progressBar1.Invoke((Action)(() => progressBar1.Maximum = length));
                for (int i = 0; i < m_cbl_list_group.CheckedItems.Count; i++)
                {
                    foreach (groups item in m_SortedList)
                    {
                        if (item.Name == m_cbl_list_group.CheckedItems[i].ToString())
                        {
                            comment2Top5(item);
                            break;
                        }
                    }
                    backgroundWorker2.ReportProgress((int)(i / length * 100));
                }
                backgroundWorker2.ReportProgress(100);
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            try
            {
                //Thay đổi trạng thái làm việc
                if (!backgroundWorker2.CancellationPending)
                {
                    progressBar1.PerformStep();
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            try
            {
                m_cmd_comment.Text = "Comment";
                //foreach (var item in m_cbl_list_group.CheckedIndices)
                //{
                //    m_cbl_list_group.Completionlist.Add(int.Parse(item.ToString()));
                //    m_list_color.Add(m_cbl_list_group.Items[int.Parse(item.ToString())].ToString());
                //}
                //m_cbl_list_group.Refresh();
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_cmd_post_Click(object sender, EventArgs e)
        {
            try
            {
                if ((m_txt_time.Text == "") || (Convert.ToInt32(m_txt_time.Text) < 5))
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
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_chk_has_image_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_chk_has_image.Checked)
                {
                    m_b_has_image = true;
                    m_chk_has_image.Text = "Có ảnh";
                    m_lbl_image_url.Text = "Ảnh đính kèm";
                    m_cmd_advance.Text = "Tải ảnh lên";
                }
                else
                {
                    m_b_has_image = false;
                    m_chk_has_image.Text = "Không có ảnh";
                    m_lbl_image_url.Text = "Link đính kèm";
                }
            }
            catch (Exception v_e)
            {


                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {                
                Display_post();
                load_nhom();
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        private void m_cmd_advance_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_b_has_image)
                {
                    //f102_Upload_image v_f = new f102_Upload_image();
                    //v_f.Display(this);
                    OpenFileDialog fdlg = new OpenFileDialog();
                    fdlg.Title = "Select file";
                    fdlg.InitialDirectory = @"c:\";
                    fdlg.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF Files: (*.GIF)|*.GIF|TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|PNG Files: (*.PNG)|*.PNG|All Files|*.*";
                    fdlg.FilterIndex = 1;
                    fdlg.RestoreDirectory = true;
                    if (fdlg.ShowDialog() == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                    m_txt_url_image.Text = fdlg.FileName;
                    m_b_upload = true;
                }
                else
                {
                    Advance v_f = new Advance();
                    v_f.Display(this);
                }
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
                    for (int i = 0; i < m_cbl_list_group.Items.Count; i++)
                    {
                        m_cbl_list_group.SetItemChecked(i, true);
                    }
                    m_chk_all.Text = "Bỏ đánh dấu để hủy chọn tất cả nhóm ở dưới";
                }
                else
                {
                    for (int i = 0; i < m_cbl_list_group.Items.Count; i++)
                    {
                        m_cbl_list_group.SetItemChecked(i, false);
                    }
                    m_chk_all.Text = "Đánh dấu để chọn tất cả nhóm ở dưới";
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_cbl_list_group.DataSource = m_SortedList;
                List<string> v_list_checked = new List<string>();
                List<string> v_list_search = new List<string>();
                List<groups> v_list_result = new List<groups>();

                //-- 1. Lấy danh sách những group đã chọn
                foreach (var item in m_cbl_list_group.CheckedItems)
                {
                    v_list_checked.Add(((groups)item).Id);
                }

                //-- 2. Lấy danh sách những group thỏa mãn từ khóa tìm kiếm
                foreach (var item in m_SortedList)
                {
                    if (item.Name.ToString().ToLower().Contains(m_txt_search.Text.ToLower().Trim()))
                    {
                        //bool v_b_check = v_list_checked.Select(x => x == item.Name.ToString()).FirstOrDefault();
                        var v_b_check = v_list_checked.Find(x => x == item.Name.ToString());
                        if (v_b_check == null)
                        {
                            v_list_search.Add(item.Name.ToString());
                        }
                    }
                }
                //-- 3. Tổng hợp kết quả
                if (m_txt_search.Text.Trim() == "")
                {
                    v_list_result = m_SortedList;
                }
                else
                {
                    foreach (string name in v_list_checked)
                    {
                        foreach (groups group in m_SortedList)
                        {
                            if (name == group.Name)
                            {
                                v_list_result.Add(group);
                                break;
                            }
                        }
                    }

                    foreach (string name in v_list_search)
                    {
                        
                        foreach (groups group in m_SortedList)
                        {
                            if (name == group.Name)
                            {
                                v_list_result.Add(group);
                                break;
                            }
                        }
                    }
                }
                //-- 4. Đưa kết quả lên Control
                bool check = false;
                m_cbl_list_group.DataSource = null;
                int index = 0;
               m_cbl_list_group.DataSource = v_list_result;
                m_cbl_list_group.DisplayMember = "Name";
                m_cbl_list_group.ValueMember = "Id";
                for (int i=0; i < m_cbl_list_group.Items.Count;i++ )
                {
                    foreach (var name in v_list_checked)
                    {
                        if (name == ((groups)m_cbl_list_group.Items[i]).Id)
                        {
                            m_check_bang_tay = false;
                            m_cbl_list_group.SetItemChecked(i, true);
                            m_check_bang_tay = true;
                        }
                    }
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }



        private void comment2Top5(groups ip_group)
        {
            List<string> v_id_post = new List<string>();
            FacebookClient fb = new FacebookClient(globalInfo.access_token);
            dynamic result = fb.Get(ip_group.Id + "/feed?fields=id&limit=5");
            foreach (var pid in (JsonArray)result["data"])
            {
                string id = (string)(((JsonObject)pid)["id"]);
                v_id_post.Add(id);
            }
            foreach (string item in v_id_post)
            {
                dynamic parameters = new ExpandoObject();
                parameters.message = m_txt_message.Text;
                var v_result = fb.Post("/" + item + "/comments", parameters);
            }
        }

        private void m_cmd_comment_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker2.IsBusy)
                {
                    backgroundWorker2.CancelAsync();
                    m_cmd_comment.Text = "Comment";
                }
                else
                {
                    progressBar1.Value = progressBar1.Minimum;
                    m_cmd_comment.Text = "Stop";
                    backgroundWorker2.RunWorkerAsync();
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }
        //private void m_but_create_Click(object sender, EventArgs e)
        //{
        //    CsvRow row = new CsvRow();
        //    if (m_txt_name_nhom.Text == "")
        //    {
        //        MessageBox.Show("Chưa nhập tên nhóm mới");
        //        return;
        //    }
        //    if (m_cbl_list_group.CheckedItems.Count == 0)
        //    {
        //        MessageBox.Show("Chưa chọn group");
        //        return;
        //    }
        //    FacebookClient fb = new FacebookClient(globalInfo.access_token);
        //    dynamic data = fb.Get("/me?fields=id");
        //    var v_id = ((JsonObject)data)["id"].ToString();
        //    row.Add(v_id);
        //    row.Add(m_txt_name_nhom.Text.Trim());
        //    foreach (groups item in m_cbl_list_group.CheckedItems)
        //    {
        //        row.Add(item.Id);
        //    }
        //    CsvFile writer = new CsvFile();
        //    writer.WriteRow(row, "Group.csv");
        //    MessageBox.Show("Tạo nhóm group thành công !");
        //    load_nhom();
        //}

        private void load_nhom()
        {
            List<string> list_nhom = new List<string>(); ;
            CsvFile reader = new CsvFile();
            List<CsvRow> rows = reader.ReadRow("Group.csv");
            CsvRow row = new CsvRow();
            FacebookClient fb = new FacebookClient(globalInfo.access_token);
            dynamic data = fb.Get("/me?fields=id");
            var v_id = ((JsonObject)data)["id"].ToString();
            globalInfo.id = v_id;
            foreach (CsvRow r in rows)
            {
                if (r.Count == 0) continue;
;
                if (v_id==r[0].ToString())
                {
                    list_nhom.Add(r[1].ToString());
                }  
               
            }
            
            m_box_list_nhom.DataSource = list_nhom;
        }
        #endregion

        #region public method
        public void Display_post()
        {
            try
            {
                FacebookClient fb = new FacebookClient(globalInfo.access_token);
                var roles = new List<groups>();
                dynamic data = fb.Get("/me/groups?limit=390");

                foreach (var v_g in (JsonArray)data["data"])
                {
                    groups group = new groups() { Id = (string)(((JsonObject)v_g)["id"]), Name = (string)(((JsonObject)v_g)["name"]) };
                    roles.Add(group);
                }
                m_SortedList = roles.OrderBy(o => o.Name).ToList();
                for (int i = 0; i < m_SortedList.Count; i++)
                {
                    m_cbl_list_group.DisplayMember = "Name";
                    m_cbl_list_group.ValueMember = "Id";
                    m_cbl_list_group.DataSource = m_SortedList;
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        public void Updating(string p, string p_2, string p_3)
        {
            try
            {
                link = p;
                caption = p_2;
                description = p_3;
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

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

            backgroundWorker2 = new BackgroundWorker();
            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.WorkerSupportsCancellation = true;

            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            backgroundWorker2.ProgressChanged += backgroundWorker2_ProgressChanged;
            backgroundWorker2.RunWorkerCompleted += backgroundWorker2_RunWorkerCompleted;
        }
        #endregion

        List<string> m_lst_group_chon_bang_tay = new List<string>();
        List<string> m_lst_group_chon_bang_danh_sach = new List<string>();
        bool m_check_bang_tay = true;
        private void m_box_list_nhom_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                m_lst_group_chon_bang_danh_sach.Clear();
                for (int i = 0; i < m_cbl_list_group.Items.Count; i++)
                {
                    if (m_lst_group_chon_bang_tay.Exists(x => x == ((groups)m_cbl_list_group.Items[i]).Id))
                    {
                        continue;
                    }
                    m_cbl_list_group.SetItemChecked(i, false);
                }
                //var z = sender.ToString();
                List<string> list_nhom = new List<string>(); ;
                CsvFile reader = new CsvFile();
                List<CsvRow> rows = reader.ReadRow("Group.csv");
                foreach (CsvRow row in rows) 
                {
                    if (row.Count == 0) continue;
                    foreach (var item in m_box_list_nhom.CheckedItems)
                    {
                        if (item.ToString() == m_box_list_nhom.Items[e.Index].ToString())
                        {
                            continue;
                        }
                        if (row[0].ToString() == item.ToString())
                        {
                            foreach (string s in row)
                            {
                                m_lst_group_chon_bang_danh_sach.Add(s);
                            }
                        }
                    }
                    if (e.NewValue == CheckState.Checked)
                    {
                        if (row[1].ToString() == m_box_list_nhom.Items[e.Index].ToString())
                        {
                            foreach (string s in row)
                            {
                                m_lst_group_chon_bang_danh_sach.Add(s);
                            }
                        }
                    }                    
                }

                foreach (string item in m_lst_group_chon_bang_tay)
                {
                        for (int i = 0; i < m_cbl_list_group.Items.Count; i++)
                    {
                        if (item == ((groups)m_cbl_list_group.Items[i]).Id)
                        {
                            m_cbl_list_group.SetItemChecked(i, true);
                        }
                    }
                }

                for (int i = 0; i < m_cbl_list_group.Items.Count; i++)
                {
                    foreach (string item in m_lst_group_chon_bang_danh_sach)
                    {
                        if (item == ((groups)m_cbl_list_group.Items[i]).Id)
                        {
                            m_check_bang_tay = false;
                            m_cbl_list_group.SetItemChecked(i, true);
                            m_check_bang_tay = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void m_cbl_list_group_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!m_check_bang_tay)
            {
                return;
            }
            if (e.NewValue == CheckState.Checked)
            {
                groups v_g = new groups();
                v_g = (groups)m_cbl_list_group.Items[e.Index];
                m_lst_group_chon_bang_tay.Add(v_g.Id);
            }
            else
            {
                m_lst_group_chon_bang_tay.Remove(m_lst_group_chon_bang_tay.Find(x => x == ((groups)m_cbl_list_group.Items[e.Index]).Id));
            }
        }

        

        ////private void m_box_list_nhom_ItemCheck(object sender, EventArgs e)
        //{

        //}



        //private void m_cmd_test_tag_Click(object sender, EventArgs e)
        //{
        //    FacebookClient fb = new FacebookClient(globalInfo.access_token);
        //    dynamic parameters = new ExpandoObject();
        //    parameters.message = "@[100004685250081:1:Thái Phạm]";
        //    var result = fb.Post("me/feed", parameters);
        //}

    }
}
