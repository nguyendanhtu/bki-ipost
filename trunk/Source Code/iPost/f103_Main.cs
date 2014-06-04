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
            FacebookClient fb = new FacebookClient(globalInfo.access_token);
            dynamic data = fb.Get("/me?fields=name");
            var v_name = ((JsonObject)data)["name"].ToString();
            globalInfo.name = v_name;
            this.Text = globalInfo.name + " đang sử dụng iPost";
        }

        #endregion

        #region Event
        private void m_cmd_post_Click(object sender, EventArgs e)
        {
            try {
                this.Hide();
                f104_post v_f = new f104_post();
                v_f.ShowDialog();
                this.Show();
            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
                
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try {
                MessageBox.Show("Cảm ơn bạn đã sử dụng sản phẩm iPost");
                this.Close();
            }
            catch (Exception v_e) {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
            
        }

        private void m_cmd_follow_Click(object sender, EventArgs e)
        {
            try {
                this.Hide();
                f107_PostFollow v_f = new f107_PostFollow();
                v_f.ShowDialog();
                this.Show();
            }
            catch (Exception v_e) {
                
                 MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
          
        }

        private void m_cmd_ql_group_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                f108_QLGroup v_f = new f108_QLGroup();
                v_f.ShowDialog();
                this.Show();
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }        

        private void m_cmd_thong_ke_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                f106_Phan_tich_group v_f = new f106_Phan_tich_group();
                v_f.displayMyGroup();
                this.Show();
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }
        #endregion
    }
}
