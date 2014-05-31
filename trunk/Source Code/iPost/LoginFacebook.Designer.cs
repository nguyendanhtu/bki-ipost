namespace test
{
    partial class LoginFacebook
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
            this.m_wb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // m_wb
            // 
            this.m_wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_wb.Location = new System.Drawing.Point(0, 0);
            this.m_wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_wb.Name = "m_wb";
            this.m_wb.Size = new System.Drawing.Size(808, 442);
            this.m_wb.TabIndex = 0;
            this.m_wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.m_wb_DocumentCompleted);
            // 
            // LoginFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 442);
            this.Controls.Add(this.m_wb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(824, 480);
            this.MinimumSize = new System.Drawing.Size(824, 480);
            this.Name = "LoginFacebook";
            this.Text = "iPost 3.0 - Đăng nhập Facebook";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser m_wb;
    }
}