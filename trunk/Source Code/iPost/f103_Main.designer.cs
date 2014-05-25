namespace test
{
    partial class f103_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f103_Main));
            this.m_cmd_post = new System.Windows.Forms.Button();
            this.m_cmd_exit = new System.Windows.Forms.Button();
            this.m_cmd_follow = new System.Windows.Forms.Button();
            this.m_lbl_message = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.m_cmd_ql_group = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_cmd_post
            // 
            this.m_cmd_post.Location = new System.Drawing.Point(15, 9);
            this.m_cmd_post.Name = "m_cmd_post";
            this.m_cmd_post.Size = new System.Drawing.Size(233, 37);
            this.m_cmd_post.TabIndex = 0;
            this.m_cmd_post.Text = "Đăng bài";
            this.m_cmd_post.UseVisualStyleBackColor = true;
            this.m_cmd_post.Click += new System.EventHandler(this.m_cmd_post_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Location = new System.Drawing.Point(16, 169);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(232, 35);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.UseVisualStyleBackColor = true;
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_cmd_follow
            // 
            this.m_cmd_follow.Location = new System.Drawing.Point(15, 51);
            this.m_cmd_follow.Name = "m_cmd_follow";
            this.m_cmd_follow.Size = new System.Drawing.Size(233, 35);
            this.m_cmd_follow.TabIndex = 2;
            this.m_cmd_follow.Text = "Theo dõi bài đăng";
            this.m_cmd_follow.UseVisualStyleBackColor = true;
            this.m_cmd_follow.Click += new System.EventHandler(this.m_cmd_follow_Click);
            // 
            // m_lbl_message
            // 
            this.m_lbl_message.AutoSize = true;
            this.m_lbl_message.Location = new System.Drawing.Point(12, 115);
            this.m_lbl_message.Name = "m_lbl_message";
            this.m_lbl_message.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_message.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(16, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thống kê - Phân tích";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // m_cmd_ql_group
            // 
            this.m_cmd_ql_group.Location = new System.Drawing.Point(15, 91);
            this.m_cmd_ql_group.Name = "m_cmd_ql_group";
            this.m_cmd_ql_group.Size = new System.Drawing.Size(233, 34);
            this.m_cmd_ql_group.TabIndex = 6;
            this.m_cmd_ql_group.Text = "Quản lý Group";
            this.m_cmd_ql_group.UseVisualStyleBackColor = true;
            this.m_cmd_ql_group.Click += new System.EventHandler(this.m_cmd_ql_group_Click);
            // 
            // f103_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 213);
            this.Controls.Add(this.m_cmd_ql_group);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_lbl_message);
            this.Controls.Add(this.m_cmd_follow);
            this.Controls.Add(this.m_cmd_exit);
            this.Controls.Add(this.m_cmd_post);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(279, 251);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(279, 251);
            this.Name = "f103_Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_cmd_post;
        private System.Windows.Forms.Button m_cmd_exit;
        private System.Windows.Forms.Button m_cmd_follow;
        private System.Windows.Forms.Label m_lbl_message;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button m_cmd_ql_group;
    }
}