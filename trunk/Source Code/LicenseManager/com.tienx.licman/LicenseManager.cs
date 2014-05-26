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
    public class LicenseManager : ILicenseManager
    {
        private const String REQUEST_LICENSE_FORMAT = "#licman\nmacAddr={0}\ncomputerName={1}\nuserEmail={2}";
        private const String REQUEST_URL_FORMAT = "http://tienx.vn/licman/verify/{0}/{1}";

        public const String VERIFY_SUCCESS = "true";
        public const String VERIFY_FAIL = "false";

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
                    var rm = new ResourceManager(name.Replace(".resources", ""), asm);
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
        /// <summary>
        /// userEmail=user@gmail.com
        /// computerName=user-pc
        /// licenseString=0FD4A4340700ED02BE9A7512E6A7DB67295A7ACA88E7ABA8A2DFD2545B9F8EBB16E52FC63AF967406D005DADC9CF239321E72C5126E7D4096E37C4D7273B881F
        /// </summary>
        /// <param name="license"></param>
        /// <returns></returns>
        public bool verifyLicense(String license)
        {
            var properties = TienXUtils.getProperties(license);
            var computerName = properties["computerName"] as String;
            var userEmail = properties["userEmail"] as String;
            var licenseKey = properties["licenseKey"] as String;

            var userMac = NetworkUtils.getAllMacAddr();
            foreach (var macAddr in userMac)
            {
                var userInfo = String.Format(REQUEST_LICENSE_FORMAT, macAddr, computerName, userEmail);
                var licBuffer = Encoding.UTF8.GetBytes(userInfo);
                var sigBuffer = ByteExtensions.StringToByteArray(licenseKey);
                var result = verifyLicense(licBuffer, sigBuffer);
                if (result)
                {
                    return true;
                }
            }
            return false;
        }

        public bool verifyLicenseFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                var fileData = sr.ReadToEnd().Replace("\r", "");
                return verifyLicense(fileData);
            }
        }


        public String requestLicense(String code, String userEmail)
        {
            //0FD4A4340700ED02BE9A7512E6A7DB67295A7ACA88E7ABA8A2DFD2545B9F8EBB16E52FC63AF967406D005DADC9CF239321E72C5126E7D4096E37C4D7273B881F
            //0FD4A4340700ED02BE9A7512E6A7DB67295A7ACA88E7ABA8A2DFD2545B9F8EBB16E52FC63AF967406D005DADC9CF239321E72C5126E7D4096E37C4D7273B881F
            var userMac = NetworkUtils.getMacAddr();
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
