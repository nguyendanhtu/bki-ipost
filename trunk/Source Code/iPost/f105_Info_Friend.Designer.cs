namespace test
{
    partial class f105_Info_Friend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f105_Info_Friend));
            this.m_pic_avatar = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.m_pic_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pic_avatar
            // 
            this.m_pic_avatar.Location = new System.Drawing.Point(12, 12);
            this.m_pic_avatar.Name = "m_pic_avatar";
            this.m_pic_avatar.Size = new System.Drawing.Size(160, 160);
            this.m_pic_avatar.TabIndex = 0;
            this.m_pic_avatar.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(192, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(192, 43);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(23, 13);
            this.link.TabIndex = 2;
            this.link.TabStop = true;
            this.link.Text = "link";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // f105_Info_Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 186);
            this.Controls.Add(this.link);
            this.Controls.Add(this.name);
            this.Controls.Add(this.m_pic_avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f105_Info_Friend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F105 - Thông tin bạn bè";
            ((System.ComponentModel.ISupportInitialize)(this.m_pic_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_pic_avatar;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.LinkLabel link;
    }
}