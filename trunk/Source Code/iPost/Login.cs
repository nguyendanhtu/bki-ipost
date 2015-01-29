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

        private void m_cmd_reg_Click(object sender, EventArgs e)
        {
            try
            {
                var v_str_user_email = email.Text;
                var v_str_key = key.Text;
                var mn = new TienX.License.LicenseManager();
                //if (string.IsNullOrEmpty(v_str_key) || string.IsNullOrEmpty(v_str_user_email))
                //{
                //    MessageBox.Show("Bạn nhập key hoặc email nhé!");
                //    return;
                //}
                //else
                //{
                //    string v_past = Directory.GetCurrentDirectory();
                //    v_past = v_past + "\\iPostLicense.lic";
                //    var license = mn.requestLicenseAndSaveFile(v_str_key, v_str_user_email, v_past);
                //    if (mn.verifyLicense(license))
                //    {
                //        MessageBox.Show("Bạn đã xác thực thành công. Kiếm tiền nào!");
                //        this.Hide();
                //        LoginFacebook v_f = new LoginFacebook();
                //        v_f.ShowDialog();
                //        this.Close();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Bạn điền giúp Email và key chuẩn nhé!");
                //    }
                   
                //}
                this.Hide();
                LoginFacebook v_f = new LoginFacebook();
                v_f.ShowDialog();
                this.Close();

            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Cảm ơn bạn đã sử dụng sản phẩm iPost");
                this.Close();
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }

        }
    }
}
