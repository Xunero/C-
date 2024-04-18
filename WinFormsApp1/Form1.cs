using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TotalCommanderClone
{
    public partial class Form1 : Form
    {
        private string sourcePath;
        private string destinationPath;
        private Stack<string> sourcePathHistory = new Stack<string>();
        private Stack<string> destinationPathHistory = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
            sourcePath = @"C:\";
            destinationPath = @"D:\";
            RefreshFileList(sourcePath, listViewSource);
            RefreshFileList(destinationPath, listViewDestination);
        }

        private void RefreshFileList(string path, ListView listView)
        {
            listView.Items.Clear();
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                foreach (var item in directory.GetDirectories())
                {
                    ListViewItem listItem = new ListViewItem(item.Name);
                    listItem.SubItems.Add("Folder");
                    listView.Items.Add(listItem);
                }
                foreach (var item in directory.GetFiles())
                {
                    ListViewItem listItem = new ListViewItem(item.Name);
                    listItem.SubItems.Add("File");
                    listView.Items.Add(listItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void listViewSource_DoubleClick(object sender, EventArgs e)
        {
            if (listViewSource.SelectedItems.Count > 0)
            {
                string selectedItem = listViewSource.SelectedItems[0].Text;
                string newPath = Path.Combine(sourcePath, selectedItem);

                try
                {
                    if (Directory.Exists(newPath))
                    {
                        sourcePathHistory.Push(sourcePath); // Zapisujemy aktualn¹ œcie¿kê do historii
                        sourcePath = newPath;
                        RefreshFileList(sourcePath, listViewSource);
                    }
                    else
                    {
                        MessageBox.Show("Selected item is not a folder.");
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access to the selected item is denied.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void listViewDestination_DoubleClick(object sender, EventArgs e)
        {
            if (listViewDestination.SelectedItems.Count > 0)
            {
                string selectedItem = listViewDestination.SelectedItems[0].Text;
                string newPath = Path.Combine(destinationPath, selectedItem);

                try
                {
                    if (Directory.Exists(newPath))
                    {
                        destinationPathHistory.Push(destinationPath); // Zapisujemy aktualn¹ œcie¿kê do historii
                        destinationPath = newPath;
                        RefreshFileList(destinationPath, listViewDestination);
                    }
                    else
                    {
                        MessageBox.Show("Selected item is not a folder.");
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access to the selected item is denied.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (sourcePathHistory.Count > 0)
            {
                sourcePath = sourcePathHistory.Pop(); // Pobieramy poprzedni¹ œcie¿kê z historii
                RefreshFileList(sourcePath, listViewSource);
            }

            if (destinationPathHistory.Count > 0)
            {
                destinationPath = destinationPathHistory.Pop(); // Pobieramy poprzedni¹ œcie¿kê z historii
                RefreshFileList(destinationPath, listViewDestination);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewSource.SelectedItems.Count > 0)
            {
                string selectedItem = listViewSource.SelectedItems[0].Text;
                string sourceFilePath = Path.Combine(sourcePath, selectedItem);

                try
                {
                    if (Directory.Exists(sourceFilePath))
                    {
                        Directory.Delete(sourceFilePath, true);
                        RefreshFileList(sourcePath, listViewSource);
                    }
                    else if (File.Exists(sourceFilePath))
                    {
                        File.Delete(sourceFilePath);
                        RefreshFileList(sourcePath, listViewSource);
                    }
                    else
                    {
                        MessageBox.Show("Selected item not found.");
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access to the selected item is denied.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (listViewSource.SelectedItems.Count > 0)
            {
                string selectedItem = listViewSource.SelectedItems[0].Text;
                string sourceFilePath = Path.Combine(sourcePath, selectedItem);
                string destinationFilePath = Path.Combine(destinationPath, selectedItem);

                if (File.Exists(sourceFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath);
                    RefreshFileList(destinationPath, listViewDestination);
                }
                else
                {
                    MessageBox.Show("Selected item is not a file.");
                }
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (listViewSource.SelectedItems.Count > 0)
            {
                string selectedItem = listViewSource.SelectedItems[0].Text;
                string sourceFilePath = Path.Combine(sourcePath, selectedItem);
                string destinationFilePath = Path.Combine(destinationPath, selectedItem);

                if (File.Exists(sourceFilePath))
                {
                    File.Move(sourceFilePath, destinationFilePath);
                    RefreshFileList(sourcePath, listViewSource);
                    RefreshFileList(destinationPath, listViewDestination);
                }
                else
                {
                    MessageBox.Show("Selected item is not a file.");
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (listViewSource.SelectedItems.Count > 0)
            {
                string selectedItem = listViewSource.SelectedItems[0].Text;
                string sourceFilePath = Path.Combine(sourcePath, selectedItem);

                if (File.Exists(sourceFilePath))
                {
                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new name:", "Rename File", selectedItem);
                    if (!string.IsNullOrEmpty(newName))
                    {
                        string destinationFilePath = Path.Combine(sourcePath, newName);
                        File.Move(sourceFilePath, destinationFilePath);
                        RefreshFileList(sourcePath, listViewSource);
                    }
                }
                else
                {
                    MessageBox.Show("Selected item is not a file.");
                }
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            string newDirectoryName = Microsoft.VisualBasic.Interaction.InputBox("Enter directory name:", "Create Directory");
            if (!string.IsNullOrEmpty(newDirectoryName))
            {
                string newDirectoryPath = Path.Combine(sourcePath, newDirectoryName);
                Directory.CreateDirectory(newDirectoryPath);
                RefreshFileList(sourcePath, listViewSource);
            }
        }

     

        private void btnAttributes_Click(object sender, EventArgs e)
        {
            if (listViewSource.SelectedItems.Count > 0)
            {
                string selectedItem = listViewSource.SelectedItems[0].Text;
                string sourceFilePath = Path.Combine(sourcePath, selectedItem);

                if (File.Exists(sourceFilePath))
                {
                    FileAttributes attributes = File.GetAttributes(sourceFilePath);
                    MessageBox.Show("Attributes: " + attributes.ToString());
                }
                else
                {
                    MessageBox.Show("Selected item is not a file.");
                }
            }
        }

        private void btnDiskInfo_Click(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            string info = "Disk Information:\n";
            foreach (DriveInfo drive in drives)
            {
                info += $"Drive: {drive.Name}\n";
                info += $"Total Size: {drive.TotalSize / (1024 * 1024 * 1024)} GB\n";
                info += $"Free Space: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB\n\n";
            }
            MessageBox.Show(info);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (listViewSource.SelectedItems.Count > 0)
            {
                string selectedItem = listViewSource.SelectedItems[0].Text;
                string sourceFilePath = Path.Combine(sourcePath, selectedItem);

                if (File.Exists(sourceFilePath))
                {
                    if (Path.GetExtension(sourceFilePath).ToLower() == ".txt")
                    {
                        string fileContent = File.ReadAllText(sourceFilePath);
                        MessageBox.Show("File Preview:\n\n" + fileContent, "Text File Preview");
                    }
                    else
                    {
                        MessageBox.Show("Selected file is not a text file.");
                    }
                }
                else
                {
                    MessageBox.Show("Selected item is not a file.");
                }
            }
        }
    }
}