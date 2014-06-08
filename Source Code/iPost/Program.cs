using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var license = new TienX.License.LicenseManager();
            string v_path = Directory.GetCurrentDirectory();
            v_path = v_path + "\\iPostLicense.lic";
            if (File.Exists(v_path)) {
                var v_lic = File.ReadAllText(v_path);
                var verify = license.verifyErrorCode(v_lic);
                if (verify == TienX.License.ErrorCode.Success)
                {
                    Application.Run(new LoginFacebook());
                }
                else if (verify == TienX.License.ErrorCode.Expired)
                {
                    MessageBox.Show("Hết hạn dùng thử. Hãy nhập key mới để tiếp tục sử dụng");
                    Application.Run(new Login());
                }
                else
                {
                    // License may be modified or invalid license
                    Application.Run(new Login());
                }
            }
            else
            {
                Application.Run(new Login());
            }            
        }
    }
}
