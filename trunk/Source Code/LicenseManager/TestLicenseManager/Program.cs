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
            var date = DateTime.Parse("2014-06-03 17:47:07");
            var lm = new LicenseManager();
            var license = lm.requestLicense("69727370", "vunb@bkindex.com");
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

            // Or check license use specified code
            var test2 = lm.verifyErrorCode(license); // get Error Code specified
            if (test2 == ErrorCode.Expired)
            {
                Console.WriteLine("Expired Trial");
            }
            else if (test2 == ErrorCode.Invalid)
            {
                Console.WriteLine("Fake license!");
            }
            else if (test2 == ErrorCode.Failure)
            {
                Console.WriteLine("License may be fake!");
            }
            else if (test2 == ErrorCode.Success)
            {
                Console.WriteLine("Everything seems to be okay !");
            }

        }


    }
}
