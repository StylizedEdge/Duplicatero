using System;
using System.Diagnostics;

///By stylized Edge (Kims Ferdynend)*
///https://www.artstation.com/stylizededge/
///https://github.com/StylizedEdge 


namespace Duplicatero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string FilePath = "";
        string FileFullPath = "";

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = true;
                openFileDialog.FileName = "GEt file to duplicate";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = Path.GetFileName(openFileDialog.FileName);
                    FileFullPath = Path.GetDirectoryName(openFileDialog.FileName);
                    fileName.Text = FilePath;
                }
                else
                {
                    return;
                }
            }
        }

        private void PutInFolderCheck_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMessage();
        }

        private void UpdateMessage()
        {
            if (PutInFolderCheck.Checked)
            {
                FinalMessage.Text = FilePath + " will be placed in \n " + Path.Combine(FileFullPath, Path.GetFileNameWithoutExtension(FilePath)) + "  " + duplicatesAmount.Text + " of Times";
            }
            else
            {
                FinalMessage.Text = FilePath + " will be placed in \n " + FileFullPath + "  " + duplicatesAmount.Text + " of Times";
            }
        }

        private void duplicatesAmount_TextChanged(object sender, EventArgs e)
        {
            UpdateMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //Do
                for (float i = 0; i < float.Parse(duplicatesAmount.Text); i++)
                {
                    CopyFile(Path.Combine(FileFullPath, FilePath), FileFullPath, FilePath, separator.Text, PutInFolderCheck.Checked, i + 1,opendestination.Checked,duplicatesAmount.Text);
                }
            }
            else if(result == DialogResult.Cancel)
            {
                //DOnt
                MessageBox.Show("Oparation canceled");
            }
        }



        public static void CopyFile(string sourceFilePath, string directory,string fileName,string separator, bool PutInFolder, float AmountOfTimes, bool OpenDestination, string duplicatesAmount)
        {
            string fileExtension = Path.GetExtension(fileName);
            // Create the new file name
            string newFileName = $"{Path.GetFileNameWithoutExtension(fileName)}{separator}{AmountOfTimes}{fileExtension}";

            if (PutInFolder)
            {
                string destinationFilePath = Path.Combine(directory, Path.GetFileNameWithoutExtension(fileName), newFileName);

                if (!Directory.Exists(Path.Combine(directory, fileName)))
                {
                    Directory.CreateDirectory(Path.Combine(directory, Path.GetFileNameWithoutExtension(fileName)));
                    File.Copy(sourceFilePath, destinationFilePath,true);

                    if (OpenDestination)
                    {
                        if (AmountOfTimes == float.Parse(duplicatesAmount))
                        {
                            Process.Start(Path.Combine(directory, Path.GetFileNameWithoutExtension(fileName)));
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"directory {destinationFilePath} already exist");
                    File.Copy(sourceFilePath, destinationFilePath,true);

                    if (OpenDestination)
                    {
                        if (AmountOfTimes == float.Parse(duplicatesAmount))
                        {
                            Process.Start(Path.Combine(directory, Path.GetFileNameWithoutExtension(fileName)));
                        }
                    }
                }
            }
            else
            {
                string destinationFilePath = Path.Combine(directory, newFileName);
                File.Copy(sourceFilePath, destinationFilePath,true);
            }

            
        }
    }
}
