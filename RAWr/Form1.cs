using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.Media;
using System.Windows.Media.Imaging;
using System.Drawing;
using FreeImageAPI;

//BIG NOTE, READ THIS

/* When you build this app onna new config, the compiler put a FreeImage.Standard.dll that is only 181Ko
 * That's the wrong DLL. You'll need to give the proper one, given in the repo, or at this location : http://freeimage.sourceforge.net/
 * It's about 6 Mb big, "FreeImage.dll"
 * Careful, take the one corresponding to X86 or X64 !
 * You may need to add again the references to that DLL in Visual Studio
 * */



namespace RAWr
{
    public partial class Form1 : Form
    {
        //Initialize a shit ton of variables
        String inputFolder = "";
        String outputFolder = "";
        String[] directories;
        String currentDirectory = "";
        String currentFile = "";
        String[] files;
        int fileInCurrentDirectory = 0;
        int doneFiles = 0;
        int directoryNumber = 0;
        int doneDirectory = 0;
        bool loaded = false;
        String[] fileTypes = { "dng", "cr2", "nef" , "DNG", "CR2", "NEF", "raw", "RAW" }; //Accepted file format
        //Not in any correlation with freeImage lib, just a choice.

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.Splashrawr; //Display the UwU splash screen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog(); //unnoficial trick to get a proper folder browsing system
            dialog.InitialDirectory = inputFolder;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                inputFolder = dialog.FileName;
                pathLabel.Text = "IN : " + inputFolder + " | OUT : " + outputFolder;
                if (inputFolder != "" && outputFolder != "")
                {
                    directories = System.IO.Directory.GetDirectories(inputFolder);
                    if (directories.Length > 0)
                    {
                        infoLabel.Text = "Reading Raw...";
                        loaded = true;
                        directoryNumber = directories.Length;
                        currentDirectory = directories[0];
                        files = Directory.GetFiles(currentDirectory);
                        fileInCurrentDirectory = files.Length;
                        currentFile = files[0];
                        infoLabel.Text = directories.Length.ToString() + " | " + currentDirectory.Split('\\')[currentDirectory.Split('\\').Length - 1] + " | " + currentFile.Split('\\')[currentFile.Split('\\').Length - 1];
                        //Split paths to print only file names
                        loadImage(currentFile);
                    }
                    else
                    {
                        infoLabel.Text = "Warning : Input directory does not contain folders !";
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)//yes I know, two times the same function. I warned you. It's not production code.
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = outputFolder;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputFolder = dialog.FileName;
                pathLabel.Text = "IN : " + inputFolder + " | OUT : " + outputFolder;
                if (inputFolder != "" && outputFolder != "")
                {
                    directories = System.IO.Directory.GetDirectories(inputFolder);
                    if (directories.Length > 0)
                    {
                        infoLabel.Text = "Reading Raw...";
                        loaded = true;
                        directoryNumber = directories.Length;
                        currentDirectory = directories[0];
                        files = Directory.GetFiles(currentDirectory);
                        fileInCurrentDirectory = files.Length;
                        currentFile = files[0];
                        infoLabel.Text = directories.Length.ToString() + " | " + currentDirectory.Split('\\')[currentDirectory.Split('\\').Length - 1] + " | " + currentFile.Split('\\')[currentFile.Split('\\').Length - 1];
                        loadImage(currentFile);
                    }
                    else
                    {
                        infoLabel.Text = "Warning : Input directory does not contain folders !";
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (loaded)
            {
                if (keyData == (Keys.Right))//Read key, 
                {
                    pathLabel.Text = "Reading Raw...";
                    if (doneFiles < files.Length - 1)
                    {
                        doneFiles++;
                        currentFile = files[doneFiles];
                        loadImage(currentFile);
                    }
                    else if (doneFiles == files.Length - 1 && doneDirectory < directories.Length - 1)
                    {
                        //Directory change
                        doneFiles = 0;
                        doneDirectory++;
                        currentDirectory = directories[doneDirectory];
                        files = Directory.GetFiles(currentDirectory);
                        currentFile = files[0];
                        loadImage(currentFile);
                    }
                    else if (doneFiles == files.Length - 1 && doneDirectory == directories.Length - 1)
                    {
                        //At end of directory, restarting at first
                        doneFiles = 0;
                        doneDirectory = 0;
                        currentDirectory = directories[doneDirectory];
                        files = Directory.GetFiles(currentDirectory);
                        currentFile = files[0];
                        loadImage(currentFile);
                    }
                    infoLabel.Text = directories.Length.ToString() + " | " + currentDirectory.Split('\\')[currentDirectory.Split('\\').Length - 1] + " | " + currentFile.Split('\\')[currentFile.Split('\\').Length - 1];
                }
                else if (keyData == (Keys.Left))//Aaaaaaand we're doing the same.
                {
                    pathLabel.Text = "Reading Raw...";
                    if (doneFiles > 0)
                    {
                        doneFiles--;
                        currentFile = files[doneFiles];
                        loadImage(currentFile);
                    }
                    else if (doneFiles == 0 && doneDirectory > 0)
                    {
                        //Directory change
                        doneDirectory--;
                        currentDirectory = directories[doneDirectory];
                        files = Directory.GetFiles(currentDirectory);
                        doneFiles = files.Length - 1;
                        currentFile = files[files.Length - 1];
                        loadImage(currentFile);
                    }
                    else if (doneFiles == 0 && doneDirectory == 0)
                    {
                        //At end of directory, restarting at first
                        doneDirectory = directories.Length - 1;
                        currentDirectory = directories[directories.Length - 1];
                        files = Directory.GetFiles(currentDirectory);
                        doneFiles = files.Length - 1;
                        currentFile = files[files.Length - 1];
                        loadImage(currentFile);
                    }
                    infoLabel.Text = directories.Length.ToString() + " | " + currentDirectory.Split('\\')[currentDirectory.Split('\\').Length - 1] + " | " + currentFile.Split('\\')[currentFile.Split('\\').Length - 1];
                }
                else if (keyData == (Keys.S))
                {
                    //We copy image to out
                    File.Copy(currentFile, outputFolder + '\\' + currentFile.Split('\\')[currentFile.Split('\\').Length - 1]);
                    //No error check here, careful...
                    buttonCheck.BackColor = Color.Green;
                }
                if (!msg.HWnd.Equals(Handle) &&
                (keyData == Keys.Left || keyData == Keys.Right ||
                 keyData == Keys.Up || keyData == Keys.Down))//Trick to avoid button selection when pressing arrow keys
                    return true;
                return base.ProcessCmdKey(ref msg, keyData);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void loadImage(String path)
        {
            if (EndsWithAny(path, fileTypes))
            {
                FIBITMAP dib = FreeImage.Load(FREE_IMAGE_FORMAT.FIF_RAW, path, FREE_IMAGE_LOAD_FLAGS.DEFAULT); //Load with FreeImage
                if (!dib.IsNull)
                {
                    FIBITMAP conv = FreeImage.ToneMapping(dib, FREE_IMAGE_TMO.FITMO_DRAGO03, 0, 0);//Shitty basic tonemapping to transform it in a colorspace printable
                    //FIBITMAP conv = FreeImage.ConvertTo24Bits(dib);
                    pictureBox1.Image = FreeImage.GetBitmap(conv);
                    FreeImage.Unload(dib);
                    if (File.Exists(outputFolder + '\\' + currentFile.Split('\\')[currentFile.Split('\\').Length - 1]))//Check if file exist and color the square
                    {
                        buttonCheck.BackColor = Color.Green; //Wich is in fact a button, because why not
                    }
                    else
                    {
                        buttonCheck.BackColor = Color.Red;
                    }
                    pathLabel.Text = "RAW loaded";
                }
                else
                {
                    pathLabel.Text = "Error in reading RAW image, check your file";
                    pictureBox1.Image = Properties.Resources.Splashrawr; //Display the UwU splash screen;
                }
            }
            else
            {
                pathLabel.Text = "File is not RAW image";
                pictureBox1.Image = Properties.Resources.Splashrawr; //Display the UwU splash screen;
            }
        }

        private bool EndsWithAny(string s, string[] chars)//Stolen quick function to check if string end with multiple chars
        {
            foreach (string c in chars)
            {
                if (s.EndsWith(c.ToString()))
                    return true;
            }
            return false;
        }

        Bitmap BitmapFromSource(BitmapSource bitmapsource)//Unused, might use later... or not...
        {
            Bitmap bitmap;
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapsource));
                enc.Save(outStream);
                bitmap = new Bitmap(outStream);
            }
            return bitmap;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Empty void button, because that's why.
        }
    }
}
