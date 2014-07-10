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
    public partial class Advance : Form
    {
        #region member
        f104_post v_f = new f104_post();
        f101_post_2_page v_f_2_page = new f101_post_2_page();
        #endregion

        #region private method
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            v_f.Updating(m_txt_link.Text, m_txt_caption.Text, m_txt_description.Text);
            v_f_2_page.Updating(m_txt_link.Text, m_txt_caption.Text, m_txt_description.Text);
            this.Close();
        }
        #endregion

        #region public method
        public Advance()
        {
            InitializeComponent();
        }
        public void Display(f104_post form1)
        {
            v_f = form1;
            this.ShowDialog();
        }
        #endregion

        public void Display(f101_post_2_page f101_post_2_page)
        {
            v_f_2_page = f101_post_2_page;
            this.ShowDialog();
        }
    }
}
