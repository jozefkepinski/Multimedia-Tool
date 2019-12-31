namespace Multimedia_Tool
{
    partial class AddArchive
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
            this.labelSelectedDirectory = new System.Windows.Forms.Label();
            this.labelOutputFIle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCreateArchive = new System.Windows.Forms.Button();
            this.btnSelectDirectoryPath = new System.Windows.Forms.Button();
            this.btnSelectOutputZip = new System.Windows.Forms.Button();
            this.CBCompresiontype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSelectedDirectory
            // 
            this.labelSelectedDirectory.AutoSize = true;
            this.labelSelectedDirectory.Location = new System.Drawing.Point(12, 23);
            this.labelSelectedDirectory.Name = "labelSelectedDirectory";
            this.labelSelectedDirectory.Size = new System.Drawing.Size(212, 20);
            this.labelSelectedDirectory.TabIndex = 0;
            this.labelSelectedDirectory.Text = "Selected directory to archive:";
            // 
            // labelOutputFIle
            // 
            this.labelOutputFIle.AutoSize = true;
            this.labelOutputFIle.Location = new System.Drawing.Point(12, 121);
            this.labelOutputFIle.Name = "labelOutputFIle";
            this.labelOutputFIle.Size = new System.Drawing.Size(129, 20);
            this.labelOutputFIle.TabIndex = 1;
            this.labelOutputFIle.Text = "Output Directory:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(480, 26);
            this.textBox2.TabIndex = 3;
            // 
            // btnCreateArchive
            // 
            this.btnCreateArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateArchive.Location = new System.Drawing.Point(493, 246);
            this.btnCreateArchive.Name = "btnCreateArchive";
            this.btnCreateArchive.Size = new System.Drawing.Size(164, 48);
            this.btnCreateArchive.TabIndex = 4;
            this.btnCreateArchive.Text = "CreateArchive";
            this.btnCreateArchive.UseVisualStyleBackColor = true;
            this.btnCreateArchive.Click += new System.EventHandler(this.btnCreateArchive_Click);
            // 
            // btnSelectDirectoryPath
            // 
            this.btnSelectDirectoryPath.Location = new System.Drawing.Point(16, 79);
            this.btnSelectDirectoryPath.Name = "btnSelectDirectoryPath";
            this.btnSelectDirectoryPath.Size = new System.Drawing.Size(178, 30);
            this.btnSelectDirectoryPath.TabIndex = 5;
            this.btnSelectDirectoryPath.Text = "Select Directory Path";
            this.btnSelectDirectoryPath.UseVisualStyleBackColor = true;
            this.btnSelectDirectoryPath.Click += new System.EventHandler(this.btnSelectDirectoryPath_Click);
            // 
            // btnSelectOutputZip
            // 
            this.btnSelectOutputZip.Location = new System.Drawing.Point(16, 176);
            this.btnSelectOutputZip.Name = "btnSelectOutputZip";
            this.btnSelectOutputZip.Size = new System.Drawing.Size(220, 30);
            this.btnSelectOutputZip.TabIndex = 6;
            this.btnSelectOutputZip.Text = "Select Output Zip File Path";
            this.btnSelectOutputZip.UseVisualStyleBackColor = true;
            this.btnSelectOutputZip.Click += new System.EventHandler(this.btnSelectOutputZip_Click);
            // 
            // CBCompresiontype
            // 
            this.CBCompresiontype.FormattingEnabled = true;
            this.CBCompresiontype.Location = new System.Drawing.Point(16, 246);
            this.CBCompresiontype.Name = "CBCompresiontype";
            this.CBCompresiontype.Size = new System.Drawing.Size(121, 28);
            this.CBCompresiontype.TabIndex = 7;
            this.CBCompresiontype.SelectedValueChanged += new System.EventHandler(this.CBCompresiontype_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Compression level:";
            // 
            // AddArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBCompresiontype);
            this.Controls.Add(this.btnSelectOutputZip);
            this.Controls.Add(this.btnSelectDirectoryPath);
            this.Controls.Add(this.btnCreateArchive);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelOutputFIle);
            this.Controls.Add(this.labelSelectedDirectory);
            this.MinimumSize = new System.Drawing.Size(517, 489);
            this.Name = "AddArchive";
            this.Text = "AddArchive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectedDirectory;
        private System.Windows.Forms.Label labelOutputFIle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCreateArchive;
        private System.Windows.Forms.Button btnSelectDirectoryPath;
        private System.Windows.Forms.Button btnSelectOutputZip;
        private System.Windows.Forms.ComboBox CBCompresiontype;
        private System.Windows.Forms.Label label1;
    }
}