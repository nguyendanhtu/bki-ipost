using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;

namespace TienX.License
{
    public enum ErrorCode
    {
        Success,
        Failure,
        Expired,
        Invalid
    }
    /// <summary>
    /// License Manager
    /// </summary>
    public class LicenseManager : ILicenseManager
    {


        private const String REQUEST_LICENSE_FORMAT = "version=1.2\nmacAddr={0}\ncomputerName={1}\nuserID={2}";
        private const String VERIFY_LICENSE_FORMAT = "VER=1.2"
            + "\nAID={0}"
            + "\nUID={1}"
            + "\nMAC={2}"
            + "\nISD={3}"
            + "\nEXP={4}";
        private const String REQUEST_URL_FORMAT = "http://tienx.vn/licman/verify/{0}/{1}";

        public const String VERIFY_SUCCESS = "true";
        public const String VERIFY_FAIL = "false";
        public const String LICENSE_ENDLESS = "0";

        // Variables
        private AsymmetricKeyParameter key = null;

        #region Public Function
        public LicenseManager()
        {
            try
            {
                this.key = findPemAndCreateKey();
            }
            catch (Exception ex)
            {
                throw new Exception("licmanPublicKey not Found or wrong Format: Please check your settings in SomeResources.resx", ex);
            }
        }

        public LicenseManager(String resourceBaseName)
        {
            var rm = new ResourceManager(resourceBaseName, Assembly.GetEntryAssembly());
            var pem = rm.GetString("licmanPublicKey");
            if (pem != null)
            {
                this.key = getAsymmetricKeyParameter(pem);
            }
        }

        private static AsymmetricKeyParameter getAsymmetricKeyParameter(String publicKeyPem)
        {
            TextReader reader = new StringReader(publicKeyPem);
            var pemReader = new Org.BouncyCastle.OpenSsl.PemReader(reader);
            return pemReader.ReadObject() as AsymmetricKeyParameter;
        }

        public static String findPem()
        {
            var asm = Assembly.GetEntryAssembly();
            var names = asm.GetManifestResourceNames();
            foreach (var name in names)
            {
                try
                {
                    var baseName = name.Replace(".resources", "");
                    var rm = new ResourceManager(baseName, asm);
                    var pem = rm.GetString("licmanPublicKey");
                    if (pem != null)
                    {
                        return pem;
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            return null;
        }

        public static AsymmetricKeyParameter findPemAndCreateKey()
        {
            var asm = Assembly.GetEntryAssembly();
            var names = asm.GetManifestResourceNames();
            foreach (var name in names)
            {
                try
                {
                    var rm = new ResourceManager(name.Replace(".resources", String.Empty), asm);
                    var pem = rm.GetString("licmanPublicKey");
                    if (pem != null)
                    {
                        var key = getAsymmetricKeyParameter(pem);
                        return key;
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            return null;
        }
        #endregion


        private bool verifyLicense(byte[] data, byte[] sig)
        {
            var kparam = key as RsaKeyParameters;
            var p1 = DotNetUtilities.ToRSAParameters(kparam);
            var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(p1);

            // compute sha256 hash of the data
            var sha = new SHA256Managed();
            var hash = sha.ComputeHash(data);

            var hashName = CryptoConfig.MapNameToOID("SHA256");
            // This always returns false
            return rsa.VerifyHash(hash, hashName, sig);
        }

        public ErrorCode verifyErrorCode(String license)
        {
            try
            {
                var properties = TienXUtils.getProperties(license);
                var aid = properties["AID"] as String;
                var uid = properties["UID"] as String;
                var isd = properties["ISD"] as String;
                var exp = properties["EXP"] as String;
                var lic = properties["LIC"] as String;

                var userMac = NetworkUtils.getAllMacAddr();
                foreach (var mac in userMac)
                {
                    var userInfo = String.Format(VERIFY_LICENSE_FORMAT, aid, uid, mac, isd, exp);
                    var licBuffer = Encoding.UTF8.GetBytes(userInfo);
                    var sigBuffer = ByteExtensions.StringToByteArray(lic);
                    var result = verifyLicense(licBuffer, sigBuffer);
                    if (result)
                    {
                        // Kiem tra thoi han su dung
                        // Pay attention when editing the source code
                        var issueDate = DateTime.Parse(isd);
                        if (DateTime.Now.CompareTo(issueDate) < 0)
                        {
                            return ErrorCode.Invalid;
                        }
                        else if (LICENSE_ENDLESS.Equals(exp))
                        {
                            return ErrorCode.Success;
                        }
                        else if (DateTime.Now.CompareTo(issueDate.AddDays(int.Parse(exp))) > 0)
                        {
                            return ErrorCode.Expired;
                        }
                        else
                        {
                            // Trong thoi han su dung
                            return ErrorCode.Success;
                        }
                    }
                }
                // return false;
                return ErrorCode.Failure;
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("#DateTime: ")
                    .Append(DateTime.Now.ToShortDateString())
                    .AppendLine()
                    .Append("@Message: ")
                    .Append(ex.Message)
                    .AppendLine()
                    .Append(ex.StackTrace);
                File.AppendAllText("lm.log", sb.ToString());
                return ErrorCode.Invalid;
            }
        }

        /// <summary>
        /// userID=user@gmail.com
        /// computerName=user-pc
        /// licenseString=0FD4A4340700ED02BE9A7512E6A7DB67295A7ACA88E7ABA8A2DFD2545B9F8EBB16E52FC63AF967406D005DADC9CF239321E72C5126E7D4096E37C4D7273B881F
        /// </summary>
        /// <param name="license"></param>
        /// <returns></returns>
        public bool verifyLicense(String license)
        {
            return verifyErrorCode(license) == ErrorCode.Success;
        }

        public bool verifyLicenseFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                var fileData = sr.ReadToEnd().Replace("\r", "");
                return verifyLicense(fileData);
            }
        }

        public String requestUserInfo(String userID)
        {
            //0FD4A4340700ED02BE9A7512E6A7DB67295A7ACA88E7ABA8A2DFD2545B9F8EBB16E52FC63AF967406D005DADC9CF239321E72C5126E7D4096E37C4D7273B881F
            var userMac = NetworkUtils.getMacAddr();
            var computerName = System.Environment.MachineName;
            var userInfo = String.Format(REQUEST_LICENSE_FORMAT, userMac, computerName, userID);
            var buffer = Encoding.UTF8.GetBytes(userInfo);
            var encrypted = Encrypt2(buffer, key);
            var hex = BitConverter.ToString(encrypted).Replace("-", string.Empty);
            return hex;
        }

        public String requestLicense(String code, String userEmail)
        {
            //0FD4A4340700ED02BE9A7512E6A7DB67295A7ACA88E7ABA8A2DFD2545B9F8EBB16E52FC63AF967406D005DADC9CF239321E72C5126E7D4096E37C4D7273B881F
            //0FD4A4340700ED02BE9A7512E6A7DB67295A7ACA88E7ABA8A2DFD2545B9F8EBB16E52FC63AF967406D005DADC9CF239321E72C5126E7D4096E37C4D7273B881F
            //6921B94019CF7D412C8CFD798275F42F838B376A9CF89F21EBB0015D35E120A77EA7DBD8C3A7AEE9AC56DD6676F4EAD196CBEB36F0FCCDBE952B60F4A8F58AE0AA46EB9EDDD894EC2557E8A29BA10A21CB6155475A25D24478CDFB72D6E3F9A694ABB6A88AC8BA2B9FCF02F9E74BA58AB59F01E68B9C3A51EB0CF8AF265CC0E537905ECA53B7F4675B8BA5100E671F3019044ABA256EE1D38C336E6D471B8167A641210B556853779D6D1FDF83F55DE50CF21BC242F0D3712DAE41985D90FDDC7E2DA1F32BB799F7A13954FBCD1BBD6E000031FEBC33F6CBA7796444C01423B90F93F6DA7080CAC2D0705F84512F266E97C8ECB99E96D7243601903105F2A966
            var userMac = NetworkUtils.getMacAddr(); //"C01885BA6348"
            var computerName = System.Environment.MachineName;
            var userInfo = String.Format(REQUEST_LICENSE_FORMAT, userMac, computerName, userEmail);
            var buffer = Encoding.UTF8.GetBytes(userInfo);
            var encrypted = Encrypt2(buffer, key);
            //var decrypted = Decrypt(encrypted, key);
            var hex = BitConverter.ToString(encrypted).Replace("-", string.Empty);
            //var verify = verifyLicense(userInfo, "613419a60fe537020222c4806eb64c704ec9afee2531a025b0d548d5334fe131d2a7cf57f21dde7ff99d6514044d71d1c2cdcacbd6c787c6e7071cf59f96f724");
            //System.OperatingSystem osInfo = System.Environment.OSVersion;

            var url = String.Format(REQUEST_URL_FORMAT, code, hex);
            var signed = NetworkUtils.getRequest(url);
            var license = Encoding.Default.GetString(signed);
            return license;
        }

        public String requestLicenseAndSaveFile(String code, String userEmail, String filename)
        {
            var license = requestLicense(code, userEmail);
            File.WriteAllText(filename, license);
            return license;
        }


        public AsymmetricCipherKeyPair GenerateKeys(int keySizeInBits)
        {
            RsaKeyPairGenerator r = new RsaKeyPairGenerator();
            r.Init(new KeyGenerationParameters(new SecureRandom(),
              keySizeInBits));
            AsymmetricCipherKeyPair keys = r.GenerateKeyPair();
            return keys;
        }

        public byte[] Encrypt2(byte[] data, AsymmetricKeyParameter key)
        {
            if (key == null)
            {
                throw new Exception("licmanPublicKey not Found: Please check your settings in SomeResources.resx");
            }
            var kparam = key as RsaKeyParameters;
            var p1 = DotNetUtilities.ToRSAParameters(kparam);
            var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(p1);
            return rsa.Encrypt(data, false);
        }

        public byte[] Encrypt(byte[] data, AsymmetricKeyParameter key)
        {
            if (key == null)
            {
                throw new Exception("licmanPublicKey not Found: Please check your settings in SomeResources.resx");
            }
            RsaEngine e = new RsaEngine();
            e.Init(true, key);

            int blockSize = e.GetInputBlockSize();
            List<byte> output = new List<byte>();

            for (int chunkPosition = 0; chunkPosition < data.Length; chunkPosition += blockSize)
            {
                int chunkSize = Math.Min(blockSize, data.Length -
                  (chunkPosition * blockSize));
                output.AddRange(e.ProcessBlock(data, chunkPosition,
                  chunkSize));
            }
            return output.ToArray();
        }

        public byte[] Decrypt(byte[] data, AsymmetricKeyParameter key)
        {
            if (key == null)
            {
                throw new Exception("licmanPrivateKey not Found: Please check your settings in SomeResources.resx");
            }
            RsaEngine e = new RsaEngine();
            e.Init(false, key);

            int blockSize = e.GetInputBlockSize();
            List<byte> output = new List<byte>();

            for (int chunkPosition = 0; chunkPosition < data.Length; chunkPosition += blockSize)
            {
                int chunkSize = Math.Min(blockSize, data.Length -
                  (chunkPosition * blockSize));
                output.AddRange(e.ProcessBlock(data, chunkPosition,
                  chunkSize));
            }
            return output.ToArray();
        }


    }
}
