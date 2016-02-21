using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Compressionator_JayTsai_113719
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.PathText1.Text = @"C:\Users\TheFantastic\Desktop\Game Tools & Pipeline\session7\Compressionator\Pictures";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.PathText1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            if(ExtBox.Text != "")
            {
                if (PathText2.Text == "")
                {
                    PathText2.Text = PathText1.Text + "." + ExtBox.Text;
                }
                ZipFile.CreateFromDirectory(PathText1.Text, PathText2.Text);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please input a Zip extension.");
            }

        }
        private void folderPath2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.PathText2.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void folderPath3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.PathText3.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void folderPath4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.PathText4.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            if (PathText3.Text == "")
            {
                PathText3.Text = PathText2.Text;
            }
            if (PathText4.Text == "")
            {
                PathText4.Text = Path.GetFullPath(Path.Combine(PathText1.Text, @"..\")); ;
            }
            ZipFile.ExtractToDirectory(PathText3.Text, PathText4.Text);
            
        }

       


    }
}
