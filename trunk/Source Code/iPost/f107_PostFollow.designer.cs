namespace test
{
    partial class f107_PostFollow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f107_PostFollow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_show_post = new System.Windows.Forms.Button();
            this.m_cmd_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_txt_comment = new System.Windows.Forms.TextBox();
            this.m_wb = new System.Windows.Forms.WebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_grv = new System.Windows.Forms.DataGridView();
            this.ID_POSTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_show_post);
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 38);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_show_post
            // 
            this.m_cmd_show_post.Location = new System.Drawing.Point(168, 8);
            this.m_cmd_show_post.Name = "m_cmd_show_post";
            this.m_cmd_show_post.Size = new System.Drawing.Size(123, 23);
            this.m_cmd_show_post.TabIndex = 1;
            this.m_cmd_show_post.Text = "Xem bài đăng";
            this.m_cmd_show_post.UseVisualStyleBackColor = true;
            this.m_cmd_show_post.Click += new System.EventHandler(this.m_cmd_show_post_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Location = new System.Drawing.Point(790, 8);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_exit.TabIndex = 0;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.UseVisualStyleBackColor = true;
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_txt_comment);
            this.panel2.Controls.Add(this.m_wb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(606, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 428);
            this.panel2.TabIndex = 1;
            // 
            // m_txt_comment
            // 
            this.m_txt_comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_txt_comment.Location = new System.Drawing.Point(0, 356);
            this.m_txt_comment.Multiline = true;
            this.m_txt_comment.Name = "m_txt_comment";
            this.m_txt_comment.Size = new System.Drawing.Size(378, 72);
            this.m_txt_comment.TabIndex = 1;
            this.m_txt_comment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txt_comment_KeyUp);
            // 
            // m_wb
            // 
            this.m_wb.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_wb.Location = new System.Drawing.Point(0, 0);
            this.m_wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_wb.Name = "m_wb";
            this.m_wb.Size = new System.Drawing.Size(378, 356);
            this.m_wb.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 428);
            this.panel3.TabIndex = 2;
            // 
            // m_grv
            // 
            this.m_grv.AllowUserToAddRows = false;
            this.m_grv.AllowUserToDeleteRows = false;
            this.m_grv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.m_grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_POSTS,
            this.GROUP,
            this.TITLE,
            this.count_comment});
            this.m_grv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grv.Location = new System.Drawing.Point(0, 0);
            this.m_grv.Name = "m_grv";
            this.m_grv.ReadOnly = true;
            this.m_grv.Size = new System.Drawing.Size(606, 428);
            this.m_grv.TabIndex = 0;
            this.m_grv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_grv_CellContentClick);
            this.m_grv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.m_grv_RowHeaderMouseClick);
            // 
            // ID_POSTS
            // 
            this.ID_POSTS.DataPropertyName = "fpid";
            this.ID_POSTS.HeaderText = "ID Post";
            this.ID_POSTS.Name = "ID_POSTS";
            this.ID_POSTS.ReadOnly = true;
            // 
            // GROUP
            // 
            this.GROUP.DataPropertyName = "fgid";
            this.GROUP.HeaderText = "GROUP";
            this.GROUP.Name = "GROUP";
            this.GROUP.ReadOnly = true;
            this.GROUP.Width = 130;
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "content";
            this.TITLE.HeaderText = "Nội dung";
            this.TITLE.Name = "TITLE";
            this.TITLE.ReadOnly = true;
            this.TITLE.Width = 245;
            // 
            // count_comment
            // 
            this.count_comment.DataPropertyName = "count_comment";
            this.count_comment.HeaderText = "SL Comment";
            this.count_comment.Name = "count_comment";
            this.count_comment.ReadOnly = true;
            // 
            // f107_PostFollow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 504);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 504);
            this.Name = "f107_PostFollow";
            this.ShowInTaskbar = false;
            this.Text = "PostFollow";
            this.Load += new System.EventHandler(this.f107_PostFollow_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox m_txt_comment;
        private System.Windows.Forms.WebBrowser m_wb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView m_grv;
        private System.Windows.Forms.Button m_cmd_exit;
        private System.Windows.Forms.Button m_cmd_show_post;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_POSTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_comment;

    }
}