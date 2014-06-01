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
            this.m_cmd_join = new System.Windows.Forms.Button();
            this.m_clb_ket_qua = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_sl_thanh_vien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_tu_khoa = new System.Windows.Forms.TextBox();
            this.m_cmd_tim_kiem = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.m_chk_all = new System.Windows.Forms.CheckBox();
            this.m_lbl_group = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_tabpage_group = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_tabpage_friend = new System.Windows.Forms.TabPage();
            this.m_lb_friend_list = new System.Windows.Forms.ListBox();
            this.m_cmd_get_info = new System.Windows.Forms.Button();
            this.m_cmd_join_group = new System.Windows.Forms.Button();
            this.m_prb_friends = new System.Windows.Forms.ProgressBar();
            this.m_lb_group_list = new System.Windows.Forms.CheckedListBox();
            this.m_chk_all_group = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.m_tabpage_group.SuspendLayout();
            this.panel1.SuspendLayout();
            this.m_tabpage_friend.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_join
            // 
            this.m_cmd_join.Location = new System.Drawing.Point(230, 501);
            this.m_cmd_join.Name = "m_cmd_join";
            this.m_cmd_join.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_join.TabIndex = 7;
            this.m_cmd_join.Text = "Xin gia nhập";
            this.m_cmd_join.UseVisualStyleBackColor = true;
            this.m_cmd_join.Click += new System.EventHandler(this.m_cmd_join_Click);
            // 
            // m_clb_ket_qua
            // 
            this.m_clb_ket_qua.CheckOnClick = true;
            this.m_clb_ket_qua.FormattingEnabled = true;
            this.m_clb_ket_qua.Location = new System.Drawing.Point(22, 128);
            this.m_clb_ket_qua.Name = "m_clb_ket_qua";
            this.m_clb_ket_qua.Size = new System.Drawing.Size(490, 334);
            this.m_clb_ket_qua.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SL Thành viên";
            // 
            // m_txt_sl_thanh_vien
            // 
            this.m_txt_sl_thanh_vien.Enabled = false;
            this.m_txt_sl_thanh_vien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.m_txt_sl_thanh_vien.Location = new System.Drawing.Point(145, 47);
            this.m_txt_sl_thanh_vien.Name = "m_txt_sl_thanh_vien";
            this.m_txt_sl_thanh_vien.Size = new System.Drawing.Size(348, 20);
            this.m_txt_sl_thanh_vien.TabIndex = 3;
            this.m_txt_sl_thanh_vien.Text = "Bạn phải trả phí để thực hiện chức năng này";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ khóa";
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(145, 21);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(348, 20);
            this.m_txt_tu_khoa.TabIndex = 1;
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(230, 73);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_tim_kiem.TabIndex = 0;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm";
            this.m_cmd_tim_kiem.UseVisualStyleBackColor = true;
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_tim_kiem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(38, 471);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 24);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // m_chk_all
            // 
            this.m_chk_all.AutoSize = true;
            this.m_chk_all.Location = new System.Drawing.Point(25, 108);
            this.m_chk_all.Name = "m_chk_all";
            this.m_chk_all.Size = new System.Drawing.Size(57, 17);
            this.m_chk_all.TabIndex = 15;
            this.m_chk_all.Text = "Tất cả";
            this.m_chk_all.UseVisualStyleBackColor = true;
            this.m_chk_all.CheckedChanged += new System.EventHandler(this.m_chk_all_CheckedChanged);
            // 
            // m_lbl_group
            // 
            this.m_lbl_group.AutoSize = true;
            this.m_lbl_group.Location = new System.Drawing.Point(255, 105);
            this.m_lbl_group.Name = "m_lbl_group";
            this.m_lbl_group.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_group.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_tabpage_group);
            this.tabControl1.Controls.Add(this.m_tabpage_friend);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 568);
            this.tabControl1.TabIndex = 17;
            // 
            // m_tabpage_group
            // 
            this.m_tabpage_group.Controls.Add(this.panel1);
            this.m_tabpage_group.Location = new System.Drawing.Point(4, 22);
            this.m_tabpage_group.Name = "m_tabpage_group";
            this.m_tabpage_group.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabpage_group.Size = new System.Drawing.Size(541, 542);
            this.m_tabpage_group.TabIndex = 0;
            this.m_tabpage_group.Text = "Tìm kiếm Group theo tên";
            this.m_tabpage_group.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_tim_kiem);
            this.panel1.Controls.Add(this.m_txt_tu_khoa);
            this.panel1.Controls.Add(this.m_clb_ket_qua);
            this.panel1.Controls.Add(this.m_cmd_join);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.m_txt_sl_thanh_vien);
            this.panel1.Controls.Add(this.m_lbl_group);
            this.panel1.Controls.Add(this.m_chk_all);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 536);
            this.panel1.TabIndex = 17;
            // 
            // m_tabpage_friend
            // 
            this.m_tabpage_friend.Controls.Add(this.m_lb_friend_list);
            this.m_tabpage_friend.Controls.Add(this.m_cmd_get_info);
            this.m_tabpage_friend.Controls.Add(this.m_cmd_join_group);
            this.m_tabpage_friend.Controls.Add(this.m_prb_friends);
            this.m_tabpage_friend.Controls.Add(this.m_lb_group_list);
            this.m_tabpage_friend.Controls.Add(this.m_chk_all_group);
            this.m_tabpage_friend.Location = new System.Drawing.Point(4, 22);
            this.m_tabpage_friend.Name = "m_tabpage_friend";
            this.m_tabpage_friend.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabpage_friend.Size = new System.Drawing.Size(541, 542);
            this.m_tabpage_friend.TabIndex = 1;
            this.m_tabpage_friend.Text = "Tìm kiếm Group theo bạn bè";
            this.m_tabpage_friend.UseVisualStyleBackColor = true;
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
            // 
            // m_prb_friends
            // 
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
            // f108_QLGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 568);
            this.Controls.Add(this.tabControl1);
            this.Name = "f108_QLGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F108 - Quản lý các group facebook";
            this.Load += new System.EventHandler(this.f108_QLGroup_Load);
            this.tabControl1.ResumeLayout(false);
            this.m_tabpage_group.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.m_tabpage_friend.ResumeLayout(false);
            this.m_tabpage_friend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_tu_khoa;
        private System.Windows.Forms.Button m_cmd_tim_kiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_sl_thanh_vien;
        private System.Windows.Forms.Button m_cmd_join;
        private System.Windows.Forms.CheckedListBox m_clb_ket_qua;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox m_chk_all;
        private System.Windows.Forms.Label m_lbl_group;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage m_tabpage_group;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage m_tabpage_friend;
        private System.Windows.Forms.CheckedListBox m_lb_group_list;
        private System.Windows.Forms.CheckBox m_chk_all_group;
        private System.Windows.Forms.Button m_cmd_join_group;
        private System.Windows.Forms.ProgressBar m_prb_friends;
        private System.Windows.Forms.Button m_cmd_get_info;
        private System.Windows.Forms.ListBox m_lb_friend_list;
    }
}