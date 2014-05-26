using System;
using System.Collections.Generic;
using System.Text;

namespace TienX.License
{
    public interface ILicenseManager
    {
        bool verifyLicense(String stringData);
        bool verifyLicenseFile(String fileName);
        String requestLicense(String code, String userEmail);
        String requestLicenseAndSaveFile(String code, String userEmail, String filename);
    }
}
