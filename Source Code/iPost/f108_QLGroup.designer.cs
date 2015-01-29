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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f108_QLGroup));
            this.m_tabpage_friend = new System.Windows.Forms.TabPage();
            this.m_cmd_from_list = new System.Windows.Forms.Button();
            this.m_txt_search = new System.Windows.Forms.TextBox();
            this.m_cmd_phan_tich = new System.Windows.Forms.Button();
            this.m_wb = new System.Windows.Forms.WebBrowser();
            this.m_lb_friend_list = new System.Windows.Forms.ListBox();
            this.m_cmd_get_info = new System.Windows.Forms.Button();
            this.m_cmd_join_group = new System.Windows.Forms.Button();
            this.m_prb_friends = new System.Windows.Forms.ProgressBar();
            this.m_lb_group_list = new System.Windows.Forms.CheckedListBox();
            this.m_chk_all_group = new System.Windows.Forms.CheckBox();
            this.m_tabpage_search = new System.Windows.Forms.TabPage();
            this.m_cmd_tim_kiem = new System.Windows.Forms.Button();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_join = new System.Windows.Forms.Button();
            this.m_pgb_group = new System.Windows.Forms.ProgressBar();
            this.m_cbl_group = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_tabpage_create = new System.Windows.Forms.TabPage();
            this.m_text_search_group = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.m_name_new_group = new System.Windows.Forms.TextBox();
            this.m_lb_me_list_group = new System.Windows.Forms.CheckedListBox();
            this.m_chk_all = new System.Windows.Forms.CheckBox();
            this.m_tabpage_friend.SuspendLayout();
            this.m_tabpage_search.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.m_tabpage_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tabpage_friend
            // 
            this.m_tabpage_friend.Controls.Add(this.m_cmd_from_list);
            this.m_tabpage_friend.Controls.Add(this.m_txt_search);
            this.m_tabpage_friend.Controls.Add(this.m_cmd_phan_tich);
            this.m_tabpage_friend.Controls.Add(this.m_wb);
            this.m_tabpage_friend.Controls.Add(this.m_lb_friend_list);
            this.m_tabpage_friend.Controls.Add(this.m_cmd_get_info);
            this.m_tabpage_friend.Controls.Add(this.m_cmd_join_group);
            this.m_tabpage_friend.Controls.Add(this.m_prb_friends);
            this.m_tabpage_friend.Controls.Add(this.m_lb_group_list);
            this.m_tabpage_friend.Controls.Add(this.m_chk_all_group);
            this.m_tabpage_friend.Location = new System.Drawing.Point(4, 23);
            this.m_tabpage_friend.Name = "m_tabpage_friend";
            this.m_tabpage_friend.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabpage_friend.Size = new System.Drawing.Size(652, 585);
            this.m_tabpage_friend.TabIndex = 1;
            this.m_tabpage_friend.Text = "Tìm kiếm Group theo bạn bè";
            this.m_tabpage_friend.UseVisualStyleBackColor = true;
            // 
            // m_cmd_from_list
            // 
            this.m_cmd_from_list.Location = new System.Drawing.Point(385, 17);
            this.m_cmd_from_list.Name = "m_cmd_from_list";
            this.m_cmd_from_list.Size = new System.Drawing.Size(138, 25);
            this.m_cmd_from_list.TabIndex = 29;
            this.m_cmd_from_list.Text = "Chọn nhóm từ danh sách";
            this.m_cmd_from_list.UseVisualStyleBackColor = true;
            this.m_cmd_from_list.Click += new System.EventHandler(this.m_cmd_from_list_Click);
            // 
            // m_txt_search
            // 
            this.m_txt_search.Location = new System.Drawing.Point(24, 48);
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.Size = new System.Drawing.Size(165, 20);
            this.m_txt_search.TabIndex = 28;
            this.m_txt_search.TextChanged += new System.EventHandler(this.m_txt_search_TextChanged);
            // 
            // m_cmd_phan_tich
            // 
            this.m_cmd_phan_tich.Location = new System.Drawing.Point(529, 17);
            this.m_cmd_phan_tich.Name = "m_cmd_phan_tich";
            this.m_cmd_phan_tich.Size = new System.Drawing.Size(97, 25);
            this.m_cmd_phan_tich.TabIndex = 27;
            this.m_cmd_phan_tich.Text = "Phân tích group";
            this.m_cmd_phan_tich.UseVisualStyleBackColor = true;
            this.m_cmd_phan_tich.Click += new System.EventHandler(this.m_cmd_phan_tich_Click);
            // 
            // m_wb
            // 
            this.m_wb.Location = new System.Drawing.Point(652, 51);
            this.m_wb.MinimumSize = new System.Drawing.Size(20, 22);
            this.m_wb.Name = "m_wb";
            this.m_wb.ScriptErrorsSuppressed = true;
            this.m_wb.Size = new System.Drawing.Size(250, 269);
            this.m_wb.TabIndex = 26;
            this.m_wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.m_wb_DocumentCompleted);
            // 
            // m_lb_friend_list
            // 
            this.m_lb_friend_list.FormattingEnabled = true;
            this.m_lb_friend_list.ItemHeight = 14;
            this.m_lb_friend_list.Location = new System.Drawing.Point(24, 79);
            this.m_lb_friend_list.Name = "m_lb_friend_list";
            this.m_lb_friend_list.Size = new System.Drawing.Size(165, 410);
            this.m_lb_friend_list.TabIndex = 25;
            this.m_lb_friend_list.SelectedIndexChanged += new System.EventHandler(this.m_lb_friend_list_SelectedIndexChanged);
            // 
            // m_cmd_get_info
            // 
            this.m_cmd_get_info.Location = new System.Drawing.Point(24, 17);
            this.m_cmd_get_info.Name = "m_cmd_get_info";
            this.m_cmd_get_info.Size = new System.Drawing.Size(165, 25);
            this.m_cmd_get_info.TabIndex = 23;
            this.m_cmd_get_info.Text = "Xem thông tin bạn bè";
            this.m_cmd_get_info.UseVisualStyleBackColor = true;
            this.m_cmd_get_info.Click += new System.EventHandler(this.m_cmd_get_info_Click);
            // 
            // m_cmd_join_group
            // 
            this.m_cmd_join_group.Location = new System.Drawing.Point(289, 548);
            this.m_cmd_join_group.Name = "m_cmd_join_group";
            this.m_cmd_join_group.Size = new System.Drawing.Size(75, 25);
            this.m_cmd_join_group.TabIndex = 22;
            this.m_cmd_join_group.Text = "Xin gia nhập";
            this.m_cmd_join_group.UseVisualStyleBackColor = true;
            this.m_cmd_join_group.Click += new System.EventHandler(this.m_cmd_join_group_Click);
            // 
            // m_prb_friends
            // 
            this.m_prb_friends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m_prb_friends.Location = new System.Drawing.Point(99, 507);
            this.m_prb_friends.Name = "m_prb_friends";
            this.m_prb_friends.Size = new System.Drawing.Size(455, 25);
            this.m_prb_friends.TabIndex = 21;
            // 
            // m_lb_group_list
            // 
            this.m_lb_group_list.CheckOnClick = true;
            this.m_lb_group_list.FormattingEnabled = true;
            this.m_lb_group_list.Location = new System.Drawing.Point(225, 48);
            this.m_lb_group_list.Name = "m_lb_group_list";
            this.m_lb_group_list.Size = new System.Drawing.Size(401, 439);
            this.m_lb_group_list.TabIndex = 19;
            // 
            // m_chk_all_group
            // 
            this.m_chk_all_group.AutoSize = true;
            this.m_chk_all_group.Location = new System.Drawing.Point(228, 26);
            this.m_chk_all_group.Name = "m_chk_all_group";
            this.m_chk_all_group.Size = new System.Drawing.Size(56, 18);
            this.m_chk_all_group.TabIndex = 20;
            this.m_chk_all_group.Text = "Tất cả";
            this.m_chk_all_group.UseVisualStyleBackColor = true;
            this.m_chk_all_group.CheckedChanged += new System.EventHandler(this.m_chk_all_group_CheckedChanged);
            // 
            // m_tabpage_search
            // 
            this.m_tabpage_search.Controls.Add(this.m_cmd_tim_kiem);
            this.m_tabpage_search.Controls.Add(this.m_txt_tim_kiem);
            this.m_tabpage_search.Controls.Add(this.m_cmd_join);
            this.m_tabpage_search.Controls.Add(this.m_pgb_group);
            this.m_tabpage_search.Controls.Add(this.m_cbl_group);
            this.m_tabpage_search.Location = new System.Drawing.Point(4, 23);
            this.m_tabpage_search.Name = "m_tabpage_search";
            this.m_tabpage_search.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabpage_search.Size = new System.Drawing.Size(652, 585);
            this.m_tabpage_search.TabIndex = 1;
            this.m_tabpage_search.Text = "Tìm kiếm Group theo tên";
            this.m_tabpage_search.UseVisualStyleBackColor = true;
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(422, 25);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(75, 25);
            this.m_cmd_tim_kiem.TabIndex = 4;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm";
            this.m_cmd_tim_kiem.UseVisualStyleBackColor = true;
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_tim_kiem_Click);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(156, 28);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(260, 20);
            this.m_txt_tim_kiem.TabIndex = 3;
            // 
            // m_cmd_join
            // 
            this.m_cmd_join.Location = new System.Drawing.Point(289, 528);
            this.m_cmd_join.Name = "m_cmd_join";
            this.m_cmd_join.Size = new System.Drawing.Size(75, 25);
            this.m_cmd_join.TabIndex = 2;
            this.m_cmd_join.Text = "Xin gia nhập";
            this.m_cmd_join.UseVisualStyleBackColor = true;
            this.m_cmd_join.Click += new System.EventHandler(this.m_cmd_join_Click);
            // 
            // m_pgb_group
            // 
            this.m_pgb_group.Location = new System.Drawing.Point(93, 477);
            this.m_pgb_group.Name = "m_pgb_group";
            this.m_pgb_group.Size = new System.Drawing.Size(467, 25);
            this.m_pgb_group.TabIndex = 1;
            // 
            // m_cbl_group
            // 
            this.m_cbl_group.FormattingEnabled = true;
            this.m_cbl_group.Location = new System.Drawing.Point(93, 74);
            this.m_cbl_group.Name = "m_cbl_group";
            this.m_cbl_group.Size = new System.Drawing.Size(467, 364);
            this.m_cbl_group.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_tabpage_friend);
            this.tabControl1.Controls.Add(this.m_tabpage_search);
            this.tabControl1.Controls.Add(this.m_tabpage_create);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 612);
            this.tabControl1.TabIndex = 17;
            // 
            // m_tabpage_create
            // 
            this.m_tabpage_create.Controls.Add(this.m_chk_all);
            this.m_tabpage_create.Controls.Add(this.m_text_search_group);
            this.m_tabpage_create.Controls.Add(this.label2);
            this.m_tabpage_create.Controls.Add(this.label1);
            this.m_tabpage_create.Controls.Add(this.button1);
            this.m_tabpage_create.Controls.Add(this.m_name_new_group);
            this.m_tabpage_create.Controls.Add(this.m_lb_me_list_group);
            this.m_tabpage_create.Location = new System.Drawing.Point(4, 23);
            this.m_tabpage_create.Name = "m_tabpage_create";
            this.m_tabpage_create.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabpage_create.Size = new System.Drawing.Size(652, 585);
            this.m_tabpage_create.TabIndex = 2;
            this.m_tabpage_create.Text = "Tạo nhóm group";
            this.m_tabpage_create.UseVisualStyleBackColor = true;
            // 
            // m_text_search_group
            // 
            this.m_text_search_group.Location = new System.Drawing.Point(49, 46);
            this.m_text_search_group.Name = "m_text_search_group";
            this.m_text_search_group.Size = new System.Drawing.Size(361, 20);
            this.m_text_search_group.TabIndex = 32;
            this.m_text_search_group.TextChanged += new System.EventHandler(this.m_text_search_group_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên nhóm mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên nhóm mới";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 20);
            this.button1.TabIndex = 30;
            this.button1.Text = "Tạo nhóm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_name_new_group
            // 
            this.m_name_new_group.Location = new System.Drawing.Point(137, 19);
            this.m_name_new_group.Name = "m_name_new_group";
            this.m_name_new_group.Size = new System.Drawing.Size(165, 20);
            this.m_name_new_group.TabIndex = 29;
            // 
            // m_lb_me_list_group
            // 
            this.m_lb_me_list_group.CheckOnClick = true;
            this.m_lb_me_list_group.FormattingEnabled = true;
            this.m_lb_me_list_group.Location = new System.Drawing.Point(49, 103);
            this.m_lb_me_list_group.Name = "m_lb_me_list_group";
            this.m_lb_me_list_group.Size = new System.Drawing.Size(364, 424);
            this.m_lb_me_list_group.TabIndex = 27;
            // 
            // m_chk_all
            // 
            this.m_chk_all.AutoSize = true;
            this.m_chk_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.m_chk_all.Location = new System.Drawing.Point(49, 72);
            this.m_chk_all.Name = "m_chk_all";
            this.m_chk_all.Size = new System.Drawing.Size(209, 18);
            this.m_chk_all.TabIndex = 33;
            this.m_chk_all.Text = "Đánh dấu để chọn tất cả nhóm ở dưới";
            this.m_chk_all.UseVisualStyleBackColor = true;
            this.m_chk_all.CheckedChanged += new System.EventHandler(this.m_chk_all_CheckedChanged);
            // 
            // f108_QLGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 612);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f108_QLGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F108 - Bạn đang sử dụng tài khoản ";
            this.Load += new System.EventHandler(this.f108_QLGroup_Load);
            this.m_tabpage_friend.ResumeLayout(false);
            this.m_tabpage_friend.PerformLayout();
            this.m_tabpage_search.ResumeLayout(false);
            this.m_tabpage_search.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.m_tabpage_create.ResumeLayout(false);
            this.m_tabpage_create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage m_tabpage_friend;
        private System.Windows.Forms.TabPage m_tabpage_search;
        private System.Windows.Forms.WebBrowser m_wb;
        private System.Windows.Forms.ListBox m_lb_friend_list;
        private System.Windows.Forms.Button m_cmd_get_info;
        private System.Windows.Forms.Button m_cmd_join_group;
        private System.Windows.Forms.ProgressBar m_prb_friends;
        private System.Windows.Forms.CheckedListBox m_lb_group_list;
        private System.Windows.Forms.CheckBox m_chk_all_group;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button m_cmd_phan_tich;
        private System.Windows.Forms.TextBox m_txt_search;
        private System.Windows.Forms.Button m_cmd_from_list;
        private System.Windows.Forms.CheckedListBox m_cbl_group;
        private System.Windows.Forms.Button m_cmd_tim_kiem;
        private System.Windows.Forms.TextBox m_txt_tim_kiem;
        private System.Windows.Forms.Button m_cmd_join;
        private System.Windows.Forms.ProgressBar m_pgb_group;
        private System.Windows.Forms.TabPage m_tabpage_create;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox m_name_new_group;
        private System.Windows.Forms.CheckedListBox m_lb_me_list_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_text_search_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox m_chk_all;

    }
}