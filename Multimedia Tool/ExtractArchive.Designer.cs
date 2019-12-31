namespace Multimedia_Tool
{
    partial class ExtractArchive
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
            this.textBoxSelectedZip = new System.Windows.Forms.TextBox();
            this.btnSelectZip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExtractionDir = new System.Windows.Forms.TextBox();
            this.btnSelectExtrDir = new System.Windows.Forms.Button();
            this.btnExtractArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Zip File:";
            // 
            // textBoxSelectedZip
            // 
            this.textBoxSelectedZip.Location = new System.Drawing.Point(13, 54);
            this.textBoxSelectedZip.Name = "textBoxSelectedZip";
            this.textBoxSelectedZip.Size = new System.Drawing.Size(484, 26);
            this.textBoxSelectedZip.TabIndex = 1;
            // 
            // btnSelectZip
            // 
            this.btnSelectZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectZip.Location = new System.Drawing.Point(17, 86);
            this.btnSelectZip.Name = "btnSelectZip";
            this.btnSelectZip.Size = new System.Drawing.Size(127, 26);
            this.btnSelectZip.TabIndex = 2;
            this.btnSelectZip.Text = "Select Zip file";
            this.btnSelectZip.UseVisualStyleBackColor = true;
            this.btnSelectZip.Click += new System.EventHandler(this.btnSelectZip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extraction directory:";
            // 
            // textBoxExtractionDir
            // 
            this.textBoxExtractionDir.Location = new System.Drawing.Point(17, 176);
            this.textBoxExtractionDir.Name = "textBoxExtractionDir";
            this.textBoxExtractionDir.Size = new System.Drawing.Size(484, 26);
            this.textBoxExtractionDir.TabIndex = 4;
            // 
            // btnSelectExtrDir
            // 
            this.btnSelectExtrDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectExtrDir.Location = new System.Drawing.Point(21, 208);
            this.btnSelectExtrDir.Name = "btnSelectExtrDir";
            this.btnSelectExtrDir.Size = new System.Drawing.Size(185, 26);
            this.btnSelectExtrDir.TabIndex = 5;
            this.btnSelectExtrDir.Text = "Select Extract directory";
            this.btnSelectExtrDir.UseVisualStyleBackColor = true;
            this.btnSelectExtrDir.Click += new System.EventHandler(this.btnSelectExtrDir_Click);
            // 
            // btnExtractArchive
            // 
            this.btnExtractArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtractArchive.Location = new System.Drawing.Point(518, 327);
            this.btnExtractArchive.Name = "btnExtractArchive";
            this.btnExtractArchive.Size = new System.Drawing.Size(138, 53);
            this.btnExtractArchive.TabIndex = 6;
            this.btnExtractArchive.Text = "Extract Archive";
            this.btnExtractArchive.UseVisualStyleBackColor = true;
            this.btnExtractArchive.Click += new System.EventHandler(this.btnExtractArchive_Click);
            // 
            // ExtractArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.btnExtractArchive);
            this.Controls.Add(this.btnSelectExtrDir);
            this.Controls.Add(this.textBoxExtractionDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectZip);
            this.Controls.Add(this.textBoxSelectedZip);
            this.Controls.Add(this.label1);
            this.Name = "ExtractArchive";
            this.Text = "ExtractArchive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSelectedZip;
        private System.Windows.Forms.Button btnSelectZip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExtractionDir;
        private System.Windows.Forms.Button btnSelectExtrDir;
        private System.Windows.Forms.Button btnExtractArchive;
    }
}