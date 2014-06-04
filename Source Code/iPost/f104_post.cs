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
            catch (Exception v_e) {

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
                m_SortedList = roles.OrderBy(o => o.Name).ToList(); ;
                m_cbl_group.DataSource = m_SortedList;
                m_cbl_group.DisplayMember = "Name";
                m_cbl_group.ValueMember = "Id";
            }
            catch (Exception v_e) {


                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        internal void Updating(string p, string p_2, string p_3) {
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
                    post_2_facebook((groups)m_cbl_group.CheckedItems[i]);
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
            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
          
        }

        

        private void m_cmd_post_Click(object sender, EventArgs e)
        {
            try {
                if ((m_txt_time.Text == "") || (Convert.ToInt32(m_txt_time.Text) < 10)) {
                    MessageBox.Show("Nhập lại thời gian");
                    return;
                }
                if (backgroundWorker1.IsBusy) {
                    backgroundWorker1.CancelAsync();
                    m_cmd_post.Text = "Đăng bài";
                }
                else {
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
               

                List<groups> v_filterList = new List<groups>();
                List<groups> v_checkedlist = new List<groups>();

                //1. Lấy danh sách các group đã chọn
                for (int i = 0; i < m_cbl_group.CheckedItems.Count; i++) {
                    v_checkedlist.Add((groups)m_cbl_group.CheckedItems[i]);
                    v_filterList.Add((groups)m_cbl_group.CheckedItems[i]);
                }

              //2. Lấy danh sách các group thỏa mãn tìm kiếm
                foreach (groups v_froup in m_SortedList) {
                    if (v_froup.Name.ToLower().IndexOf(m_txt_search.Text.ToLower()) >= 0) {
                        int index = v_filterList.FindIndex(item => item.Id == v_froup.Id);
                        if (index < 0) {
                            v_filterList.Add(v_froup);  
                        }
                        
                    }
                        
                }
                //3. Đưa danh sách lên LIST
                if (m_txt_search.Text.Trim().Length == 0) {
                    m_cbl_group.DataSource = m_SortedList;                  
                }
                else {

                    m_cbl_group.DataSource = v_filterList;
                }
                m_cbl_group.DisplayMember = "Name";
                m_cbl_group.ValueMember = "Id";
                //4. Đánh dấu các Group đã chọn.
                for (int i = 0; i < m_cbl_group.Items.Count; i++) {
                    m_cbl_group.SetItemChecked(i, false);
                }
                for (int i = 0; i < m_cbl_group.Items.Count; i++) {
                    groups v_group = (groups)m_cbl_group.Items[i];
                    
                    if (v_checkedlist.FindIndex(item => item.Id ==v_group.Id)>=0){
                    m_cbl_group.SetItemChecked(i, true);
                    }
                }

            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }
    }
}
