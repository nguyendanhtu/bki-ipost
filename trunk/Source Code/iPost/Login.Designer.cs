namespace test
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.m_cmd_reg = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_lbl_user = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_reg
            // 
            this.m_cmd_reg.ForeColor = System.Drawing.Color.Black;
            this.m_cmd_reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_reg.ImageIndex = 13;
            this.m_cmd_reg.ImageList = this.ImageList;
            this.m_cmd_reg.Location = new System.Drawing.Point(81, 3);
            this.m_cmd_reg.Name = "m_cmd_reg";
            this.m_cmd_reg.Size = new System.Drawing.Size(110, 31);
            this.m_cmd_reg.TabIndex = 1;
            this.m_cmd_reg.Text = "Kiếm tiền ngay";
            this.m_cmd_reg.UseVisualStyleBackColor = true;
            this.m_cmd_reg.Click += new System.EventHandler(this.m_cmd_reg_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_lbl_user
            // 
            this.m_lbl_user.AutoSize = true;
            this.m_lbl_user.ForeColor = System.Drawing.Color.White;
            this.m_lbl_user.Location = new System.Drawing.Point(49, 49);
            this.m_lbl_user.Name = "m_lbl_user";
            this.m_lbl_user.Size = new System.Drawing.Size(74, 13);
            this.m_lbl_user.TabIndex = 3;
            this.m_lbl_user.Text = "Email của bạn";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(131, 46);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(199, 20);
            this.email.TabIndex = 4;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(131, 82);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(199, 20);
            this.key.TabIndex = 6;
            this.toolTip1.SetToolTip(this.key, "Bạn liên hệ với chúng tôi để lấy KEY nhá");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key sử dụng iPost";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.ForeColor = System.Drawing.Color.Black;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(209, 3);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(118, 31);
            this.m_cmd_exit.TabIndex = 7;
            this.m_cmd_exit.Text = "Nghỉ chút nào";
            this.m_cmd_exit.UseVisualStyleBackColor = true;
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Controls.Add(this.m_cmd_reg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 37);
            this.panel1.TabIndex = 8;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 187);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(384, 40);
            this.Panel2.TabIndex = 9;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.Label3.Location = new System.Drawing.Point(3, 11);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(378, 20);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Designed by BKIndex Group, 3T Corp.Ltd";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.m_lbl_user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.key);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập iPost 3.0";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(384, 227);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập iPost 3.0";
            this.panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button m_cmd_reg;
        private System.Windows.Forms.Label m_lbl_user;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_cmd_exit;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}