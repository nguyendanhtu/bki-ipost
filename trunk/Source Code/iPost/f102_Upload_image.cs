using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.Net;
using System.IO;
using System.Dynamic;

namespace test
{
    public partial class f102_Upload_image : Form
    {
        f104_post v_f_104 = new f104_post();

        public f102_Upload_image()
        {
            InitializeComponent();
        }

        private void m_btn_insert_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Multiselect = true;
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF Files: (*.GIF)|*.GIF|TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|PNG Files: (*.PNG)|*.PNG|All Files|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();
            }
            foreach (var item in fdlg.FileNames)
            {
                m_lb_image_list.Items.Add(item);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            m_lb_image_list.Items.RemoveAt(m_lb_image_list.SelectedIndex);
        }

        private void m_cmd_upload_Click(object sender, EventArgs e)
        {
            string v_album_id = createAlbum();
            List<string> v_list_image = uploadImage();
            foreach (string item in v_list_image)
            {
                uploadImageToFB(item, v_album_id);
            }
        }

        private void uploadImageToFB(string v_str_image, string v_album_id)
        {
            FacebookClient fb = new FacebookClient(globalInfo.access_token);
            dynamic parameters = new ExpandoObject();
            parameters.url = v_str_image;
            dynamic result = fb.Post(v_album_id+"/photos",parameters);
        }

        private List<string> uploadImage()
        {
            List<string> v_list_img = new List<string>();
            foreach (string item in m_lb_image_list.Items)
            {
                Upload(item);
                v_list_img.Add("http://anhthay.com.vn/Upload/"+Path.GetFileName(item));
            }
            return v_list_img;
        }

        private void Upload(string item)
        {
            try
            {
                FileInfo toUpload = new FileInfo(item);
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://123.30.182.81/httpdocs/Upload/" + toUpload.Name);
                req.Method = WebRequestMethods.Ftp.UploadFile;
                req.Credentials = new NetworkCredential("englishat", "OYzkjZSwpj4");
                Stream ftpStream = req.GetRequestStream();
                FileStream file = File.OpenRead(item);
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

        private string createAlbum()
        {
            FacebookClient fb = new FacebookClient(globalInfo.access_token);
            dynamic parameters = new ExpandoObject();
            parameters.name = m_txt_album_name.Text;
            parameters.message = m_txt_description.Text;
            parameters.value = "EVERYONE";
            dynamic result = fb.Post("me/albums", parameters);
            return result["id"];
        }

        public void Display(f104_post f104_post)
        {
            v_f_104 = f104_post;
            this.ShowDialog();
        }
    }
}