using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;

namespace test
{
    public partial class f106_Phan_tich_group : Form
    {
        #region Members
        List<groups> m_SortedList = new List<groups>();
        #endregion

        #region Private Methods
        private bool checkExistParameter(JsonArray ip_arr, string ip_para) {
            return false;
        }        

        private string getCountThanhVien(string ip_gid) {

            return "";
        }

        private bool checkNameExist(dynamic data, string name) {
            IEnumerable<string> names = data.GetDynamicMemberNames();
            foreach (var s in names) {
                if (s.Contains(name)) {
                    return true;
                }
            }
            return false;
        }

        private void reset_lbl() {
            m_groupbox.Visible = false;
        }

        private void m_cmd_phan_tich_group_Click(object sender, EventArgs e)
        {
            try
            {
                #region variable
                decimal count_like = 0;
                decimal count_date = 0;
                decimal count_post = 0;
                decimal count_comment = 0;
                int gold_hour = 0;
                int gold_hour_comment = 0;
                int silver_hour = 0;
                int max_post = 0;
                int max_comment = 0;
                int min_post = 1000;
                string v_limit = "";
                bool name_exist = false;
                List<DateTime> v_list_dat = new List<DateTime>();
                #endregion
                reset_lbl();

                if (m_rdb_30.Checked)
                {
                    v_limit = "30";
                }
                else if (m_rdb_50.Checked)
                {
                    v_limit = "100";
                }
                else
                {
                    v_limit = "200";
                }

                FacebookClient fb = new FacebookClient(globalInfo.access_token);
                string gid = ((groups)m_lb_groups.SelectedItem).Id;

                dynamic data = fb.Get("/" + gid + "?fields=feed.limit(" + v_limit + ").fields(id,created_time,likes.fields(id),comments.fields(id,created_time))");
                var feed = (JsonObject)data["feed"];
                List<cl_post> post_list = new List<cl_post>();
                foreach (dynamic post in (JsonArray)feed["data"])
                {
                    cl_post v_p = new cl_post();
                    v_p.fpid = (((JsonObject)post)["id"]).ToString();
                    v_p.create_time = (Facebook.DateTimeConvertor.FromIso8601FormattedDateTime((((JsonObject)post)["created_time"]).ToString()));

                    //----------------------------------------------------------
                    name_exist = checkNameExist(post, "likes");
                    if (name_exist)
                    {
                        var likes = (JsonObject)post["likes"];
                        var like = (JsonArray)likes["data"];
                        foreach (var lk in like)
                        {
                            count_like += 1;
                        }
                    }
                    v_p.like_count = count_like;
                    //----------------------------------------------------------                
                    name_exist = checkNameExist(post, "comments");
                    if (name_exist)
                    {
                        var comments = (JsonObject)post["comments"];
                        var comment = (JsonArray)comments["data"];

                        foreach (var lk in comment)
                        {
                            DateTime create_time = Facebook.DateTimeConvertor.FromIso8601FormattedDateTime(((JsonObject)lk)["created_time"].ToString());
                            v_list_dat.Add(create_time);
                            count_comment += 1;
                        }
                    }
                    v_p.comment_count = count_comment;
                    //----------------------------------------------------------
                    post_list.Add(v_p);
                }

                //------------------------------------------------------------------------
                //post per day
                #region post per day
                foreach (var line in post_list.GroupBy(info => info.create_time.Date)
                            .Select(group => new
                            {
                                Metric = group.Key,
                                Count = group.Count()
                            })
                            .OrderBy(x => x.Metric))
                {
                    count_date += 1;
                    count_post += line.Count;
                }
                #endregion
                //------------------------------------------------------------------------
                //gold hour
                #region gold hour
                foreach (var line in post_list.GroupBy(info => info.create_time.Hour)
                            .Select(group => new
                            {
                                Metric = group.Key,
                                Count = group.Count()
                            })
                            .OrderBy(x => x.Metric))
                {
                    if (line.Count > max_post)
                    {
                        max_post = line.Count;
                        gold_hour = (line.Metric + 7) % 24;
                    }
                    if (line.Count < min_post)
                    {
                        min_post = line.Count;
                        silver_hour = (line.Metric + 7) % 24;
                    }
                }
                #endregion
                //------------------------------------------------------------------------
                //gold hour for comment
                #region gold hour
                var list = v_list_dat.GroupBy(info => info.Hour)
                            .Select(group => new
                            {
                                Metric = group.Key,
                                Count = group.Count()
                            })
                            .OrderBy(x => x.Metric);
                foreach (var line in list)
                {
                    if (line.Count > max_comment)
                    {
                        max_comment = line.Count;
                        gold_hour_comment = (line.Metric + 7) % 24;
                    }
                }
                #endregion
                //------------------------------------------------------------------------
                #region Print Result
                if (count_post == 0)
                {
                    m_lbl_post_per_day.Text = "0";
                }
                else
                {
                    m_lbl_post_per_day.Text = string.Format("{0:0.00}", count_post / count_date);
                }

                if (count_like == 0)
                {
                    m_lbl_like_per_post.Text = "0";
                }
                else
                {
                    m_lbl_like_per_post.Text = string.Format("{0:0.00}", count_like / count_post);
                }

                if (count_comment == 0)
                {
                    m_lbl_comment_per_post.Text = "0";
                }
                else
                {
                    m_lbl_comment_per_post.Text = string.Format("{0:0.00}", count_comment / count_post);
                }
                m_lbl_gold_hour.Text = "Từ " + gold_hour.ToString() + "h đến " + (gold_hour + 1).ToString() + "h";
                m_lbl_silver.Text = "Từ " + silver_hour.ToString() + "h đến " + (silver_hour + 1).ToString() + "h";
                m_lbl_gold_hour_action.Text = "Từ " + gold_hour_comment.ToString() + "h đến " + (gold_hour_comment + 1).ToString() + "h";
                #endregion
                m_groupbox.Visible = true;
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

                List<groups> v_filterList = new List<groups>();
                List<groups> v_checkedlist = new List<groups>();


                //1. Lấy danh sách các group thỏa mãn tìm kiếm
                foreach (groups v_froup in m_SortedList)
                {
                    if (v_froup.Name.ToLower().IndexOf(m_txt_search.Text.ToLower()) >= 0)
                    {
                        int index = v_filterList.FindIndex(item => item.Id == v_froup.Id);
                        if (index < 0)
                        {
                            v_filterList.Add(v_froup);
                        }

                    }

                }
                //2. Đưa danh sách lên LIST
                if (m_txt_search.Text.Trim().Length == 0)
                {
                    m_lb_groups.DataSource = m_SortedList;
                }
                else
                {

                    m_lb_groups.DataSource = v_filterList;
                }
                m_lb_groups.DisplayMember = "Name";
                m_lb_groups.ValueMember = "Id";

            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }    
        #endregion

        #region public method

        public f106_Phan_tich_group()
        {
            InitializeComponent();
        }
        public void displayMyGroup()
        {
            FacebookClient fb = new FacebookClient(globalInfo.access_token);

            dynamic data = fb.Get("/me/groups");

            foreach (var friend in (JsonArray)data["data"])
            {
                groups group = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                m_SortedList.Add(group);
            }
            m_SortedList = m_SortedList.OrderBy(o => o.Name).ToList(); ;
            m_lb_groups.DataSource = m_SortedList;
            m_lb_groups.DisplayMember = "Name";
            m_lb_groups.ValueMember = "Id";
            this.ShowDialog();
        }

        public void display(List<groups> group_list)
        {
            m_lb_groups.DisplayMember = "Name";
            m_lb_groups.ValueMember = "Id";
            m_lb_groups.DataSource = group_list;
            this.Show();
        }
        #endregion
    }
}
