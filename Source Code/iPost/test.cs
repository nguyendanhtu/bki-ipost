﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            //request v_r = new request();
            //string s = "";
            //string result = v_r.request_2_find_id("http://lookup-id.com/", "POST", "https://www.facebook.com/groups/bkindex");
            //string findfrom = "<p id=\"code-wrap\"><span id=\"code\">";
            //string findto = "</span></p>";
            //int start = result.IndexOf(findfrom);
            //int to = result.IndexOf(findto, start + findfrom.Length);
            //if (start > 0 && to > 0)
            //{
            //    s = result.Substring(
            //                   start + findfrom.Length,
            //                   to - start - findfrom.Length);
            //}
            //MessageBox.Show(s);
        }

        bool success = false;

        private void button1_Click(object sender, EventArgs e)
        {
            success = false;
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!success)
            {
                textBox1.Text = webBrowser1.Url.AbsoluteUri.ToString();
                MessageBox.Show(textBox1.Text);
                success = true;
            }
        }
    }
}
