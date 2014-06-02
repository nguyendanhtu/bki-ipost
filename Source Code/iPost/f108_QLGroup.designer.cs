namespace test
{
    partial class f108_QLGroup
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
            this.m_tabpage_friend = new System.Windows.Forms.TabPage();
            this.m_wb = new System.Windows.Forms.WebBrowser();
            this.m_lb_friend_list = new System.Windows.Forms.ListBox();
            this.m_cmd_get_info = new System.Windows.Forms.Button();
            this.m_cmd_join_group = new System.Windows.Forms.Button();
            this.m_prb_friends = new System.Windows.Forms.ProgressBar();
            this.m_lb_group_list = new System.Windows.Forms.CheckedListBox();
            this.m_chk_all_group = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_cmd_phan_tich = new System.Windows.Forms.Button();
            this.m_tabpage_friend.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tabpage_friend
            // 
            this.m_tabpage_friend.Controls.Add(this.m_cmd_phan_tich);
            this.m_tabpage_friend.Controls.Add(this.m_wb);
            this.m_tabpage_friend.Controls.Add(this.m_lb_friend_list);
            this.m_tabpage_friend.Controls.Add(this.m_cmd_get_info);
            this.m_tabpage_friend.Controls.Add(this.m_cmd_join_group);
            this.m_tabpage_friend.Controls.Add(this.m_prb_friends);
            this.m_tabpage_friend.Controls.Add(this.m_lb_group_list);
            this.m_tabpage_friend.Controls.Add(this.m_chk_all_group);
            this.m_tabpage_friend.Location = new System.Drawing.Point(4, 22);
            this.m_tabpage_friend.Name = "m_tabpage_friend";
            this.m_tabpage_friend.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabpage_friend.Size = new System.Drawing.Size(539, 542);
            this.m_tabpage_friend.TabIndex = 1;
            this.m_tabpage_friend.Text = "Tìm kiếm Group theo bạn bè";
            this.m_tabpage_friend.UseVisualStyleBackColor = true;
            // 
            // m_wb
            // 
            this.m_wb.Location = new System.Drawing.Point(652, 47);
            this.m_wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_wb.Name = "m_wb";
            this.m_wb.Size = new System.Drawing.Size(250, 250);
            this.m_wb.TabIndex = 26;
            this.m_wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.m_wb_DocumentCompleted);
            // 
            // m_lb_friend_list
            // 
            this.m_lb_friend_list.FormattingEnabled = true;
            this.m_lb_friend_list.Location = new System.Drawing.Point(24, 47);
            this.m_lb_friend_list.Name = "m_lb_friend_list";
            this.m_lb_friend_list.Size = new System.Drawing.Size(165, 407);
            this.m_lb_friend_list.TabIndex = 25;
            this.m_lb_friend_list.SelectedIndexChanged += new System.EventHandler(this.m_lb_friend_list_SelectedIndexChanged);
            // 
            // m_cmd_get_info
            // 
            this.m_cmd_get_info.Location = new System.Drawing.Point(24, 20);
            this.m_cmd_get_info.Name = "m_cmd_get_info";
            this.m_cmd_get_info.Size = new System.Drawing.Size(165, 23);
            this.m_cmd_get_info.TabIndex = 23;
            this.m_cmd_get_info.Text = "Xem thông tin bạn bè";
            this.m_cmd_get_info.UseVisualStyleBackColor = true;
            this.m_cmd_get_info.Click += new System.EventHandler(this.m_cmd_get_info_Click);
            // 
            // m_cmd_join_group
            // 
            this.m_cmd_join_group.Location = new System.Drawing.Point(231, 509);
            this.m_cmd_join_group.Name = "m_cmd_join_group";
            this.m_cmd_join_group.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_join_group.TabIndex = 22;
            this.m_cmd_join_group.Text = "Xin gia nhập";
            this.m_cmd_join_group.UseVisualStyleBackColor = true;
            this.m_cmd_join_group.Click += new System.EventHandler(this.m_cmd_join_group_Click);
            // 
            // m_prb_friends
            // 
            this.m_prb_friends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m_prb_friends.Location = new System.Drawing.Point(43, 471);
            this.m_prb_friends.Name = "m_prb_friends";
            this.m_prb_friends.Size = new System.Drawing.Size(455, 23);
            this.m_prb_friends.TabIndex = 21;
            // 
            // m_lb_group_list
            // 
            this.m_lb_group_list.CheckOnClick = true;
            this.m_lb_group_list.FormattingEnabled = true;
            this.m_lb_group_list.Location = new System.Drawing.Point(225, 45);
            this.m_lb_group_list.Name = "m_lb_group_list";
            this.m_lb_group_list.Size = new System.Drawing.Size(292, 409);
            this.m_lb_group_list.TabIndex = 19;
            // 
            // m_chk_all_group
            // 
            this.m_chk_all_group.AutoSize = true;
            this.m_chk_all_group.Location = new System.Drawing.Point(228, 24);
            this.m_chk_all_group.Name = "m_chk_all_group";
            this.m_chk_all_group.Size = new System.Drawing.Size(57, 17);
            this.m_chk_all_group.TabIndex = 20;
            this.m_chk_all_group.Text = "Tất cả";
            this.m_chk_all_group.UseVisualStyleBackColor = true;
            this.m_chk_all_group.CheckedChanged += new System.EventHandler(this.m_chk_all_group_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_tabpage_friend);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 568);
            this.tabControl1.TabIndex = 17;
            // 
            // m_cmd_phan_tich
            // 
            this.m_cmd_phan_tich.Location = new System.Drawing.Point(352, 16);
            this.m_cmd_phan_tich.Name = "m_cmd_phan_tich";
            this.m_cmd_phan_tich.Size = new System.Drawing.Size(165, 23);
            this.m_cmd_phan_tich.TabIndex = 27;
            this.m_cmd_phan_tich.Text = "Phân tích group";
            this.m_cmd_phan_tich.UseVisualStyleBackColor = true;
            this.m_cmd_phan_tich.Click += new System.EventHandler(this.m_cmd_phan_tich_Click);
            // 
            // f108_QLGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 568);
            this.Controls.Add(this.tabControl1);
            this.Name = "f108_QLGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F108 - Quản lý các group facebook";
            this.Load += new System.EventHandler(this.f108_QLGroup_Load);
            this.m_tabpage_friend.ResumeLayout(false);
            this.m_tabpage_friend.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage m_tabpage_friend;
        private System.Windows.Forms.WebBrowser m_wb;
        private System.Windows.Forms.ListBox m_lb_friend_list;
        private System.Windows.Forms.Button m_cmd_get_info;
        private System.Windows.Forms.Button m_cmd_join_group;
        private System.Windows.Forms.ProgressBar m_prb_friends;
        private System.Windows.Forms.CheckedListBox m_lb_group_list;
        private System.Windows.Forms.CheckBox m_chk_all_group;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button m_cmd_phan_tich;

    }
}