using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;


namespace ComperssionatorConsole_JayTsai_113719
{
    static class Program
    {
        [STAThread]
        static void Main( string[] args )
        {
            StreamWriter log;

            if (!File.Exists("logfile.txt"))
            {

                log = new StreamWriter("logfile.txt");

            }

            else
            {

                log = File.AppendText("logfile.txt");

            }

            

            string yn;
            Console.WriteLine( "Do you want use GUI? y/n" );
            yn = Console.ReadLine();
            if (yn == "y")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault( false );
                Application.Run( new Form1() );
            }
            else if (yn == "n")
            {
                string yn0;
                string yn1;
                string yn2;
                string yn3;
                string yn4;
                string startpath = @"C:\Users\TheFantastic\Desktop\Game Tools & Pipeline\session7\Compressionator\Pictures";
                string zipPath;
                string addPath;
                string extractpath;
                string ext = .zip;
                string filename;
                string FilterBox;
                string loggingfile;
                string error = "on";
                string verbose = "off";


                Console.WriteLine("Do you want log file? y/n");
                loggingfile = Console.ReadLine();
                if (loggingfile == "y")
                {
                    Console.WriteLine("Do you want to turn on or off error logging?");
                    error = Console.ReadLine();
                    Console.WriteLine("Do you want to turn on or off verbose logging?");
                    verbose = Console.ReadLine();
                }

                
                

                DirectoryInfo directorySelected;
                Console.WriteLine("Do you want to Compress a file? y/n");
                yn0 = Console.ReadLine();
                if(yn0 == "y")
                {
                    
                    Console.WriteLine("Input the full path of what you want to compress");
                    startpath = Console.ReadLine();
                    while(!Path.IsPathRooted(startpath))
                    {
                        Console.WriteLine("Not a Path");
                        log.WriteLine("Not a Path");
                        Console.WriteLine("Input the full path of what you want to compress");
                        startpath = Console.ReadLine();
                    }
                    Console.WriteLine("What folder do you want to compress it to(Put full path to the folder)? default is the folder where the file/folder is in ex: C:\\");
                    zipPath = Console.ReadLine();
                    if(zipPath == "default")
                    {
                        zipPath = Path.GetFullPath(Path.Combine( startpath, @"..\"));
                    }
                    while(!Path.IsPathRooted(startpath))
                    {
                        if (error == "on")
                        {
                            Console.WriteLine("Not a Path");
                            log.WriteLine("Not a Path");
                        }
                        Console.WriteLine("What folder do you want to compress it to(Put full path to the folder)? default is the folder where the file/folder is in ex: C:\\");
                        zipPath = Console.ReadLine();
                    }
                    filename = Path.GetFileName(startpath);
                    Console.WriteLine("What Ext? zip or gz?");
                    ext = Console.ReadLine();
                    Console.WriteLine("Do you want to filter out ext?y/n");
                    yn1 = Console.ReadLine();
                    if (yn1 == "y")
                    {
                        Console.WriteLine("What ext you want to filter out?");
                        FilterBox = "." + Console.ReadLine();
                    }
                    else
                    {
                        FilterBox = ".zip";
                    }
                    
                    if(ext == "zip")
                    {
                        if (yn1 == "y")
                        {
                            directorySelected = new DirectoryInfo(startpath);
                            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
                            {
                                using (FileStream originalFileStream = fileToCompress.OpenRead())
                                {
                                    if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden && fileToCompress.Extension != FilterBox)
                                    {
                                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ext))
                                        {
                                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                                            {
                                                originalFileStream.CopyTo(compressionStream);
                                            }
                                        }
                                        FileInfo info = new FileInfo(zipPath + "\\" + fileToCompress.Name + ext);

                                    }
                                }
                            }
                        }
                        else
                        {
                            zipPath = zipPath + filename + ext;

                            if (!File.Exists(zipPath))
                            {
                                ZipFile.CreateFromDirectory(startpath, zipPath);
                            }
                            else
                            {
                                if (error == "on")
                                {
                                    Console.WriteLine("File Already Existed");
                                    log.WriteLine("File Already Existed");
                                }
                            }
                        }
                    }
                    else if (ext == "gz")
                    {
                        if (yn1 == "y")
                        {
                            directorySelected = new DirectoryInfo(startpath);
                            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
                            {
                                using (FileStream originalFileStream = fileToCompress.OpenRead())
                                {
                                    if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden && fileToCompress.Extension != FilterBox)
                                    {
                                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ext))
                                        {
                                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                                            {
                                                originalFileStream.CopyTo(compressionStream);
                                            }
                                        }
                                        FileInfo info = new FileInfo(zipPath + "\\" + fileToCompress.Name + ext);

                                    }
                                }
                            }
                        }
                        else
                        {
                            zipPath = zipPath + filename + ext;

                            if (!File.Exists(zipPath))
                            {
                                ZipFile.CreateFromDirectory(startpath, zipPath);
                            }
                            else
                            {
                                if (error == "on")
                                {
                                    Console.WriteLine("File Already Existed");
                                    log.WriteLine("File Already Existed");
                                }
                                
                            }
                        }
                    }
                    if (verbose == "on")
                    {
                        Console.WriteLine("Folder/File Compressed");
                        log.WriteLine("Folder/File Compressed");
                    }
                        
                }
                Console.WriteLine("Do you want to Extract zip? y/n");
                yn2 = Console.ReadLine();
                if(yn2 == "y")
                {
                    Console.WriteLine("Input the full path of the zip you want to extract? ex: C:\asfdas.zip");
                    zipPath = Console.ReadLine();
                    while(!Path.IsPathRooted(startpath))
                    {
                        if (error == "on")
                        {
                            Console.WriteLine("Not a Path");
                            log.WriteLine("Not a Path");
                        }
                        Console.WriteLine("Input the full path of the zip you want to extract? ex: C:\asfdas.zip");
                        zipPath = Console.ReadLine();
                    }
                    Console.WriteLine("Where do you want to extract it to(Put full path to the folder)? default is the folder where the file/folder is in ex: C:\\");
                    extractpath = Console.ReadLine();
                    if (extractpath == "default")
                    {
                        extractpath = Path.GetFullPath(Path.Combine(zipPath, @"..\"));
                    }
                    while(!Path.IsPathRooted(startpath))
                    {
                        if (error == "on")
                        {
                            Console.WriteLine("Not a Path");
                            log.WriteLine("Not a Path");
                        }
                        Console.WriteLine("Where do you want to extract it to(Put full path to the folder)? default is the folder where the file/folder is in ex: C:\\");
                        extractpath = Console.ReadLine();
                    }
                    ZipFile.ExtractToDirectory(zipPath, extractpath);
                    if (verbose == "on")
                    {
                        Console.WriteLine("Zip Extracted");
                        log.WriteLine("Zip Extracted");
                    }
                }
                
                Console.WriteLine("Do you want to add things to zip? y/n");
                yn3 = Console.ReadLine();
                if(yn3 == "y")
                {
                    Console.WriteLine("Input the full path of the zip you want to update? ex: C:\asfdas.zip");
                    zipPath = Console.ReadLine();
                    while(!Path.IsPathRooted(startpath))
                    {
                        if (error == "on")
                        {
                            Console.WriteLine("Not a Path");
                            log.WriteLine("Not a Path");
                        }
                        Console.WriteLine("Input the full path of the zip you want to update? ex: C:\asfdas.zip");
                        zipPath = Console.ReadLine();
                    }
                    Console.WriteLine("Input the full path of the item add ex: C:\asfdas.txt");
                    addPath = Console.ReadLine();
                    while(!Path.IsPathRooted(startpath))
                    {
                        if (error == "on")
                        {
                            Console.WriteLine("Not a Path");
                            log.WriteLine("Not a Path");
                        }
                        Console.WriteLine("Input the full path of the item add ex: C:\asfdas.txt");
                        addPath = Console.ReadLine();
                    }
                    using (ZipArchive modFile = ZipFile.Open(zipPath, ZipArchiveMode.Update))
                    {
                        modFile.CreateEntryFromFile(zipPath, addPath);
                    }
                    if (verbose == "on")
                    {
                        Console.WriteLine("Folder/File added");
                        log.WriteLine("Folder/File added");
                    }
                }
                Console.WriteLine("Do you want to delete certain extension from zip? y/n");
                yn4 = Console.ReadLine();
                if (yn4 == "y")
                {
                    Console.WriteLine("Input the full path of the zip you want to update? ex: C:\asfdas.zip");
                    zipPath = Console.ReadLine();
                    while(!Path.IsPathRooted(startpath))
                    {
                        if (error == "on")
                        {
                            Console.WriteLine("Not a Path");
                            log.WriteLine("Not a Path");
                        }
                        Console.WriteLine("Input the full path of the zip you want to update? ex: C:\asfdas.zip");
                        zipPath = Console.ReadLine();
                    }
                    Console.WriteLine("What ext you want to filter out?");
                    FilterBox = "." + Console.ReadLine();
                    
                    string ext2;

                    using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
                    {
                        int i = 0;
                        while (i < archive.Entries.Count)
                        {
                            ext2 = Path.GetExtension(archive.Entries[i].Name);
                            if (ext2 == FilterBox)
                            {
                                archive.Entries[i].Delete();
                            }
                            else
                            {
                                i++;
                            }
                        }

                    }
                    if (verbose == "on")
                    {
                        Console.WriteLine("Folder/File added");
                        log.WriteLine("Folder/File added");
                    }
                }
                if (loggingfile == "y")
                {
                    log.Close();
                }
            }
            
        }
    }
}
