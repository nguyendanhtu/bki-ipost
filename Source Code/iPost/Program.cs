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
            if (File.Exists("C://iPostLicense.lic")) {
                bool verify = license.verifyLicenseFile("C://iPostLicense.lic");
                if (verify)
                {
                    Application.Run(new LoginFacebook());
                }
                else
                {
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
