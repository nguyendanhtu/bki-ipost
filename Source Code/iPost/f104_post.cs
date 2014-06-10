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


        #region Members
        class groups {
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
        List<groups> m_SortedList;
        List<string> m_list_color = new List<string>();

        CustomCheckedListBox m_cbl_group = new CustomCheckedListBox();
        #endregion        


        #region Private Method

        private void post_2_facebook(groups item) {
            dynamic result;
            string v_path = Directory.GetCurrentDirectory();
            try {
                if (m_b_has_image) {
                    FacebookClient fb = new FacebookClient(m_access_token);
                    dynamic parameters = new ExpandoObject();
                    parameters.url = m_txt_url_image.Text;
                    parameters.message = m_txt_message.Text;
                    result = fb.Post(item.Id + "/photos", parameters);
                }
                else {
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
                System.IO.StreamWriter file = new System.IO.StreamWriter(v_path +"\\postId.txt", true);
                file.WriteLine(m_uid + "_" + p_id);
                file.WriteLine(item.Name);
                if (m_txt_message.Text.Length > 30) {
                    file.WriteLine(m_txt_message.Text.Substring(0, 30));
                }
                else {
                    file.WriteLine(m_txt_message.Text.Trim());
                }
                file.Close();
            }
            catch (Exception ) {
            }
        }

        public void Display_post(string access_token) {
            try {
                FacebookClient fb = new FacebookClient(access_token);
                var roles = new List<groups>();
                dynamic data = fb.Get("/me/groups");

                foreach (var friend in (JsonArray)data["data"]) {
                    groups group = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                    roles.Add(group);
                }
                m_SortedList = roles.OrderBy(o => o.Name).ToList();
                for (int i = 0; i < m_SortedList.Count; i++)
                {
                    m_cbl_group.Items.Add(m_SortedList[i].Name);
                }
            }
            catch (Exception v_e) {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        public void Updating(string p, string p_2, string p_3)
        {
            try {
                link = p;
                caption = p_2;
                description = p_3;
            }
            catch (Exception v_e) {


                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try {
                int length = m_cbl_group.CheckedItems.Count;
                progressBar1.Invoke((Action)(() => progressBar1.Maximum = length));
                for (int i = 0; i < m_cbl_group.CheckedItems.Count; i++) {
                    foreach (groups item in m_SortedList)
                    {
                        if (item.Name == m_cbl_group.CheckedItems[i].ToString())
                        {
                            post_2_facebook(item);
                            break;
                        }
                    }
                    backgroundWorker1.ReportProgress((int)(i / length * 100));
                    if (i + 1 != m_cbl_group.CheckedItems.Count) {
                        int time = Convert.ToInt32(m_txt_time.Text) * 1000;
                        Thread.Sleep(time);
                    }
                }
                backgroundWorker1.ReportProgress(100);
            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
           
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            try {
                //Thay đổi trạng thái làm việc
                if (!backgroundWorker1.CancellationPending) {
                    progressBar1.PerformStep();
                }
            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            try {
                m_cmd_post.Text = "Đăng bài";
                foreach (var item in m_cbl_group.CheckedIndices)
                {
                    m_cbl_group.Completionlist.Add(int.Parse(item.ToString()));
                    m_list_color.Add(m_cbl_group.Items[int.Parse(item.ToString())].ToString());
                }
                m_cbl_group.Refresh();
            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }          
        }

        private void m_cmd_post_Click(object sender, EventArgs e)
        {
            try {
                if ((m_txt_time.Text == "") || (Convert.ToInt32(m_txt_time.Text) < 10))
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
                    m_cbl_group.Completionlist.Clear();
                    m_list_color.Clear();
                    m_cbl_group.Refresh();
                    progressBar1.Value = progressBar1.Minimum;
                    m_cmd_post.Text = "Stop";
                    backgroundWorker1.RunWorkerAsync();
                } 
            }
            catch (Exception v_e) {
                
                  MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }            
        }

        private void m_chk_has_image_CheckedChanged(object sender, EventArgs e)
        {
            try {
                if (m_chk_has_image.Checked) {
                    m_cmd_advance.Enabled = false;
                    m_b_has_image = true;
                    m_chk_has_image.Text = "Có ảnh";
                    m_lbl_image_url.Text = "Ảnh đính kèm";
                }
                else {
                    m_cmd_advance.Enabled = true;
                    m_b_has_image = false;
                    m_chk_has_image.Text = "Không có ảnh";
                    m_lbl_image_url.Text = "Link đính kèm";
                }
            }
            catch (Exception v_e) {


                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
          
        }             

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                this.m_cbl_group.CheckOnClick = true;
                this.m_cbl_group.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.m_cbl_group.FormattingEnabled = true;
                this.m_cbl_group.Location = new System.Drawing.Point(0, 95);
                this.m_cbl_group.Name = "m_cbl_group";
                this.m_cbl_group.Size = new System.Drawing.Size(239, 349);
                this.m_cbl_group.TabIndex = 2;
                this.toolTip1.SetToolTip(this.m_cbl_group, "1. Check vào nhóm bạn muốn đăng bài nhé\r\n2. Buôn có bạn, bán có phường. Tham gia " +
                        "vào nhiều nhóm đông người, cũng bán sản phẩm của bạn nữa.");
                this.panel1.Controls.Add(this.m_cbl_group);
                //--------------------------------------------------------------------------------------------------
                m_access_token = globalInfo.access_token;
                FacebookClient fb = new FacebookClient(m_access_token);
                dynamic data = fb.Get("/me?fields=name");
                m_uid = data["id"];
                Display_post(m_access_token);
            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
           
        }

        private void m_cmd_advance_Click(object sender, EventArgs e)
        {
            try {
                Advance v_f = new Advance();
                v_f.Display(this);
            }
            catch (Exception v_e) {


                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
         
        }

        private void m_chk_all_CheckedChanged(object sender, EventArgs e)
        {
            try {
                if (m_chk_all.Checked) {
                    for (int i = 0; i < m_cbl_group.Items.Count; i++) {
                        m_cbl_group.SetItemChecked(i, true);
                    }
                    m_chk_all.Text = "Bỏ đánh dấu để hủy chọn tất cả nhóm ở dưới";
                }
                else {
                    for (int i = 0; i < m_cbl_group.Items.Count; i++) {
                        m_cbl_group.SetItemChecked(i, false);
                    }
                    m_chk_all.Text = "Đánh dấu để chọn tất cả nhóm ở dưới";
                }
            }
            catch (Exception v_e) {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_txt_search_TextChanged(object sender, EventArgs e) {
            try {
                List<string> v_list_checked = new List<string>();
                List<string> v_list_search = new List<string>();
                List<groups> v_list_result = new List<groups>();

                //-- 0. Xóa màu các group
                m_cbl_group.Completionlist.Clear();

                //-- 1. Lấy danh sách những group đã chọn
                foreach (var item in m_cbl_group.CheckedItems)
                {
                    v_list_checked.Add(item.ToString());
                }

                //-- 2. Lấy danh sách những group thỏa mãn từ khóa tìm kiếm
                foreach (var item in m_SortedList)
                {
                    if (item.Name.ToString().ToLower().Contains(m_txt_search.Text.ToLower().Trim())) {
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
                m_cbl_group.Items.Clear();
                int index = 0;
                foreach (groups group in v_list_result)
                {
                    foreach (var name in v_list_checked)
                    {
                        if (name == group.Name)
                        {
                            check = true;
                            break;
                        }
                    }
                    
                    m_cbl_group.Items.Add(group.Name, check);
                    var v_checked = m_list_color.Find(x => x == group.Name);
                    if (v_checked != null)
                    {
                        m_cbl_group.Completionlist.Add(index);
                    }
                    index += 1;
                    check = false;
                }
            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }
    }
}
