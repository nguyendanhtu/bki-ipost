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
                var verify = license.verifyErrorCode(v_path);
                if (verify == TienX.License.ErrorCode.Success)
                {
                    Application.Run(new LoginFacebook());
                }
                else
                {
                    MessageBox.Show("Hết hạn dùng thử");
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
