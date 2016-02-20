namespace Compressionator_JayTsai_113719
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
            this.folderPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PathText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(452, 41);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(75, 23);
            this.folderPath.TabIndex = 1;
            this.folderPath.Text = "Browse";
            this.folderPath.UseVisualStyleBackColor = true;
            this.folderPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(114, 43);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(332, 20);
            this.PathText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 589);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.folderPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox PathText;
    }
}

