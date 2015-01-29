using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace test
{
	public class upload
	{
        public void Upload(string fileToUpload)
        {
            try
            {
                FileInfo toUpload = new FileInfo(fileToUpload);
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://123.30.182.81/httpdocs/Upload/" + toUpload.Name);
                req.Method = WebRequestMethods.Ftp.UploadFile;
                req.Credentials = new NetworkCredential("englishat", "OYzkjZSwpj4");
                Stream ftpStream = req.GetRequestStream();
                FileStream file = File.OpenRead(fileToUpload);
                int length = 1024;
                byte[] buffer = new byte[length];
                int bytesRead = 0;
                do
                {
                    bytesRead = file.Read(buffer, 0, length);
                    ftpStream.Write(buffer, 0, bytesRead);
                } while (bytesRead != 0);
                file.Close();
                ftpStream.Close();
            }
            catch (Exception v_e)
            {
                throw (v_e);
            }
        }
	}
}
