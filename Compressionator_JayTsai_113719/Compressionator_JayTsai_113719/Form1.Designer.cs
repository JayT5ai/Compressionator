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
            this.folderPath1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PathText1 = new System.Windows.Forms.TextBox();
            this.CompressButton = new System.Windows.Forms.Button();
            this.ExtBox = new System.Windows.Forms.ComboBox();
            this.PathText2 = new System.Windows.Forms.TextBox();
            this.folderPath2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PathText4 = new System.Windows.Forms.TextBox();
            this.folderPath4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PathText3 = new System.Windows.Forms.TextBox();
            this.folderPath3 = new System.Windows.Forms.Button();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderPath1
            // 
            this.folderPath1.Location = new System.Drawing.Point(452, 41);
            this.folderPath1.Name = "folderPath1";
            this.folderPath1.Size = new System.Drawing.Size(75, 23);
            this.folderPath1.TabIndex = 1;
            this.folderPath1.Text = "Browse";
            this.folderPath1.UseVisualStyleBackColor = true;
            this.folderPath1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathText1
            // 
            this.PathText1.Location = new System.Drawing.Point(114, 43);
            this.PathText1.Name = "PathText1";
            this.PathText1.Size = new System.Drawing.Size(332, 20);
            this.PathText1.TabIndex = 2;
            // 
            // CompressButton
            // 
            this.CompressButton.Location = new System.Drawing.Point(340, 132);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(75, 23);
            this.CompressButton.TabIndex = 5;
            this.CompressButton.Text = "Compress";
            this.CompressButton.UseVisualStyleBackColor = true;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // ExtBox
            // 
            this.ExtBox.FormattingEnabled = true;
            this.ExtBox.Items.AddRange(new object[] {
            "zip",
            "gzip"});
            this.ExtBox.Location = new System.Drawing.Point(213, 134);
            this.ExtBox.Name = "ExtBox";
            this.ExtBox.Size = new System.Drawing.Size(121, 21);
            this.ExtBox.TabIndex = 6;
            // 
            // PathText2
            // 
            this.PathText2.Location = new System.Drawing.Point(114, 85);
            this.PathText2.Name = "PathText2";
            this.PathText2.Size = new System.Drawing.Size(332, 20);
            this.PathText2.TabIndex = 8;
            // 
            // folderPath2
            // 
            this.folderPath2.Location = new System.Drawing.Point(452, 83);
            this.folderPath2.Name = "folderPath2";
            this.folderPath2.Size = new System.Drawing.Size(75, 23);
            this.folderPath2.TabIndex = 7;
            this.folderPath2.Text = "Browse";
            this.folderPath2.UseVisualStyleBackColor = true;
            this.folderPath2.Click += new System.EventHandler(this.folderPath2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Compress To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Folder or File to Compress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Extension";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Extract To:";
            // 
            // PathText4
            // 
            this.PathText4.Location = new System.Drawing.Point(114, 234);
            this.PathText4.Name = "PathText4";
            this.PathText4.Size = new System.Drawing.Size(332, 20);
            this.PathText4.TabIndex = 13;
            // 
            // folderPath4
            // 
            this.folderPath4.Location = new System.Drawing.Point(452, 232);
            this.folderPath4.Name = "folderPath4";
            this.folderPath4.Size = new System.Drawing.Size(75, 23);
            this.folderPath4.TabIndex = 12;
            this.folderPath4.Text = "Browse";
            this.folderPath4.UseVisualStyleBackColor = true;
            this.folderPath4.Click += new System.EventHandler(this.folderPath4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Folder or File to Extract";
            // 
            // PathText3
            // 
            this.PathText3.Location = new System.Drawing.Point(114, 192);
            this.PathText3.Name = "PathText3";
            this.PathText3.Size = new System.Drawing.Size(332, 20);
            this.PathText3.TabIndex = 16;
            // 
            // folderPath3
            // 
            this.folderPath3.Location = new System.Drawing.Point(452, 190);
            this.folderPath3.Name = "folderPath3";
            this.folderPath3.Size = new System.Drawing.Size(75, 23);
            this.folderPath3.TabIndex = 15;
            this.folderPath3.Text = "Browse";
            this.folderPath3.UseVisualStyleBackColor = true;
            this.folderPath3.Click += new System.EventHandler(this.folderPath3_Click);
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(259, 260);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractButton.TabIndex = 18;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 589);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PathText3);
            this.Controls.Add(this.folderPath3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PathText4);
            this.Controls.Add(this.folderPath4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathText2);
            this.Controls.Add(this.folderPath2);
            this.Controls.Add(this.ExtBox);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.PathText1);
            this.Controls.Add(this.folderPath1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderPath1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox PathText1;
        private System.Windows.Forms.Button CompressButton;
        private System.Windows.Forms.ComboBox ExtBox;
        private System.Windows.Forms.TextBox PathText2;
        private System.Windows.Forms.Button folderPath2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PathText4;
        private System.Windows.Forms.Button folderPath4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PathText3;
        private System.Windows.Forms.Button folderPath3;
        private System.Windows.Forms.Button ExtractButton;
    }
}

