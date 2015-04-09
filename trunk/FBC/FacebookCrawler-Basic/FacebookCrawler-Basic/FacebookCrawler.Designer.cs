namespace FacebookCrawler_Basic
{
    partial class FacebookCrawler
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
            this.m_pn_action = new System.Windows.Forms.Panel();
            this.m_cmd_import_cookie = new System.Windows.Forms.Button();
            this.m_dat = new System.Windows.Forms.DateTimePicker();
            this.m_cmd_export = new System.Windows.Forms.Button();
            this.m_cmd_import = new System.Windows.Forms.Button();
            this.m_cmd_start = new System.Windows.Forms.Button();
            this.m_pn_browser = new System.Windows.Forms.Panel();
            this.tbProgress = new System.Windows.Forms.Label();
            this.act = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.xs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.presence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.csm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_pn_url = new System.Windows.Forms.Panel();
            this.m_lst_url = new System.Windows.Forms.ListBox();
            this.m_bgwk = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.m_pn_action.SuspendLayout();
            this.m_pn_browser.SuspendLayout();
            this.m_pn_url.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pn_action
            // 
            this.m_pn_action.Controls.Add(this.button1);
            this.m_pn_action.Controls.Add(this.m_cmd_import_cookie);
            this.m_pn_action.Controls.Add(this.m_dat);
            this.m_pn_action.Controls.Add(this.m_cmd_export);
            this.m_pn_action.Controls.Add(this.m_cmd_import);
            this.m_pn_action.Controls.Add(this.m_cmd_start);
            this.m_pn_action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pn_action.Location = new System.Drawing.Point(0, 306);
            this.m_pn_action.Name = "m_pn_action";
            this.m_pn_action.Size = new System.Drawing.Size(954, 73);
            this.m_pn_action.TabIndex = 1;
            // 
            // m_cmd_import_cookie
            // 
            this.m_cmd_import_cookie.Location = new System.Drawing.Point(12, 19);
            this.m_cmd_import_cookie.Name = "m_cmd_import_cookie";
            this.m_cmd_import_cookie.Size = new System.Drawing.Size(140, 41);
            this.m_cmd_import_cookie.TabIndex = 4;
            this.m_cmd_import_cookie.Text = "Nhập Cookie";
            this.m_cmd_import_cookie.UseVisualStyleBackColor = true;
            this.m_cmd_import_cookie.Click += new System.EventHandler(this.m_cmd_import_cookie_Click);
            // 
            // m_dat
            // 
            this.m_dat.CustomFormat = "dd/MM/yyyy -- hh:mm:ss";
            this.m_dat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat.Location = new System.Drawing.Point(742, 27);
            this.m_dat.Name = "m_dat";
            this.m_dat.Size = new System.Drawing.Size(200, 20);
            this.m_dat.TabIndex = 3;
            // 
            // m_cmd_export
            // 
            this.m_cmd_export.Location = new System.Drawing.Point(450, 20);
            this.m_cmd_export.Name = "m_cmd_export";
            this.m_cmd_export.Size = new System.Drawing.Size(140, 41);
            this.m_cmd_export.TabIndex = 2;
            this.m_cmd_export.Text = "Xuất danh sách url";
            this.m_cmd_export.UseVisualStyleBackColor = true;
            this.m_cmd_export.Click += new System.EventHandler(this.m_cmd_export_Click);
            // 
            // m_cmd_import
            // 
            this.m_cmd_import.Location = new System.Drawing.Point(304, 20);
            this.m_cmd_import.Name = "m_cmd_import";
            this.m_cmd_import.Size = new System.Drawing.Size(140, 41);
            this.m_cmd_import.TabIndex = 1;
            this.m_cmd_import.Text = "Nhập danh sách url";
            this.m_cmd_import.UseVisualStyleBackColor = true;
            this.m_cmd_import.Click += new System.EventHandler(this.m_cmd_import_Click);
            // 
            // m_cmd_start
            // 
            this.m_cmd_start.Location = new System.Drawing.Point(158, 19);
            this.m_cmd_start.Name = "m_cmd_start";
            this.m_cmd_start.Size = new System.Drawing.Size(140, 41);
            this.m_cmd_start.TabIndex = 0;
            this.m_cmd_start.Text = "Bắt đầu";
            this.m_cmd_start.UseVisualStyleBackColor = true;
            this.m_cmd_start.Click += new System.EventHandler(this.m_cmd_start_Click);
            // 
            // m_pn_browser
            // 
            this.m_pn_browser.Controls.Add(this.tbProgress);
            this.m_pn_browser.Controls.Add(this.act);
            this.m_pn_browser.Controls.Add(this.label10);
            this.m_pn_browser.Controls.Add(this.xs);
            this.m_pn_browser.Controls.Add(this.label9);
            this.m_pn_browser.Controls.Add(this.s);
            this.m_pn_browser.Controls.Add(this.label8);
            this.m_pn_browser.Controls.Add(this.presence);
            this.m_pn_browser.Controls.Add(this.label7);
            this.m_pn_browser.Controls.Add(this.p);
            this.m_pn_browser.Controls.Add(this.label6);
            this.m_pn_browser.Controls.Add(this.lu);
            this.m_pn_browser.Controls.Add(this.label5);
            this.m_pn_browser.Controls.Add(this.fr);
            this.m_pn_browser.Controls.Add(this.label4);
            this.m_pn_browser.Controls.Add(this.datr);
            this.m_pn_browser.Controls.Add(this.label3);
            this.m_pn_browser.Controls.Add(this.csm);
            this.m_pn_browser.Controls.Add(this.label2);
            this.m_pn_browser.Controls.Add(this.c_user);
            this.m_pn_browser.Controls.Add(this.label1);
            this.m_pn_browser.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_pn_browser.Location = new System.Drawing.Point(0, 0);
            this.m_pn_browser.Name = "m_pn_browser";
            this.m_pn_browser.Size = new System.Drawing.Size(432, 306);
            this.m_pn_browser.TabIndex = 2;
            // 
            // tbProgress
            // 
            this.tbProgress.AutoSize = true;
            this.tbProgress.Location = new System.Drawing.Point(124, 280);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(41, 13);
            this.tbProgress.TabIndex = 41;
            this.tbProgress.Text = "label11";
            // 
            // act
            // 
            this.act.Location = new System.Drawing.Point(127, 11);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(257, 20);
            this.act.TabIndex = 40;
            this.act.Text = "1428257477449%2F9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "act";
            // 
            // xs
            // 
            this.xs.Location = new System.Drawing.Point(127, 245);
            this.xs.Name = "xs";
            this.xs.Size = new System.Drawing.Size(257, 20);
            this.xs.TabIndex = 38;
            this.xs.Text = "19%3AjW-my0xs9WFFXA%3A2%3A1426944370%3A928";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "xs";
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(127, 219);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(257, 20);
            this.s.TabIndex = 36;
            this.s.Text = "Aa7yjDiJ4UWQ9YlE.BVDXFy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "s";
            // 
            // presence
            // 
            this.presence.Location = new System.Drawing.Point(127, 193);
            this.presence.Name = "presence";
            this.presence.Size = new System.Drawing.Size(257, 20);
            this.presence.TabIndex = 34;
            this.presence.Text = "EM428257479EuserFA21B04685250081A2EstateFDsb2F1428257450903Et2F_5b_5dElm2FnullEuc" +
    "t2F1428256817005EtrFA2close_5fescA2EtwF2071317796EatF1428257478610G428257479032C" +
    "EchFDp_5f1B04685250081F15CC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "presence";
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(127, 167);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(257, 20);
            this.p.TabIndex = 32;
            this.p.Text = "-2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "p";
            // 
            // lu
            // 
            this.lu.Location = new System.Drawing.Point(127, 141);
            this.lu.Name = "lu";
            this.lu.Size = new System.Drawing.Size(257, 20);
            this.lu.TabIndex = 30;
            this.lu.Text = "gAGdDMGmkfI9Zl_j_WGCJfyw";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "lu";
            // 
            // fr
            // 
            this.fr.Location = new System.Drawing.Point(127, 115);
            this.fr.Name = "fr";
            this.fr.Size = new System.Drawing.Size(257, 20);
            this.fr.TabIndex = 28;
            this.fr.Text = "0bsm1JVKJiOzv7HsP.AWXFrYFho4J7dEExkpeiZQc2yeA.BUvTXH.2l.FUe.0.AWW8nk-S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "fr";
            // 
            // datr
            // 
            this.datr.Location = new System.Drawing.Point(127, 89);
            this.datr.Name = "datr";
            this.datr.Size = new System.Drawing.Size(257, 20);
            this.datr.TabIndex = 26;
            this.datr.Text = "Cva8VDTP5VWqDII7YQWGSI-F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "datr";
            // 
            // csm
            // 
            this.csm.Location = new System.Drawing.Point(127, 63);
            this.csm.Name = "csm";
            this.csm.Size = new System.Drawing.Size(257, 20);
            this.csm.TabIndex = 24;
            this.csm.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "csm";
            // 
            // c_user
            // 
            this.c_user.Location = new System.Drawing.Point(127, 37);
            this.c_user.Name = "c_user";
            this.c_user.Size = new System.Drawing.Size(257, 20);
            this.c_user.TabIndex = 22;
            this.c_user.Text = "100004685250081";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "c_user";
            // 
            // m_pn_url
            // 
            this.m_pn_url.Controls.Add(this.m_lst_url);
            this.m_pn_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pn_url.Location = new System.Drawing.Point(432, 0);
            this.m_pn_url.Name = "m_pn_url";
            this.m_pn_url.Size = new System.Drawing.Size(522, 306);
            this.m_pn_url.TabIndex = 3;
            // 
            // m_lst_url
            // 
            this.m_lst_url.ColumnWidth = 150;
            this.m_lst_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_lst_url.FormattingEnabled = true;
            this.m_lst_url.Location = new System.Drawing.Point(0, 0);
            this.m_lst_url.MultiColumn = true;
            this.m_lst_url.Name = "m_lst_url";
            this.m_lst_url.Size = new System.Drawing.Size(522, 306);
            this.m_lst_url.TabIndex = 0;
            // 
            // m_bgwk
            // 
            this.m_bgwk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.m_bgwk_DoWork);
            this.m_bgwk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.m_bgwk_ProgressChanged);
            this.m_bgwk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.m_bgwk_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FacebookCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 379);
            this.Controls.Add(this.m_pn_url);
            this.Controls.Add(this.m_pn_browser);
            this.Controls.Add(this.m_pn_action);
            this.Name = "FacebookCrawler";
            this.Text = "Facebook Crawler";
            this.m_pn_action.ResumeLayout(false);
            this.m_pn_browser.ResumeLayout(false);
            this.m_pn_browser.PerformLayout();
            this.m_pn_url.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_pn_action;
        private System.Windows.Forms.Panel m_pn_browser;
        private System.Windows.Forms.Button m_cmd_export;
        private System.Windows.Forms.Button m_cmd_import;
        private System.Windows.Forms.Button m_cmd_start;
        private System.Windows.Forms.Panel m_pn_url;
        private System.Windows.Forms.ListBox m_lst_url;
        private System.Windows.Forms.DateTimePicker m_dat;
        private System.Windows.Forms.TextBox act;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox xs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox presence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox datr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox csm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_cmd_import_cookie;
        private System.ComponentModel.BackgroundWorker m_bgwk;
        private System.Windows.Forms.Label tbProgress;
        private System.Windows.Forms.Button button1;
    }
}

