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

namespace ComperssionatorConsole_JayTsai_113719
{
    
    public partial class Form1 : Form
    {
        string pathZip;
        OpenFileDialog fDialog = new OpenFileDialog();
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
            if(ExtBox.Text == "")
            {
                ExtBox.Text = ".zip";
            }
            
            DirectoryInfo directorySelected;
            if(ExtBox.Text != "")
            {
                if(ExtBox.Text == ".zip")
                {
                    if (FilterBox.Text != "")
                    {
                        if (PathText2.Text == "")
                        {
                            directorySelected = new DirectoryInfo(PathText1.Text);
                            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
                            {
                                using (FileStream originalFileStream = fileToCompress.OpenRead())
                                {
                                    if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden && fileToCompress.Extension != FilterBox.Text)
                                    {
                                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ExtBox.Text))
                                        {
                                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                                            {
                                                originalFileStream.CopyTo(compressionStream);
                                            }
                                        }
                                        FileInfo info = new FileInfo(directorySelected.FullName + "\\" + fileToCompress.Name + ExtBox.Text);
                                        
                                    }
                                }
                            }
                            PathText2.Text = directorySelected.FullName;
                        }
                        else if (PathText2.Text != "")
                        {
                            directorySelected = new DirectoryInfo(PathText1.Text);
                            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
                            {
                                using (FileStream originalFileStream = fileToCompress.OpenRead())
                                {
                                    if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden && fileToCompress.Extension != FilterBox.Text)
                                    {
                                        using (FileStream compressedFileStream = File.Create(PathText2.Text + "\\" + fileToCompress.Name + ExtBox.Text))
                                        {
                                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                                            {
                                                originalFileStream.CopyTo(compressionStream);
                                            }
                                        }
                                        FileInfo info = new FileInfo(PathText2.Text + "\\" + fileToCompress.Name + ExtBox.Text);
                                        
                                    }
                                }
                            }
                        }
                        else if (File.Exists(pathZip))
                        {
                            System.Windows.Forms.MessageBox.Show("File Already Existed");
                        }
                    }
                    else if (PathText2.Text == "")
                    {
                        pathZip = PathText1.Text + ExtBox.Text;
                        PathText2.Text = PathText1.Text;
                        if (!File.Exists(pathZip))
                        {
                            ZipFile.CreateFromDirectory(PathText1.Text, pathZip);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("File Already Existed");
                        }
                    }
                    else
                    {
                        pathZip = PathText2.Text + "\\" + Path.GetFileName(PathText1.Text) + ExtBox.Text;
                        
                        if (!File.Exists(pathZip))
                        {
                            ZipFile.CreateFromDirectory(PathText1.Text, pathZip);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("File Already Existed");
                        }
                    }
                }
                else if(ExtBox.Text == ".gz")
                {
                    
                    if(FilterBox.Text != "")
                    {
                        if (PathText2.Text == "")
                        {
                            directorySelected = new DirectoryInfo(PathText1.Text);
                            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
                            {
                                using (FileStream originalFileStream = fileToCompress.OpenRead())
                                {
                                    if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden && fileToCompress.Extension != FilterBox.Text)
                                    {
                                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ExtBox.Text))
                                        {
                                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                                            {
                                                originalFileStream.CopyTo(compressionStream);
                                            }
                                        }
                                        FileInfo info = new FileInfo(directorySelected.FullName + "\\" + fileToCompress.Name + ExtBox.Text);
                                        
                                    }
                                }
                            }
                            PathText2.Text = directorySelected.FullName;
                        }
                        else if (PathText2.Text != "")
                        {
                            directorySelected = new DirectoryInfo(PathText1.Text);
                            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
                            {
                                using (FileStream originalFileStream = fileToCompress.OpenRead())
                                {
                                    if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden && fileToCompress.Extension != FilterBox.Text)
                                    {
                                        using (FileStream compressedFileStream = File.Create(PathText2.Text + "\\" + Path.GetFileName(PathText1.Text) + ExtBox.Text))
                                        {
                                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                                            {
                                                originalFileStream.CopyTo(compressionStream);
                                            }
                                        }
                                        FileInfo info = new FileInfo(PathText2.Text + "\\" + Path.GetFileName(PathText1.Text) + ExtBox.Text);
                                        
                                    }
                                }
                            }
                        }
                        else if (File.Exists(pathZip))
                        {
                            System.Windows.Forms.MessageBox.Show("File Already Existed");
                        }
                    }
                    else if (PathText2.Text == "")
                    {
                        pathZip = PathText1.Text + ExtBox.Text;
                        PathText2.Text = PathText1.Text;
                        if (!File.Exists(pathZip))
                        {
                            ZipFile.CreateFromDirectory(PathText1.Text, pathZip);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("File Already Existed");
                        }
                    }
                    else
                    {
                        pathZip = PathText2.Text + "\\" + Path.GetFileName(PathText1.Text) + ExtBox.Text;
                        if (!File.Exists(pathZip))
                        {
                            ZipFile.CreateFromDirectory(PathText1.Text, pathZip);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("File Already Existed");
                        }
                    }
                    

                    
                }
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
            DialogResult result = fDialog.ShowDialog();
            if( result == DialogResult.OK ) // Test result.
            {
                this.PathText3.Text = fDialog.FileName;
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
                PathText3.Text = pathZip;
            }
            if (PathText4.Text == "")
            {
                PathText4.Text = Path.GetFullPath(Path.Combine(PathText1.Text, @"..\")); ;
            }
            if (PathText3.Text != "")
                ZipFile.ExtractToDirectory(PathText3.Text, PathText4.Text);
            else
            {
                System.Windows.Forms.MessageBox.Show("Please input what you want to extract.");
            }
            
        }



        private void folderPath5_Click(object sender, EventArgs e)
        {
            DialogResult result = fDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                SourceBox.Text = fDialog.FileName;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using( ZipArchive archive = ZipFile.OpenRead( SourceBox.Text ) )
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    System.Windows.Forms.MessageBox.Show( Path.GetExtension(entry.Name) );
                }
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (ZipArchive modFile = ZipFile.Open(pathZip, ZipArchiveMode.Update))
            {
                if (SourceBox.Text != "" && RenameBox.Text != "")
                {
                    modFile.CreateEntryFromFile(SourceBox.Text, RenameBox.Text);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please input a new name or Source file for rename.");
                }


            }
        }

       


    }
}
