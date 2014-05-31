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

namespace test
{
    public partial class f103_Main : Form
    {
        #region Member
        #endregion

        #region public Interface
        public f103_Main()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #endregion

        #region Event
        private void m_cmd_post_Click(object sender, EventArgs e)
        {
            f104_post v_f = new f104_post();
            v_f.ShowDialog();            
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_follow_Click(object sender, EventArgs e)
        {
            f107_PostFollow v_f = new f107_PostFollow();
            v_f.ShowDialog();
        }

        private void m_cmd_ql_group_Click(object sender, EventArgs e)
        {
            f108_QLGroup v_f = new f108_QLGroup();
            v_f.ShowDialog();
        }
        #endregion
    }
}
