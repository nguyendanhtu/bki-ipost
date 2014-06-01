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

namespace test
{
    public partial class f107_PostFollow : Form
    { 
        #region Member
        string p_id = "";
        string access_token = "";
        string m_uid = "";
        #endregion

        #region Private Method
        private void gen_text_comment()
        {
            bool name_exist = false;
            string text = "";
            try
            {
                FacebookClient fb = new FacebookClient(access_token);
                dynamic data = fb.Get(p_id.Trim() + "?fields=comments");
                IEnumerable<string> names = data.GetDynamicMemberNames();
                foreach (var s in names)
                {
                    if (s.Contains("comments"))
                    {
                        name_exist = true;
                        break;
                    }
                }
            
                if (name_exist)
                {
                    dynamic comments = ((JsonObject)data)["comments"];                    
                    foreach (var post in (JsonArray)comments["data"])
                    {
                        //groups group = new groups() { Id = (string)(((JsonObject)post)["id"]), Name = (string)(((JsonObject)post)["name"]) };
                        dynamic from = ((JsonObject)post)["from"];
                        string uid = (string)((JsonObject)from)["id"];
                        string name = (string)((JsonObject)from)["name"];
                        string message = (string)((JsonObject)post)["message"];
                        text += "<font color=\"#3b5998\" style=\"font-family:Arial; font-weight:bold; font-size:11.818181991577148px\">" + name + " </font>" + "<font style=\"font-family:Arial; font-size:12px\">" + message + "</font><br />";
                    }
                }
                else
                {
                    text = "<p>Không có bình luận nào</p>";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bài đăng đã bị xóa hoặc chưa được chấp nhận");
            }            
            m_wb.DocumentText = text;
        }

        private void comment_this_post(string p)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\BKIndex\AutoPostToGroup\at.txt");
            string access_token = lines[0];
            FacebookClient fb = new FacebookClient(access_token);
            dynamic parameters = new ExpandoObject();
            parameters.message = p;
            dynamic result = fb.Post(p_id + "/comments", parameters);
            gen_text_comment();
        }

        private void load_data_2_grv()
        {
            FacebookClient fb = new FacebookClient(access_token);
            m_grv.AutoGenerateColumns = false;
            var roles = new List<cl_post>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\BKIndex\AutoPostToGroup\postId.txt");
            for (int i = 0; i < lines.Count(); i++)
            {
                string post = lines[i].Trim();
                if (post.Contains(m_uid.Trim()))
                {
                    cl_post v_cl_post = new cl_post();
                    v_cl_post.fuid = m_uid;
                    post = post.Substring(m_uid.Length + 1, post.Length - m_uid.Length - 1);
                    v_cl_post.fpid = post.Trim();
                    v_cl_post.content = lines[i + 2].Trim();
                    v_cl_post.fgid = lines[i + 1].Trim();
                    roles.Add(v_cl_post);
                }
            }
            m_grv.DataSource = roles;
        }

        #endregion

        #region Public Interface
        public f107_PostFollow()
        {
            InitializeComponent();
            this.CenterToScreen();
            access_token = globalInfo.access_token;
        }
        #endregion

        #region Event
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p_id = m_grv.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            gen_text_comment();
        }

        private void m_txt_comment_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string p = m_txt_comment.Text;
                    m_txt_comment.Text = "";
                    comment_this_post(p);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");                
            }
            
        }

        private void m_grv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            p_id = m_grv.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            gen_text_comment();
        }

        private void f107_PostFollow_Load(object sender, EventArgs e)
        {
            try
            {
                FacebookClient fb = new FacebookClient(access_token);
                dynamic data = fb.Get("/me?fields=name");
                m_uid = data["id"];
                m_uid = m_uid.Trim();
                load_data_2_grv();
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Bạn chưa có bài đăng nào");                
            }
            
        }

        private void m_cmd_show_post_Click(object sender, EventArgs e)
        {
            F109_Show_post v_f = new F109_Show_post();
            v_f.display(p_id);
        }
        #endregion
    }
}
