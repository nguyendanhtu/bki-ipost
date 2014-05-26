using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TienX.License;

namespace TestLicenseManager
{
    class Program
    {
        public static void Main(String[] args)
        {
            var lm = new LicenseManager();
            var license = lm.requestLicense("632359", "vunb@bkindex.com");
            var test = lm.verifyLicense(license);

            if (test)
            {
                Console.WriteLine("License is okey. Please save file and check every time program startup .");
                File.WriteAllText("fileName.lic", license);
            }
            else
            {
                Console.WriteLine("License is fake");
            }
            Console.ReadLine();

        }


    }
}
