namespace test
{
    partial class f104_post
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
            this.m_cmd_post = new System.Windows.Forms.Button();
            this.m_cbl_group = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_chk_all = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_txt_message = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_cmd_advance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.m_chk_has_image = new System.Windows.Forms.CheckBox();
            this.m_lbl_image_url = new System.Windows.Forms.Label();
            this.m_txt_url_image = new System.Windows.Forms.TextBox();
            this.m_lbl_message = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_post
            // 
            this.m_cmd_post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.m_cmd_post.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_post.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.m_cmd_post.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_post.Name = "m_cmd_post";
            this.m_cmd_post.Size = new System.Drawing.Size(608, 45);
            this.m_cmd_post.TabIndex = 1;
            this.m_cmd_post.Text = "Đăng bài nào";
            this.m_cmd_post.UseVisualStyleBackColor = false;
            this.m_cmd_post.Click += new System.EventHandler(this.m_cmd_post_Click);
            // 
            // m_cbl_group
            // 
            this.m_cbl_group.CheckOnClick = true;
            this.m_cbl_group.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cbl_group.FormattingEnabled = true;
            this.m_cbl_group.Location = new System.Drawing.Point(0, 63);
            this.m_cbl_group.Name = "m_cbl_group";
            this.m_cbl_group.Size = new System.Drawing.Size(200, 379);
            this.m_cbl_group.TabIndex = 2;
            this.toolTip1.SetToolTip(this.m_cbl_group, "Check vào nhóm bạn muốn đăng bài nhé");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_chk_all);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cbl_group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 442);
            this.panel1.TabIndex = 4;
            // 
            // m_chk_all
            // 
            this.m_chk_all.AutoSize = true;
            this.m_chk_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.m_chk_all.Location = new System.Drawing.Point(3, 40);
            this.m_chk_all.Name = "m_chk_all";
            this.m_chk_all.Size = new System.Drawing.Size(107, 17);
            this.m_chk_all.TabIndex = 14;
            this.m_chk_all.Text = "Tất cả các nhóm";
            this.m_chk_all.UseVisualStyleBackColor = true;
            this.m_chk_all.CheckedChanged += new System.EventHandler(this.m_chk_all_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhóm muốn đăng bài";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_post);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 45);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_txt_message);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.m_cmd_advance);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.m_txt_time);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.m_chk_has_image);
            this.panel3.Controls.Add(this.m_lbl_image_url);
            this.panel3.Controls.Add(this.m_txt_url_image);
            this.panel3.Controls.Add(this.m_lbl_message);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 397);
            this.panel3.TabIndex = 6;
            // 
            // m_txt_message
            // 
            this.m_txt_message.Location = new System.Drawing.Point(122, 63);
            this.m_txt_message.Multiline = true;
            this.m_txt_message.Name = "m_txt_message";
            this.m_txt_message.Size = new System.Drawing.Size(474, 262);
            this.m_txt_message.TabIndex = 1;
            this.toolTip1.SetToolTip(this.m_txt_message, "Bạn nên học kỹ thuật AIDA để bài viết được nhiều người quan tâm");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Để tránh bị khóa tài khoản nhé!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "-  Ít nhất là: 10s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mình đề xuất: 40s";
            // 
            // m_cmd_advance
            // 
            this.m_cmd_advance.Location = new System.Drawing.Point(521, 329);
            this.m_cmd_advance.Name = "m_cmd_advance";
            this.m_cmd_advance.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_advance.TabIndex = 11;
            this.m_cmd_advance.Text = "Nâng cao";
            this.m_cmd_advance.UseVisualStyleBackColor = true;
            this.m_cmd_advance.Click += new System.EventHandler(this.m_cmd_advance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(232, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "s";
            // 
            // m_txt_time
            // 
            this.m_txt_time.Location = new System.Drawing.Point(188, 18);
            this.m_txt_time.Name = "m_txt_time";
            this.m_txt_time.Size = new System.Drawing.Size(75, 20);
            this.m_txt_time.TabIndex = 9;
            this.m_txt_time.Text = "30";
            this.toolTip1.SetToolTip(this.m_txt_time, "Nên để thời gian vừa Để tránh bị khóa tài khoản bạn ạ");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thời gian giữa 2 lần đăng bài";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(5, 367);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(598, 24);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // m_chk_has_image
            // 
            this.m_chk_has_image.AutoSize = true;
            this.m_chk_has_image.Location = new System.Drawing.Point(4, 308);
            this.m_chk_has_image.Name = "m_chk_has_image";
            this.m_chk_has_image.Size = new System.Drawing.Size(121, 17);
            this.m_chk_has_image.TabIndex = 6;
            this.m_chk_has_image.Text = "Chưa đính kèm ảnh";
            this.toolTip1.SetToolTip(this.m_chk_has_image, "Bạn nên có ảnh để bài viết được quan tâm nhiều hơn");
            this.m_chk_has_image.UseVisualStyleBackColor = true;
            this.m_chk_has_image.CheckedChanged += new System.EventHandler(this.m_chk_has_image_CheckedChanged);
            // 
            // m_lbl_image_url
            // 
            this.m_lbl_image_url.AutoSize = true;
            this.m_lbl_image_url.Location = new System.Drawing.Point(40, 334);
            this.m_lbl_image_url.Name = "m_lbl_image_url";
            this.m_lbl_image_url.Size = new System.Drawing.Size(76, 13);
            this.m_lbl_image_url.TabIndex = 3;
            this.m_lbl_image_url.Text = "Link đính kèm";
            // 
            // m_txt_url_image
            // 
            this.m_txt_url_image.Location = new System.Drawing.Point(122, 331);
            this.m_txt_url_image.Name = "m_txt_url_image";
            this.m_txt_url_image.Size = new System.Drawing.Size(394, 20);
            this.m_txt_url_image.TabIndex = 2;
            // 
            // m_lbl_message
            // 
            this.m_lbl_message.AutoSize = true;
            this.m_lbl_message.Location = new System.Drawing.Point(26, 63);
            this.m_lbl_message.Name = "m_lbl_message";
            this.m_lbl_message.Size = new System.Drawing.Size(95, 13);
            this.m_lbl_message.TabIndex = 0;
            this.m_lbl_message.Text = "Nội dung bài đăng";
            // 
            // f104_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 442);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(824, 480);
            this.MinimumSize = new System.Drawing.Size(824, 480);
            this.Name = "f104_post";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F104 - Đăng bài";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_cmd_post;
        private System.Windows.Forms.CheckedListBox m_cbl_group;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox m_txt_message;
        private System.Windows.Forms.Label m_lbl_message;
        private System.Windows.Forms.TextBox m_txt_url_image;
        private System.Windows.Forms.Label m_lbl_image_url;
        private System.Windows.Forms.CheckBox m_chk_has_image;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_cmd_advance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox m_chk_all;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

