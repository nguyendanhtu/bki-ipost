namespace test
{
    partial class f102_Upload_image
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
            this.m_lb_image_list = new System.Windows.Forms.ListBox();
            this.m_txt_description = new System.Windows.Forms.TextBox();
            this.m_txt_album_name = new System.Windows.Forms.TextBox();
            this.m_lbl_album_name = new System.Windows.Forms.Label();
            this.m_lbl_album_des = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_btn_insert = new System.Windows.Forms.Button();
            this.m_cmd_delete = new System.Windows.Forms.Button();
            this.m_cmd_upload = new System.Windows.Forms.Button();
            this.m_wb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // m_lb_image_list
            // 
            this.m_lb_image_list.FormattingEnabled = true;
            this.m_lb_image_list.Location = new System.Drawing.Point(113, 175);
            this.m_lb_image_list.Name = "m_lb_image_list";
            this.m_lb_image_list.Size = new System.Drawing.Size(304, 134);
            this.m_lb_image_list.TabIndex = 0;
            // 
            // m_txt_description
            // 
            this.m_txt_description.Location = new System.Drawing.Point(113, 97);
            this.m_txt_description.Multiline = true;
            this.m_txt_description.Name = "m_txt_description";
            this.m_txt_description.Size = new System.Drawing.Size(304, 52);
            this.m_txt_description.TabIndex = 1;
            // 
            // m_txt_album_name
            // 
            this.m_txt_album_name.Location = new System.Drawing.Point(113, 51);
            this.m_txt_album_name.Name = "m_txt_album_name";
            this.m_txt_album_name.Size = new System.Drawing.Size(304, 20);
            this.m_txt_album_name.TabIndex = 2;
            // 
            // m_lbl_album_name
            // 
            this.m_lbl_album_name.AutoSize = true;
            this.m_lbl_album_name.Location = new System.Drawing.Point(12, 58);
            this.m_lbl_album_name.Name = "m_lbl_album_name";
            this.m_lbl_album_name.Size = new System.Drawing.Size(58, 13);
            this.m_lbl_album_name.TabIndex = 3;
            this.m_lbl_album_name.Text = "Tên Album";
            // 
            // m_lbl_album_des
            // 
            this.m_lbl_album_des.AutoSize = true;
            this.m_lbl_album_des.Location = new System.Drawing.Point(12, 97);
            this.m_lbl_album_des.Name = "m_lbl_album_des";
            this.m_lbl_album_des.Size = new System.Drawing.Size(65, 13);
            this.m_lbl_album_des.TabIndex = 4;
            this.m_lbl_album_des.Text = "Mô tả album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách ảnh";
            // 
            // m_btn_insert
            // 
            this.m_btn_insert.Location = new System.Drawing.Point(75, 342);
            this.m_btn_insert.Name = "m_btn_insert";
            this.m_btn_insert.Size = new System.Drawing.Size(75, 23);
            this.m_btn_insert.TabIndex = 6;
            this.m_btn_insert.Text = "Thêm ảnh";
            this.m_btn_insert.UseVisualStyleBackColor = true;
            this.m_btn_insert.Click += new System.EventHandler(this.m_btn_insert_Click);
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Location = new System.Drawing.Point(188, 342);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_delete.TabIndex = 7;
            this.m_cmd_delete.Text = "Xóa ảnh";
            this.m_cmd_delete.UseVisualStyleBackColor = true;
            this.m_cmd_delete.Click += new System.EventHandler(this.m_cmd_delete_Click);
            // 
            // m_cmd_upload
            // 
            this.m_cmd_upload.Location = new System.Drawing.Point(301, 342);
            this.m_cmd_upload.Name = "m_cmd_upload";
            this.m_cmd_upload.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_upload.TabIndex = 8;
            this.m_cmd_upload.Text = "Upload";
            this.m_cmd_upload.UseVisualStyleBackColor = true;
            this.m_cmd_upload.Click += new System.EventHandler(this.m_cmd_upload_Click);
            // 
            // m_wb
            // 
            this.m_wb.Location = new System.Drawing.Point(544, 229);
            this.m_wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_wb.Name = "m_wb";
            this.m_wb.Size = new System.Drawing.Size(176, 164);
            this.m_wb.TabIndex = 9;
            // 
            // f102_Upload_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 444);
            this.Controls.Add(this.m_wb);
            this.Controls.Add(this.m_cmd_upload);
            this.Controls.Add(this.m_cmd_delete);
            this.Controls.Add(this.m_btn_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_lbl_album_des);
            this.Controls.Add(this.m_lbl_album_name);
            this.Controls.Add(this.m_txt_album_name);
            this.Controls.Add(this.m_txt_description);
            this.Controls.Add(this.m_lb_image_list);
            this.Name = "f102_Upload_image";
            this.Text = "f102_Upload_image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox m_lb_image_list;
        private System.Windows.Forms.TextBox m_txt_description;
        private System.Windows.Forms.TextBox m_txt_album_name;
        private System.Windows.Forms.Label m_lbl_album_name;
        private System.Windows.Forms.Label m_lbl_album_des;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_btn_insert;
        private System.Windows.Forms.Button m_cmd_delete;
        private System.Windows.Forms.Button m_cmd_upload;
        private System.Windows.Forms.WebBrowser m_wb;
    }
}