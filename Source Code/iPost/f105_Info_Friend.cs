using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class f105_Info_Friend : Form
    {
        public f105_Info_Friend()
        {
            InitializeComponent();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link.LinkVisited = true;
            System.Diagnostics.Process.Start(link.Text);
        }

        public void display(Facebook.JsonObject friend, Facebook.JsonObject pic)
        {
            name.Text = friend["name"].ToString();
            link.Text = friend["link"].ToString();
            Facebook.JsonObject data = (Facebook.JsonObject)pic["data"];
            m_pic_avatar.Load(data["url"].ToString());
            this.ShowDialog();
        }
    }
}
