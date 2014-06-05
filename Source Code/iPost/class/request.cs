using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace test
{
    public class request
    {
        public string user_id { get; set; }
        public string dtsg { get; set; }
        public string group_id { get; set; }

        string[] cookies = { };

        public void request_2_fb(string ip_request_url, string ip_request_method)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(ip_request_url);
            request_init(myRequest, ip_request_method);
            string postData = dataPost();
            byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            myRequest.ContentLength = byteArray.Length;
            Stream newStream = myRequest.GetRequestStream(); //open connection
            newStream.Write(byteArray, 0, byteArray.Length); // Send the data.
            newStream.Close();
        }

        public CookieCollection cookie_init()
        {
            CookieCollection ip_cookie = new CookieCollection();
            read_cookie_from_hard_disk();
            Cookie locale = new Cookie("locale", "en-US");
            Cookie datr = new Cookie("datr", "");
            Cookie lu = new Cookie("lu", "-w");
            Cookie csm = new Cookie("csm", "");
            Cookie xs = new Cookie("xs", "");
            Cookie fr = new Cookie("fr", "");
            Cookie s = new Cookie("s", "");
            Cookie c_user = new Cookie("c_user", "");            

            for (int i = 0; i < cookies.Length; i++)
            {
                if (cookies[i].ToString() == "datr")
                {
                    datr.Value = cookies[i + 1].ToString();
                    continue;
                }
                if (cookies[i].ToString() == "lu")
                {
                    lu.Value = cookies[i + 1].ToString();
                    continue;
                }
                if (cookies[i].ToString() == "csm")
                {
                    csm.Value = cookies[i + 1].ToString();
                    continue;
                }
                if (cookies[i].ToString() == "xs")
                {
                    xs.Value = cookies[i + 1].ToString();
                    continue;
                }
                if (cookies[i].ToString() == "fr")
                {
                    fr.Value = cookies[i + 1].ToString();
                    continue;
                }
                if (cookies[i].ToString() == "s")
                {
                    s.Value = cookies[i + 1].ToString();
                    continue;
                }
                if (cookies[i].ToString() == "c_user")
                {
                    c_user.Value = cookies[i + 1].ToString();
                    continue;
                }
            }
            
            locale.Domain = ".facebook.com";
            datr.Domain = ".facebook.com";
            lu.Domain = ".facebook.com";            
            csm.Domain = ".facebook.com";
            xs.Domain = ".facebook.com";
            fr.Domain = ".facebook.com";
            s.Domain = ".facebook.com";
            c_user.Domain = ".facebook.com";

            ip_cookie.Add(locale);
            ip_cookie.Add(datr);
            ip_cookie.Add(lu);            
            ip_cookie.Add(csm);
            ip_cookie.Add(xs);
            ip_cookie.Add(fr);
            ip_cookie.Add(s);
            ip_cookie.Add(c_user);
            return ip_cookie;
        }

        private void request_init(HttpWebRequest ip_request, string ip_method) {
            ip_request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.159 CoRom/33.0.1750.159 Safari/537.36";
            ip_request.ProtocolVersion = HttpVersion.Version11;
            ip_request.Method = ip_method;
            ip_request.AllowAutoRedirect = true;
            ip_request.ContentType = "application/x-www-form-urlencoded";
            ip_request.CookieContainer = new CookieContainer();
            ip_request.CookieContainer.Add(globalInfo.cookie_collection);            
        }

        private string dataPost() {
            string postData = "ref=group_jump_header&group_id="+group_id+"&__user="+user_id+"&__a=1&__dyn=7n8ahyj35zoSt2u6aOGeEwlyp9EbEyGgSmEVF4WpUpBxCEG&__req=8&fb_dtsg="+dtsg+"&ttstamp=2658169110901201171079710310681&__rev=1232856";
            return postData;
        }

        private void read_cookie_from_hard_disk() {
            string pathWithEnv = "";
            System.OperatingSystem osInfo = System.Environment.OSVersion;
            string osVersion = osInfo.VersionString;
            if (osVersion.Contains("6.1"))
            {
                pathWithEnv = @"%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Cookies";
            }
            else if ((osVersion.Contains("6.2")) || (osVersion.Contains("6.3")))
            {
                pathWithEnv = @"%USERPROFILE%\AppData\Local\Microsoft\Windows\INetCookies";
            }

            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            string[] filePaths = Directory.GetFiles(filePath, "*.txt", SearchOption.AllDirectories);
            bool v_status = false;

            foreach (var item in filePaths)
            {
                string[] lines = System.IO.File.ReadAllLines(item.ToString());
                foreach (string line in lines)
                {
                    if (line.Contains("facebook"))
                    {
                        cookies = lines;
                        v_status = true;
                    }
                }
                if (v_status)
                {
                    break;
                }
            }
        }
    }
}
