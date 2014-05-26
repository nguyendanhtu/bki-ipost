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
            this.m_cmd_reg = new System.Windows.Forms.Button();
            this.m_lbl_user = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_cmd_reg
            // 
            this.m_cmd_reg.Location = new System.Drawing.Point(101, 136);
            this.m_cmd_reg.Name = "m_cmd_reg";
            this.m_cmd_reg.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_reg.TabIndex = 1;
            this.m_cmd_reg.Text = "Đăng nhập";
            this.m_cmd_reg.UseVisualStyleBackColor = true;
            this.m_cmd_reg.Click += new System.EventHandler(this.m_cmd_reg_Click);
            // 
            // m_lbl_user
            // 
            this.m_lbl_user.AutoSize = true;
            this.m_lbl_user.Location = new System.Drawing.Point(46, 60);
            this.m_lbl_user.Name = "m_lbl_user";
            this.m_lbl_user.Size = new System.Drawing.Size(32, 13);
            this.m_lbl_user.TabIndex = 3;
            this.m_lbl_user.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(106, 53);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(172, 20);
            this.email.TabIndex = 4;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(106, 89);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(172, 20);
            this.key.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Location = new System.Drawing.Point(209, 136);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_exit.TabIndex = 7;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.UseVisualStyleBackColor = true;
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.Controls.Add(this.m_cmd_exit);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.m_lbl_user);
            this.Controls.Add(this.m_cmd_reg);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 230);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button m_cmd_reg;
        private System.Windows.Forms.Label m_lbl_user;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_cmd_exit;
    }
}