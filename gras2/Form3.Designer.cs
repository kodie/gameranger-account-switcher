namespace gras2
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_app_name = new System.Windows.Forms.Label();
            this.label_app_author = new System.Windows.Forms.Label();
            this.label_app_version = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_about = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tab_license = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tab_uninstall = new System.Windows.Forms.TabPage();
            this.btn_uninstall = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.link_kodieg = new System.Windows.Forms.LinkLabel();
            this.link_gameranger = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_about.SuspendLayout();
            this.tab_license.SuspendLayout();
            this.tab_uninstall.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gras2.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_app_name
            // 
            this.label_app_name.AutoSize = true;
            this.label_app_name.Location = new System.Drawing.Point(56, 12);
            this.label_app_name.Name = "label_app_name";
            this.label_app_name.Size = new System.Drawing.Size(157, 13);
            this.label_app_name.TabIndex = 1;
            this.label_app_name.Text = "GameRanger Account Switcher";
            // 
            // label_app_author
            // 
            this.label_app_author.AutoSize = true;
            this.label_app_author.Location = new System.Drawing.Point(56, 38);
            this.label_app_author.Name = "label_app_author";
            this.label_app_author.Size = new System.Drawing.Size(97, 13);
            this.label_app_author.TabIndex = 2;
            this.label_app_author.Text = "by Kodie Grantham";
            // 
            // label_app_version
            // 
            this.label_app_version.AutoSize = true;
            this.label_app_version.Location = new System.Drawing.Point(56, 25);
            this.label_app_version.Name = "label_app_version";
            this.label_app_version.Size = new System.Drawing.Size(60, 13);
            this.label_app_version.TabIndex = 3;
            this.label_app_version.Text = "Version 2.0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_about);
            this.tabControl1.Controls.Add(this.tab_license);
            this.tabControl1.Controls.Add(this.tab_uninstall);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(241, 177);
            this.tabControl1.TabIndex = 4;
            // 
            // tab_about
            // 
            this.tab_about.Controls.Add(this.textBox1);
            this.tab_about.Location = new System.Drawing.Point(4, 22);
            this.tab_about.Name = "tab_about";
            this.tab_about.Padding = new System.Windows.Forms.Padding(3);
            this.tab_about.Size = new System.Drawing.Size(233, 151);
            this.tab_about.TabIndex = 0;
            this.tab_about.Text = "About";
            this.tab_about.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(221, 139);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tab_license
            // 
            this.tab_license.Controls.Add(this.textBox2);
            this.tab_license.Location = new System.Drawing.Point(4, 22);
            this.tab_license.Name = "tab_license";
            this.tab_license.Padding = new System.Windows.Forms.Padding(3);
            this.tab_license.Size = new System.Drawing.Size(233, 151);
            this.tab_license.TabIndex = 1;
            this.tab_license.Text = "License";
            this.tab_license.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(221, 139);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tab_uninstall
            // 
            this.tab_uninstall.Controls.Add(this.btn_uninstall);
            this.tab_uninstall.Controls.Add(this.textBox3);
            this.tab_uninstall.Location = new System.Drawing.Point(4, 22);
            this.tab_uninstall.Name = "tab_uninstall";
            this.tab_uninstall.Size = new System.Drawing.Size(233, 151);
            this.tab_uninstall.TabIndex = 2;
            this.tab_uninstall.Text = "Uninstall";
            this.tab_uninstall.UseVisualStyleBackColor = true;
            // 
            // btn_uninstall
            // 
            this.btn_uninstall.Image = global::gras2.Properties.Resources.bomb;
            this.btn_uninstall.Location = new System.Drawing.Point(6, 123);
            this.btn_uninstall.Name = "btn_uninstall";
            this.btn_uninstall.Size = new System.Drawing.Size(221, 24);
            this.btn_uninstall.TabIndex = 1;
            this.btn_uninstall.Text = "I understand, go ahead and uninstall";
            this.btn_uninstall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_uninstall.UseVisualStyleBackColor = true;
            this.btn_uninstall.Click += new System.EventHandler(this.btn_uninstall_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(221, 111);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(159, 239);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 24);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // link_kodieg
            // 
            this.link_kodieg.AutoSize = true;
            this.link_kodieg.Location = new System.Drawing.Point(13, 236);
            this.link_kodieg.Name = "link_kodieg";
            this.link_kodieg.Size = new System.Drawing.Size(93, 13);
            this.link_kodieg.TabIndex = 6;
            this.link_kodieg.TabStop = true;
            this.link_kodieg.Text = "http://kodieg.com";
            this.link_kodieg.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_kodieg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_kodieg_LinkClicked);
            // 
            // link_gameranger
            // 
            this.link_gameranger.AutoSize = true;
            this.link_gameranger.Location = new System.Drawing.Point(13, 250);
            this.link_gameranger.Name = "link_gameranger";
            this.link_gameranger.Size = new System.Drawing.Size(117, 13);
            this.link_gameranger.TabIndex = 7;
            this.link_gameranger.TabStop = true;
            this.link_gameranger.Text = "http://gameranger.com";
            this.link_gameranger.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_gameranger_LinkClicked);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 271);
            this.Controls.Add(this.link_gameranger);
            this.Controls.Add(this.link_kodieg);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_app_version);
            this.Controls.Add(this.label_app_author);
            this.Controls.Add(this.label_app_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_about.ResumeLayout(false);
            this.tab_about.PerformLayout();
            this.tab_license.ResumeLayout(false);
            this.tab_license.PerformLayout();
            this.tab_uninstall.ResumeLayout(false);
            this.tab_uninstall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_app_name;
        private System.Windows.Forms.Label label_app_author;
        private System.Windows.Forms.Label label_app_version;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_about;
        private System.Windows.Forms.TabPage tab_license;
        private System.Windows.Forms.TabPage tab_uninstall;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_uninstall;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.LinkLabel link_kodieg;
        private System.Windows.Forms.LinkLabel link_gameranger;
    }
}