namespace FacebookCrawler_Basic
{
    partial class FB
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
            this.m_wb = new System.Windows.Forms.WebBrowser();
            this.m_cmd_start = new System.Windows.Forms.Button();
            this.m_cmd_login_fb = new System.Windows.Forms.Button();
            this.m_cmd_get_cookie = new System.Windows.Forms.Button();
            this.m_cmd_set_cookie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_wb
            // 
            this.m_wb.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_wb.Location = new System.Drawing.Point(0, 0);
            this.m_wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_wb.Name = "m_wb";
            this.m_wb.Size = new System.Drawing.Size(875, 379);
            this.m_wb.TabIndex = 0;
            this.m_wb.Url = new System.Uri("https://facebook.com", System.UriKind.Absolute);
            // 
            // m_cmd_start
            // 
            this.m_cmd_start.Location = new System.Drawing.Point(580, 410);
            this.m_cmd_start.Name = "m_cmd_start";
            this.m_cmd_start.Size = new System.Drawing.Size(251, 23);
            this.m_cmd_start.TabIndex = 1;
            this.m_cmd_start.Text = "button1";
            this.m_cmd_start.UseVisualStyleBackColor = true;
            this.m_cmd_start.Click += new System.EventHandler(this.m_cmd_start_Click);
            // 
            // m_cmd_login_fb
            // 
            this.m_cmd_login_fb.Location = new System.Drawing.Point(33, 410);
            this.m_cmd_login_fb.Name = "m_cmd_login_fb";
            this.m_cmd_login_fb.Size = new System.Drawing.Size(251, 23);
            this.m_cmd_login_fb.TabIndex = 2;
            this.m_cmd_login_fb.Text = "Login FB";
            this.m_cmd_login_fb.UseVisualStyleBackColor = true;
            this.m_cmd_login_fb.Click += new System.EventHandler(this.m_cmd_login_fb_Click);
            // 
            // m_cmd_get_cookie
            // 
            this.m_cmd_get_cookie.Location = new System.Drawing.Point(302, 385);
            this.m_cmd_get_cookie.Name = "m_cmd_get_cookie";
            this.m_cmd_get_cookie.Size = new System.Drawing.Size(251, 23);
            this.m_cmd_get_cookie.TabIndex = 3;
            this.m_cmd_get_cookie.Text = "Get Cookie";
            this.m_cmd_get_cookie.UseVisualStyleBackColor = true;
            this.m_cmd_get_cookie.Click += new System.EventHandler(this.m_cmd_get_cookie_Click);
            // 
            // m_cmd_set_cookie
            // 
            this.m_cmd_set_cookie.Location = new System.Drawing.Point(302, 428);
            this.m_cmd_set_cookie.Name = "m_cmd_set_cookie";
            this.m_cmd_set_cookie.Size = new System.Drawing.Size(251, 23);
            this.m_cmd_set_cookie.TabIndex = 4;
            this.m_cmd_set_cookie.Text = "Set Cookie";
            this.m_cmd_set_cookie.UseVisualStyleBackColor = true;
            this.m_cmd_set_cookie.Click += new System.EventHandler(this.m_cmd_set_cookie_Click);
            // 
            // FB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 463);
            this.Controls.Add(this.m_cmd_set_cookie);
            this.Controls.Add(this.m_cmd_get_cookie);
            this.Controls.Add(this.m_cmd_login_fb);
            this.Controls.Add(this.m_cmd_start);
            this.Controls.Add(this.m_wb);
            this.Name = "FB";
            this.Text = "FB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser m_wb;
        private System.Windows.Forms.Button m_cmd_start;
        private System.Windows.Forms.Button m_cmd_login_fb;
        private System.Windows.Forms.Button m_cmd_get_cookie;
        private System.Windows.Forms.Button m_cmd_set_cookie;
    }
}