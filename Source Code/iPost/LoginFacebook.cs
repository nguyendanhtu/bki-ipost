using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.IO;
using System.Management;

namespace test
{
    public partial class LoginFacebook : Form
    {
        #region Public Interface
        public LoginFacebook()
        {
            InitializeComponent();
            this.CenterToScreen();
            delete_cookie_from_hard_disk();
            m_wb.Navigate(Login_with_guest());
        }
        #endregion

        #region Members
        string access_token = "";
        string dtsg = "";
        int trang_thai = 0;
        bool get_access_token = false;
        int i = 0;
        #endregion                

        #region Private Method
        private void delete_cookie_from_hard_disk()
        {
            string pathWithEnv = "";
            string path1 = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                path1 = Directory.GetParent(path1).ToString();
            }
            string path = path1 + @"\AppData\Roaming\Microsoft\Windows\Cookies";
            if (Directory.Exists(path))
            {
                pathWithEnv = path;
            }
            else
            {
                pathWithEnv = path1 + @"\AppData\Local\Microsoft\Windows\INetCookies";
            }

            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            string[] filePaths = Directory.GetFiles(filePath, "*.txt", SearchOption.AllDirectories);

            foreach (var item in filePaths)
            {
                string[] lines = System.IO.File.ReadAllLines(item.ToString());
                foreach (string line in lines)
                {
                    if (line.Contains("facebook"))
                    {
                        File.Delete(item);
                    }
                }
            }
        }

        private string Login_with_guest()
        {
            FacebookClient fb_client = new FacebookClient();
            var loginUrl = fb_client.GetLoginUrl(new
            {

                client_id = "145634995501895",

                redirect_uri = "https://www.facebook.com/connect/login_success.html",

                response_type = "token",

                scope = "user_groups,publish_actions" // Add other permissions as needed

            });
            return loginUrl.AbsoluteUri;
        }

        private void m_wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (m_wb.Url.AbsoluteUri.Contains("access_token"))
            {
                string url1 = m_wb.Url.AbsoluteUri;
                string url2 = url1.Substring(url1.IndexOf("access_token") + 13);
                access_token = url2.Substring(0, url2.IndexOf("&"));


                FacebookClient fb = new FacebookClient(access_token);
                dynamic data = fb.Get("/me?fields=name");
                get_access_token = true;
                m_wb.Navigate("https://facebook.com");
            }

            if (get_access_token)
            {
                HtmlDocument v_doc = m_wb.Document;
                HtmlElement v_e = v_doc.GetElementsByTagName("input")["fb_dtsg"];
                if (v_e != null)
                {
                    trang_thai++;
                    if (trang_thai == 1)
                    {
                        dtsg = v_e.GetAttribute("value").ToString();
                        System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\BKIndex\AutoPostToGroup\at.txt");
                        file.WriteLine(access_token.Trim());
                        file.WriteLine(dtsg.Trim());
                        file.Close();
                    }
                }
            }


            if (dtsg != "")
            {
                if (trang_thai == 1)
                {
                    this.Hide();
                    this.Controls.Remove(m_wb);
                    f103_Main v_f = new f103_Main();
                    v_f.ShowDialog();
                    this.Close();
                }
            }
        }
        #endregion      
    }
}
