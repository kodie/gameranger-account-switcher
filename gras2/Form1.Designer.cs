namespace gras2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list_accounts = new System.Windows.Forms.ListBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_editname = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_addacct = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_launch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_accounts
            // 
            this.list_accounts.FormattingEnabled = true;
            this.list_accounts.Location = new System.Drawing.Point(12, 73);
            this.list_accounts.Name = "list_accounts";
            this.list_accounts.Size = new System.Drawing.Size(144, 121);
            this.list_accounts.TabIndex = 0;
            this.list_accounts.SelectedIndexChanged += new System.EventHandler(this.list_accounts_SelectedIndexChanged);
            // 
            // btn_login
            // 
            this.btn_login.Image = global::gras2.Properties.Resources.door_in;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(162, 73);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(105, 26);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Log In";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Image = global::gras2.Properties.Resources.door_out;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(162, 73);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(105, 26);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_editname
            // 
            this.btn_editname.Image = global::gras2.Properties.Resources.user_edit;
            this.btn_editname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editname.Location = new System.Drawing.Point(162, 105);
            this.btn_editname.Name = "btn_editname";
            this.btn_editname.Size = new System.Drawing.Size(105, 26);
            this.btn_editname.TabIndex = 3;
            this.btn_editname.Text = "Edit Name";
            this.btn_editname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editname.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editname.UseVisualStyleBackColor = true;
            this.btn_editname.Click += new System.EventHandler(this.btn_editname_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::gras2.Properties.Resources.user_delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(162, 137);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 26);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_addacct
            // 
            this.btn_addacct.Image = global::gras2.Properties.Resources.user_add;
            this.btn_addacct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addacct.Location = new System.Drawing.Point(162, 169);
            this.btn_addacct.Name = "btn_addacct";
            this.btn_addacct.Size = new System.Drawing.Size(105, 26);
            this.btn_addacct.TabIndex = 5;
            this.btn_addacct.Text = "Add Account";
            this.btn_addacct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addacct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addacct.UseVisualStyleBackColor = true;
            this.btn_addacct.Click += new System.EventHandler(this.btn_addacct_Click);
            // 
            // btn_about
            // 
            this.btn_about.Image = global::gras2.Properties.Resources.information;
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(162, 201);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(105, 26);
            this.btn_about.TabIndex = 6;
            this.btn_about.Text = "About";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_launch
            // 
            this.btn_launch.Image = global::gras2.Properties.Resources.application_go;
            this.btn_launch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_launch.Location = new System.Drawing.Point(12, 201);
            this.btn_launch.Name = "btn_launch";
            this.btn_launch.Size = new System.Drawing.Size(144, 26);
            this.btn_launch.TabIndex = 7;
            this.btn_launch.Text = "Launch GameRanger";
            this.btn_launch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_launch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_launch.UseVisualStyleBackColor = true;
            this.btn_launch.Click += new System.EventHandler(this.btn_launch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gras2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 60);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 236);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_launch);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_addacct);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_editname);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.list_accounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameRanger Account Switcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_accounts;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_editname;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_addacct;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_launch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

