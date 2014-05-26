using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFacebook v_f = new LoginFacebook();
            v_f.ShowDialog();
            this.Close();
        }

        private string Encrypt(string p)
        {
            string result = "";
            for (int i = 0; i < p.Length; i++)
            {
                char s = p[i];
                int value = (int)s;
                value += 14;
                s = (char)value;
                result = result + s;
            }
            result += "FO2O34090KNSD";
            return result;
        }

        private string Decrypt(string p)
        {
            string result = "";
            for (int i = 0; i < p.Length - 13; i++)
            {
                char s = p[i];
                int value = (int)s;
                value -= 14;
                s = (char)value;
                result = result + s;
            }
            return result;
        }

        private void rewrite()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Windows\Test\9HSADFDSJ.txt");
            string s = Decrypt(lines[0].Trim());
            int count_days = Convert.ToInt32(s) - 1;
            string s2 = Encrypt(count_days.ToString());
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Windows\Test\9HSADFDSJ.txt");
            file.WriteLine(s2);
            file.Close();
        }

        private bool kiem_tra_han_dung_thu()
        {
            string curFile = @"C:\Windows\Test\9HSADFDSJ.txt";
            if (!File.Exists(curFile))
            {
                MessageBox.Show("Bạn cần cài đặt với quyền Adminitrator và \n chạy phần mềm với quyền Adminitrator");
                return false;
            }
            string[] lines = System.IO.File.ReadAllLines(@"C:\Windows\Test\9HSADFDSJ.txt");
            string s = Decrypt(lines[0].Trim());
            int count_days = Convert.ToInt32(s);
            if (count_days > 0)
            {
                button2.Enabled = true;
                return true;
            }
            else
            {
                MessageBox.Show("Dùng thử hết hạn");
                return false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (kiem_tra_han_dung_thu())
                {
                    rewrite();
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Run as Adminitrator");
                this.Close();
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var v_str_user_email = email.Text;
            var v_str_key = key.Text;
            var mn = new TienX.License.LicenseManager();
            if (string.IsNullOrEmpty(v_str_key)||string.IsNullOrEmpty(v_str_user_email))
            {
                MessageBox.Show("Chưa nhập key hoặc email");
                return;
            }
            else
            {
                var license = mn.requestLicenseAndSaveFile(v_str_key, v_str_user_email,"C://test.lic");
                if (mn.verifyLicense(license))
                {
                    MessageBox.Show("true");
                }
                else
                {
                    MessageBox.Show("false");
                }
            }
        }
    }
}
