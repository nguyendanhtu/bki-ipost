﻿namespace test
{
    partial class Advance
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
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_save = new System.Windows.Forms.Button();
            this.m_txt_link = new System.Windows.Forms.TextBox();
            this.m_txt_caption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cmd_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link ảnh";
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Location = new System.Drawing.Point(122, 126);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_save.TabIndex = 1;
            this.m_cmd_save.Text = "OK";
            this.m_cmd_save.UseVisualStyleBackColor = true;
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_txt_link
            // 
            this.m_txt_link.Location = new System.Drawing.Point(122, 29);
            this.m_txt_link.Name = "m_txt_link";
            this.m_txt_link.Size = new System.Drawing.Size(297, 20);
            this.m_txt_link.TabIndex = 2;
            // 
            // m_txt_caption
            // 
            this.m_txt_caption.Location = new System.Drawing.Point(122, 55);
            this.m_txt_caption.Name = "m_txt_caption";
            this.m_txt_caption.Size = new System.Drawing.Size(297, 20);
            this.m_txt_caption.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chú thích";
            // 
            // m_txt_description
            // 
            this.m_txt_description.Location = new System.Drawing.Point(122, 81);
            this.m_txt_description.Name = "m_txt_description";
            this.m_txt_description.Size = new System.Drawing.Size(297, 20);
            this.m_txt_description.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nội dung ngắn";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Location = new System.Drawing.Point(247, 126);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_exit.TabIndex = 7;
            this.m_cmd_exit.Text = "Trở lại";
            this.m_cmd_exit.UseVisualStyleBackColor = true;
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // Advance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 177);
            this.Controls.Add(this.m_cmd_exit);
            this.Controls.Add(this.m_txt_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_txt_caption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txt_link);
            this.Controls.Add(this.m_cmd_save);
            this.Controls.Add(this.label1);
            this.Name = "Advance";
            this.Text = "Advance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_cmd_save;
        private System.Windows.Forms.TextBox m_txt_link;
        private System.Windows.Forms.TextBox m_txt_caption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_cmd_exit;
    }
}