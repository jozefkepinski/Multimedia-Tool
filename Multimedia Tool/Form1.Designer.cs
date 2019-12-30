namespace Multimedia_Tool
{
    partial class Form1
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelArchiveSubMenu = new System.Windows.Forms.Panel();
            this.btCreate = new System.Windows.Forms.Button();
            this.btExtract = new System.Windows.Forms.Button();
            this.btnAboutSubMenu = new System.Windows.Forms.Button();
            this.panelSubAbout = new System.Windows.Forms.Panel();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnAppInfo = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelArchiveSubMenu.SuspendLayout();
            this.panelSubAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelSubAbout);
            this.panelSideMenu.Controls.Add(this.btnAboutSubMenu);
            this.panelSideMenu.Controls.Add(this.panelArchiveSubMenu);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 544);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Archive";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelArchiveSubMenu
            // 
            this.panelArchiveSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelArchiveSubMenu.Controls.Add(this.btExtract);
            this.panelArchiveSubMenu.Controls.Add(this.btCreate);
            this.panelArchiveSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArchiveSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelArchiveSubMenu.Name = "panelArchiveSubMenu";
            this.panelArchiveSubMenu.Size = new System.Drawing.Size(250, 89);
            this.panelArchiveSubMenu.TabIndex = 2;
            // 
            // btCreate
            // 
            this.btCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCreate.FlatAppearance.BorderSize = 0;
            this.btCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreate.ForeColor = System.Drawing.Color.LightGray;
            this.btCreate.Location = new System.Drawing.Point(0, 0);
            this.btCreate.Name = "btCreate";
            this.btCreate.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btCreate.Size = new System.Drawing.Size(250, 40);
            this.btCreate.TabIndex = 0;
            this.btCreate.Text = "Create";
            this.btCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCreate.UseVisualStyleBackColor = true;
            // 
            // btExtract
            // 
            this.btExtract.Dock = System.Windows.Forms.DockStyle.Top;
            this.btExtract.FlatAppearance.BorderSize = 0;
            this.btExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExtract.ForeColor = System.Drawing.Color.LightGray;
            this.btExtract.Location = new System.Drawing.Point(0, 40);
            this.btExtract.Name = "btExtract";
            this.btExtract.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btExtract.Size = new System.Drawing.Size(250, 40);
            this.btExtract.TabIndex = 1;
            this.btExtract.Text = "Extract";
            this.btExtract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExtract.UseVisualStyleBackColor = true;
            // 
            // btnAboutSubMenu
            // 
            this.btnAboutSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutSubMenu.FlatAppearance.BorderSize = 0;
            this.btnAboutSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutSubMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAboutSubMenu.Location = new System.Drawing.Point(0, 234);
            this.btnAboutSubMenu.Name = "btnAboutSubMenu";
            this.btnAboutSubMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAboutSubMenu.Size = new System.Drawing.Size(250, 45);
            this.btnAboutSubMenu.TabIndex = 3;
            this.btnAboutSubMenu.Text = "About";
            this.btnAboutSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutSubMenu.UseVisualStyleBackColor = true;
            // 
            // panelSubAbout
            // 
            this.panelSubAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubAbout.Controls.Add(this.btnVersion);
            this.panelSubAbout.Controls.Add(this.btnAppInfo);
            this.panelSubAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubAbout.Location = new System.Drawing.Point(0, 279);
            this.panelSubAbout.Name = "panelSubAbout";
            this.panelSubAbout.Size = new System.Drawing.Size(250, 89);
            this.panelSubAbout.TabIndex = 4;
            // 
            // btnVersion
            // 
            this.btnVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVersion.FlatAppearance.BorderSize = 0;
            this.btnVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVersion.ForeColor = System.Drawing.Color.LightGray;
            this.btnVersion.Location = new System.Drawing.Point(0, 40);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVersion.Size = new System.Drawing.Size(250, 40);
            this.btnVersion.TabIndex = 1;
            this.btnVersion.Text = "Version";
            this.btnVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVersion.UseVisualStyleBackColor = true;
            // 
            // btnAppInfo
            // 
            this.btnAppInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppInfo.FlatAppearance.BorderSize = 0;
            this.btnAppInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppInfo.ForeColor = System.Drawing.Color.LightGray;
            this.btnAppInfo.Location = new System.Drawing.Point(0, 0);
            this.btnAppInfo.Name = "btnAppInfo";
            this.btnAppInfo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAppInfo.Size = new System.Drawing.Size(250, 40);
            this.btnAppInfo.TabIndex = 0;
            this.btnAppInfo.Text = "App info";
            this.btnAppInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelArchiveSubMenu.ResumeLayout(false);
            this.panelSubAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubAbout;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnAppInfo;
        private System.Windows.Forms.Button btnAboutSubMenu;
        private System.Windows.Forms.Panel panelArchiveSubMenu;
        private System.Windows.Forms.Button btExtract;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLogo;
    }
}

