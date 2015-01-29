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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f104_post));
            this.m_cmd_post = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cbl_list_group = new System.Windows.Forms.CheckedListBox();
            this.m_box_list_nhom = new System.Windows.Forms.CheckedListBox();
            this.m_but_create = new System.Windows.Forms.Button();
            this.m_txt_name_nhom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_search = new System.Windows.Forms.TextBox();
            this.m_chk_all = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_comment = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_post
            // 
            this.m_cmd_post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.m_cmd_post.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_post.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_post.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.m_cmd_post.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_post.Name = "m_cmd_post";
            this.m_cmd_post.Size = new System.Drawing.Size(297, 48);
            this.m_cmd_post.TabIndex = 0;
            this.m_cmd_post.Text = "Đăng bài";
            this.m_cmd_post.UseVisualStyleBackColor = false;
            this.m_cmd_post.Click += new System.EventHandler(this.m_cmd_post_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cbl_list_group);
            this.panel1.Controls.Add(this.m_box_list_nhom);
            this.panel1.Controls.Add(this.m_but_create);
            this.panel1.Controls.Add(this.m_txt_name_nhom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_txt_search);
            this.panel1.Controls.Add(this.m_chk_all);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 473);
            this.panel1.TabIndex = 4;
            // 
            // m_cbl_list_group
            // 
            this.m_cbl_list_group.FormattingEnabled = true;
            this.m_cbl_list_group.Location = new System.Drawing.Point(7, 152);
            this.m_cbl_list_group.Name = "m_cbl_list_group";
            this.m_cbl_list_group.Size = new System.Drawing.Size(216, 319);
            this.m_cbl_list_group.TabIndex = 21;
            this.m_cbl_list_group.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.m_cbl_list_group_ItemCheck);
            // 
            // m_box_list_nhom
            // 
            this.m_box_list_nhom.CheckOnClick = true;
            this.m_box_list_nhom.FormattingEnabled = true;
            this.m_box_list_nhom.Location = new System.Drawing.Point(7, 24);
            this.m_box_list_nhom.Name = "m_box_list_nhom";
            this.m_box_list_nhom.Size = new System.Drawing.Size(216, 49);
            this.m_box_list_nhom.TabIndex = 20;
            this.m_box_list_nhom.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.m_box_list_nhom_ItemCheck);
            // 
            // m_but_create
            // 
            this.m_but_create.Location = new System.Drawing.Point(158, 126);
            this.m_but_create.Name = "m_but_create";
            this.m_but_create.Size = new System.Drawing.Size(65, 20);
            this.m_but_create.TabIndex = 19;
            this.m_but_create.Text = "Tạo nhóm";
            this.m_but_create.UseVisualStyleBackColor = true;
            this.m_but_create.Click += new System.EventHandler(this.m_but_create_Click);
            // 
            // m_txt_name_nhom
            // 
            this.m_txt_name_nhom.Location = new System.Drawing.Point(3, 126);
            this.m_txt_name_nhom.Name = "m_txt_name_nhom";
            this.m_txt_name_nhom.Size = new System.Drawing.Size(149, 20);
            this.m_txt_name_nhom.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.label7.Location = new System.Drawing.Point(30, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Chọn các group muốn đăng bài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "1";
            // 
            // m_txt_search
            // 
            this.m_txt_search.Location = new System.Drawing.Point(7, 76);
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.Size = new System.Drawing.Size(215, 20);
            this.m_txt_search.TabIndex = 1;
            this.toolTip1.SetToolTip(this.m_txt_search, "Gõ từ khóa để tìm kiếm các nhóm bạn muốn đăng bài");
            this.m_txt_search.TextChanged += new System.EventHandler(this.m_txt_search_TextChanged);
            // 
            // m_chk_all
            // 
            this.m_chk_all.AutoSize = true;
            this.m_chk_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.m_chk_all.Location = new System.Drawing.Point(7, 102);
            this.m_chk_all.Name = "m_chk_all";
            this.m_chk_all.Size = new System.Drawing.Size(209, 18);
            this.m_chk_all.TabIndex = 1;
            this.m_chk_all.Text = "Đánh dấu để chọn tất cả nhóm ở dưới";
            this.m_chk_all.UseVisualStyleBackColor = true;
            this.m_chk_all.CheckedChanged += new System.EventHandler(this.m_chk_all_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_comment);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.m_cmd_post);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(239, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 48);
            this.panel2.TabIndex = 5;
            // 
            // m_cmd_comment
            // 
            this.m_cmd_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.m_cmd_comment.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_comment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_comment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.m_cmd_comment.Location = new System.Drawing.Point(312, 0);
            this.m_cmd_comment.Name = "m_cmd_comment";
            this.m_cmd_comment.Size = new System.Drawing.Size(297, 48);
            this.m_cmd_comment.TabIndex = 2;
            this.m_cmd_comment.Text = "Comment";
            this.m_cmd_comment.UseVisualStyleBackColor = false;
            this.m_cmd_comment.Click += new System.EventHandler(this.m_cmd_comment_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "5";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
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
            this.panel3.Location = new System.Drawing.Point(239, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 425);
            this.panel3.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(18, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(18, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(18, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "2";
            // 
            // m_txt_message
            // 
            this.m_txt_message.Location = new System.Drawing.Point(122, 68);
            this.m_txt_message.Multiline = true;
            this.m_txt_message.Name = "m_txt_message";
            this.m_txt_message.Size = new System.Drawing.Size(474, 282);
            this.m_txt_message.TabIndex = 9;
            this.toolTip1.SetToolTip(this.m_txt_message, "1. Yêu bạn hàng của bạn. Hãy đăng bài để đem giúp họ có được sản phẩm cũng như ch" +
        "ất lượng tốt hơn\r\n2. Bạn nên học kỹ thuật AIDA để bài viết được nhiều người quan" +
        " tâm");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Để tránh bị khóa tài khoản nhé!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "-  Ít nhất là: 10s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mình đề xuất: 20s";
            // 
            // m_cmd_advance
            // 
            this.m_cmd_advance.Location = new System.Drawing.Point(521, 354);
            this.m_cmd_advance.Name = "m_cmd_advance";
            this.m_cmd_advance.Size = new System.Drawing.Size(75, 25);
            this.m_cmd_advance.TabIndex = 14;
            this.m_cmd_advance.Text = "Nâng cao";
            this.m_cmd_advance.UseVisualStyleBackColor = true;
            this.m_cmd_advance.Click += new System.EventHandler(this.m_cmd_advance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "s";
            // 
            // m_txt_time
            // 
            this.m_txt_time.Location = new System.Drawing.Point(222, 19);
            this.m_txt_time.Name = "m_txt_time";
            this.m_txt_time.Size = new System.Drawing.Size(75, 20);
            this.m_txt_time.TabIndex = 2;
            this.m_txt_time.Text = "20";
            this.toolTip1.SetToolTip(this.m_txt_time, "Nên để thời gian vừa phải để TRÁNH bị khóa tài khoản bạn ạ");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chỉnh thời gian giữa 2 lần đăng bài";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(5, 392);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(599, 26);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 15;
            // 
            // m_chk_has_image
            // 
            this.m_chk_has_image.AutoSize = true;
            this.m_chk_has_image.Location = new System.Drawing.Point(4, 332);
            this.m_chk_has_image.Name = "m_chk_has_image";
            this.m_chk_has_image.Size = new System.Drawing.Size(118, 18);
            this.m_chk_has_image.TabIndex = 10;
            this.m_chk_has_image.Text = "Chưa đính kèm ảnh";
            this.toolTip1.SetToolTip(this.m_chk_has_image, "Bạn nên có ảnh để bài viết được quan tâm nhiều hơn");
            this.m_chk_has_image.UseVisualStyleBackColor = true;
            this.m_chk_has_image.CheckedChanged += new System.EventHandler(this.m_chk_has_image_CheckedChanged);
            // 
            // m_lbl_image_url
            // 
            this.m_lbl_image_url.AutoSize = true;
            this.m_lbl_image_url.Location = new System.Drawing.Point(40, 360);
            this.m_lbl_image_url.Name = "m_lbl_image_url";
            this.m_lbl_image_url.Size = new System.Drawing.Size(71, 14);
            this.m_lbl_image_url.TabIndex = 12;
            this.m_lbl_image_url.Text = "Link đính kèm";
            // 
            // m_txt_url_image
            // 
            this.m_txt_url_image.Location = new System.Drawing.Point(122, 356);
            this.m_txt_url_image.Name = "m_txt_url_image";
            this.m_txt_url_image.Size = new System.Drawing.Size(394, 20);
            this.m_txt_url_image.TabIndex = 13;
            this.toolTip1.SetToolTip(this.m_txt_url_image, "Trăm nghe không bằng một thấy! \r\nBạn NÊN biên soạn ảnh cẩn thận để thu hút bạn hà" +
        "ng. ");
            // 
            // m_lbl_message
            // 
            this.m_lbl_message.AutoSize = true;
            this.m_lbl_message.Location = new System.Drawing.Point(0, 68);
            this.m_lbl_message.Name = "m_lbl_message";
            this.m_lbl_message.Size = new System.Drawing.Size(120, 14);
            this.m_lbl_message.TabIndex = 8;
            this.m_lbl_message.Text = "Soạn nội dung bài đăng";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Gợi ý";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 52);
            this.panel4.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(155)))));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(848, 37);
            this.label11.TabIndex = 0;
            this.label11.Text = "5 BƯỚC ĐƠN GIẢN ĐỂ SẢN PHẨM CỦA BẠN ĐƯỢC HÀNG NGHÌN NGƯỜI BIẾT ĐẾN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // f104_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 525);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "f104_post";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F104 - Bạn đăng bài với tên ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_cmd_post;
        //private System.Windows.Forms.CheckedListBox m_cbl_group;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox m_txt_message;
        private System.Windows.Forms.Label m_lbl_message;
        private System.Windows.Forms.TextBox m_txt_url_image;
        private System.Windows.Forms.Label m_lbl_image_url;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox m_txt_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_cmd_advance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox m_chk_all;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox m_txt_search;
        private System.Windows.Forms.CheckBox m_chk_has_image;
        private System.Windows.Forms.Button m_cmd_comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button m_but_create;
        private System.Windows.Forms.TextBox m_txt_name_nhom;
        private System.Windows.Forms.CheckedListBox m_box_list_nhom;
        private CustomCheckedListBox customCheckedListBox1;
        private System.Windows.Forms.CheckedListBox m_cbl_list_group;
        
    }
}

