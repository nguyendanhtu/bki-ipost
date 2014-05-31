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
            this.SuspendLayout();
            // 
            // m_cmd_join
            // 
            this.m_cmd_join.Location = new System.Drawing.Point(205, 509);
            this.m_cmd_join.Name = "m_cmd_join";
            this.m_cmd_join.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_join.TabIndex = 7;
            this.m_cmd_join.Text = "Join Group";
            this.m_cmd_join.UseVisualStyleBackColor = true;
            this.m_cmd_join.Click += new System.EventHandler(this.m_cmd_join_Click);
            // 
            // m_clb_ket_qua
            // 
            this.m_clb_ket_qua.CheckOnClick = true;
            this.m_clb_ket_qua.FormattingEnabled = true;
            this.m_clb_ket_qua.Location = new System.Drawing.Point(12, 123);
            this.m_clb_ket_qua.Name = "m_clb_ket_qua";
            this.m_clb_ket_qua.Size = new System.Drawing.Size(460, 349);
            this.m_clb_ket_qua.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SL Thành viên";
            // 
            // m_txt_sl_thanh_vien
            // 
            this.m_txt_sl_thanh_vien.Enabled = false;
            this.m_txt_sl_thanh_vien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.m_txt_sl_thanh_vien.Location = new System.Drawing.Point(116, 43);
            this.m_txt_sl_thanh_vien.Name = "m_txt_sl_thanh_vien";
            this.m_txt_sl_thanh_vien.Size = new System.Drawing.Size(348, 20);
            this.m_txt_sl_thanh_vien.TabIndex = 3;
            this.m_txt_sl_thanh_vien.Text = "Bạn phải trả phí để thực hiện chức năng này";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ khóa";
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(116, 17);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(348, 20);
            this.m_txt_tu_khoa.TabIndex = 1;
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(206, 69);
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
            this.progressBar1.Location = new System.Drawing.Point(28, 479);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(429, 24);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // m_chk_all
            // 
            this.m_chk_all.AutoSize = true;
            this.m_chk_all.Location = new System.Drawing.Point(14, 100);
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
            this.m_lbl_group.Location = new System.Drawing.Point(226, 101);
            this.m_lbl_group.Name = "m_lbl_group";
            this.m_lbl_group.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_group.TabIndex = 16;
            // 
            // f108_QLGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 537);
            this.Controls.Add(this.m_lbl_group);
            this.Controls.Add(this.m_chk_all);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.m_cmd_join);
            this.Controls.Add(this.m_clb_ket_qua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_cmd_tim_kiem);
            this.Controls.Add(this.m_txt_sl_thanh_vien);
            this.Controls.Add(this.m_txt_tu_khoa);
            this.Controls.Add(this.label1);
            this.Name = "f108_QLGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F108 - Quản lý các group facebook";
            this.Load += new System.EventHandler(this.f108_QLGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}