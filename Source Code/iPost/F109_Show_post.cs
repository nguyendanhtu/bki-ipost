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
    public partial class F109_Show_post : Form
    {
        public F109_Show_post()
        {
            InitializeComponent();
        }

        internal void display(string p_id)
        {
            m_wb.Navigate("https://facebook.com/"+p_id);
            this.Show();
        }
    }
}
