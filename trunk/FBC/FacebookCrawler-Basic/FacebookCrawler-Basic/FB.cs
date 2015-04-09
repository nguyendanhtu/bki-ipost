using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookCrawler_Basic
{
    public partial class FB : Form
    {
        Stack<string> m_stk = new Stack<string>();

        public FB()
        {
            InitializeComponent();
        }

        private void m_cmd_start_Click(object sender, EventArgs e)
        {
            getAllMyFriends();
        }

        private void getAllMyFriends()
        {
            navigateUrl("https://www.facebook.com/ajax/typeahead/first_degree.php?__a=1&filter[0]=user&lazy=0&viewer=100004685250081&token=v7&stale_ok=0&options[0]=friends_only&options[1]=nm");
            var v_lst_friends = GetSubStrings(m_wb.Document.Body.OuterHtml, "profile.php?id=", "\"").ToList();
            foreach (var item in v_lst_friends)
            {
                m_stk.Push(item);
            }
            while (m_stk.Count > 0)
            {
                string uid = m_stk.Pop();
                int v_start = 0;
                while (true)
                {
                    navigateUrl("https://www.facebook.com/ajax/browser/list/allfriends/?uid="+uid+"&__user=100004685250081&__a=1&start="+v_start.ToString());
                    var v_lst_friend_friend = GetSubStrings(m_wb.Document.Body.OuterHtml, "friend_id=", "\\\"").ToList();
                    if (v_lst_friend_friend.Count > 0)
                    {
                        foreach (var item in v_lst_friend_friend)
                        {
                            if (!v_lst_friends.Exists(x => x == item))
                            {
                                v_lst_friends.Add(item);
                                m_stk.Push(item);
                            }
                        }
                        v_start += 24;
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
        }

        private void navigateUrl(string p)
        {
            m_wb.Navigate(p);
            while (m_wb.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        private IEnumerable<string> GetSubStrings(string input, string start, string end)
        {
            Regex r = new Regex(Regex.Escape(start) + "(.*?)" + Regex.Escape(end));
            MatchCollection matches = r.Matches(input);
            foreach (Match match in matches)
                yield return match.Groups[1].Value;
        }

        private void m_cmd_login_fb_Click(object sender, EventArgs e)
        {
            m_wb.Navigate("https://www.facebook.com/ajax/typeahead/first_degree.php?__a=1&filter[0]=user&lazy=0&viewer=100004685250081&token=v7&stale_ok=0&options[0]=friends_only&options[1]=nmhttps://www.facebook.com/ajax/typeahead/first_degree.php?__a=1&filter[0]=user&lazy=0&viewer=100004685250081&token=v7&stale_ok=0&options[0]=friends_only&options[1]=nm");
            while (m_wb.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        private void m_cmd_get_cookie_Click(object sender, EventArgs e)
        {
            var cookies = m_wb.Document.Cookie;
            CookieContainer v_c = new CookieContainer();
            v_c.Add(globalInfo.cookie_collection);
            var request = (HttpWebRequest)WebRequest.Create("https://www.facebook.com/ajax/browser/list/allfriends/?uid=825006896&__user=100004685250081&__a=1&start=0");
            request.AllowAutoRedirect = true;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "GET";
            request.ProtocolVersion = HttpVersion.Version11;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.159 CoRom/33.0.1750.159 Safari/537.36";
            request.CookieContainer = v_c;
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        private CookieContainer setCookieContainer(string cookies)
        {
            CookieContainer v_container = new CookieContainer();
            CookieCollection v_collection_cookie = new CookieCollection();
            var v_arr_cookie = cookies.Split(';');
            foreach (string item in v_arr_cookie)
            {
                var name_value = item.Split('=');
                Cookie v_c = new Cookie(name_value[0].Trim(),name_value[0].Trim());
                v_c.Domain = ".facebook.com";
                v_collection_cookie.Add(v_c);
            }            
            v_container.Add(v_collection_cookie);
            return v_container;
        }

        private void m_cmd_set_cookie_Click(object sender, EventArgs e)
        {
            Cookies v_f_c = new Cookies();
            v_f_c.ShowDialog();
        }
    }
}
