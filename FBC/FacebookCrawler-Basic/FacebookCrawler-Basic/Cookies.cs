using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookCrawler_Basic
{
    public partial class Cookies : Form
    {
        public Cookies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cookie c_act = new Cookie("act", act.Text); c_act.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_act);
            Cookie c_c_user = new Cookie("c_user", c_user.Text); c_c_user.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_c_user);
            Cookie c_csm = new Cookie("csm", csm.Text); c_csm.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_csm);
            Cookie c_datr = new Cookie("datr", datr.Text); c_datr.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_datr);
            Cookie c_fr = new Cookie("fr", fr.Text); c_fr.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_fr);
            Cookie c_lu = new Cookie("lu", lu.Text); c_lu.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_lu);
            Cookie c_p = new Cookie("p", p.Text); c_p.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_p);
            Cookie c_presence = new Cookie("presence", presence.Text); c_presence.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_presence);
            Cookie c_s = new Cookie("s", s.Text); c_s.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_s);
            Cookie c_xs = new Cookie("xs", xs.Text); c_xs.Domain = ".facebook.com"; globalInfo.cookie_collection.Add(c_xs);
            this.Close();
        }
    }
}
