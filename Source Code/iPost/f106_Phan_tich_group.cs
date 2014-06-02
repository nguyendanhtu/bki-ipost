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
        public f106_Phan_tich_group()
        {
            InitializeComponent();
        }

        public void display(List<groups> group_list)
        {
            m_lb_groups.DisplayMember = "Name";
            m_lb_groups.ValueMember = "Id";
            m_lb_groups.DataSource = group_list;
            this.Show();
        }

        private void m_lb_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookClient fb = new FacebookClient(globalInfo.access_token);
            string gid = ((groups)m_lb_groups.SelectedItem).Id;
            dynamic data = fb.Get("/" + gid + "/feed?fields=id,created_time&limit=30");
            List<cl_post> post_list = new List<cl_post>();
            foreach (var post in (JsonArray)data["data"])
            {
                cl_post v_p = new cl_post();
                v_p.fpid = (((JsonObject)post)["id"]).ToString();
                v_p.create_time = (Facebook.DateTimeConvertor.FromIso8601FormattedDateTime((((JsonObject)post)["created_time"]).ToString())).Date;
                post_list.Add(v_p);
            }

            //------------------------------------------------------------------------
            //post per day
            decimal count_date = 0;
            decimal count_post = 0;

            foreach(var line in post_list.GroupBy(info => info.create_time)
                        .Select(group => new { 
                             Metric = group.Key, 
                             Count = group.Count() 
                        })
                        .OrderBy(x => x.Metric))
            {
                count_date += 1;
                count_post += line.Count;
            }
            if (count_post == 0)
            {
                m_lbl_post_per_day.Text = "0";
            }
            else
            {
                m_lbl_post_per_day.Text = Math.Round(count_post / count_date).ToString();
            }            
            //---------------------------------------------------------------------------------
            //like per post
            decimal count_comment = 0;
            decimal count_like = 0;
            foreach (var item in post_list)
            {
                bool name_exist = false;
                data = fb.Get("/" + item.fpid + "?fields=likes.fields(id),comments.fields(id)");
                IEnumerable<string> names = data.GetDynamicMemberNames();
                foreach (var s in names)
                {
                    if (s.Contains("likes"))
                    {
                        name_exist = true;
                        break;
                    }
                }
                if (name_exist)
                {
                    var likes = (JsonObject)data["likes"];
                    var like = (JsonArray)likes["data"];
                    foreach (var lk in like)
                    {
                        count_like += 1;
                    }
                }
                if (count_like == 0)
                {
                    m_lbl_like_per_post.Text = "0";
                }
                else
                {
                    m_lbl_like_per_post.Text = string.Format("{0:0.00}",count_like / count_post);
                }
                //--------------------------------------------------------------------------------
                name_exist = false;
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
                    var comments = (JsonObject)data["comments"];
                    var comment = (JsonArray)comments["data"];
                    foreach (var lk in comment)
                    {
                        count_comment += 1;
                    }
                }
            }
            if (count_comment == 0)
            {
                m_lbl_comment_per_post.Text = "0";
            }
            else
            {
                m_lbl_comment_per_post.Text = string.Format("{0:0.00}", count_comment / count_post);
            }
        }

        public void displayMyGroup()
        {
            FacebookClient fb = new FacebookClient(globalInfo.access_token);
            var roles = new List<groups>();
            dynamic data = fb.Get("/me/groups");

            foreach (var friend in (JsonArray)data["data"])
            {
                groups group = new groups() { Id = (string)(((JsonObject)friend)["id"]), Name = (string)(((JsonObject)friend)["name"]) };
                roles.Add(group);
            }
            roles = roles.OrderBy(o => o.Name).ToList(); ;
            m_lb_groups.DataSource = roles;
            m_lb_groups.DisplayMember = "Name";
            m_lb_groups.ValueMember = "Id";
            this.ShowDialog();
        }
    }
}
