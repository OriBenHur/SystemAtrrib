using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace SystemAtrrib
{
    public partial class SystemAtrrib : Form
    {
        public SystemAtrrib()
        {
            InitializeComponent();
        }

        public void Hidden(string Hidden, int num,string ShowSuperHidden,int num2)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
            key.SetValue(Hidden, num);
            key.SetValue(ShowSuperHidden, num2);
            SendKeys.Send("{F5}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //IFileDialog fg = new IFileDialog();
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = true;
            SendKeys.Send("^ ");
            Hidden("Hidden", 2, "ShowSuperHidden", 0);
            
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string ver in file.FileNames)
                {
                    FileAttributes attributes = File.GetAttributes(ver);
                    File.SetAttributes(ver, File.GetAttributes(ver) | FileAttributes.Hidden);
                    File.SetAttributes(ver, File.GetAttributes(ver) | FileAttributes.System);
                    MessageBox.Show(Path.GetFileName(ver) + " is now hidden");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = true;
            SendKeys.Send("^ ");
            Hidden("Hidden", 1, "ShowSuperHidden", 1);
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {

                foreach (string ver in file.FileNames)
                {
                    FileAttributes attributes = File.GetAttributes(ver);
                    File.SetAttributes(ver, FileAttributes.Normal);
                    MessageBox.Show(Path.GetFileName(ver) + " is now a normal file");
                }
                SendKeys.Send("^ ");
                Hidden("Hidden", 2, "ShowSuperHidden", 0);
                
            }
            else
            {
                SendKeys.Send("^ ");
                Hidden("Hidden", 2, "ShowSuperHidden", 0);
                
            }
        }

        private void SystemAtrrib_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendKeys.Send("^ ");
            Hidden("Hidden", 2, "ShowSuperHidden", 0);
            
        }

        private void SysFolder_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^ ");
            Hidden("Hidden", 2, "ShowSuperHidden", 0);
            FolderSelectDialog folder = new FolderSelectDialog();
            folder.InitialDirectory = "C:\\";
            bool result = folder.ShowDialog();
            if (result)
            {
                MessageBox.Show(Path.GetFileName(folder.FileName) + " is now hidden");
                FileAttributes attributes = File.GetAttributes(folder.FileName);
                File.SetAttributes(folder.FileName, File.GetAttributes(folder.FileName) | FileAttributes.Hidden);
                File.SetAttributes(folder.FileName, File.GetAttributes(folder.FileName) | FileAttributes.System);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^ ");
            Hidden("Hidden", 1, "ShowSuperHidden", 1);
            
            FolderSelectDialog folder = new FolderSelectDialog();
            folder.InitialDirectory = "C:\\";
            bool result = folder.ShowDialog();
            if (result)
            {
                MessageBox.Show(Path.GetFileName(folder.FileName) + " is now normal");
                FileAttributes attributes = File.GetAttributes(folder.FileName);
                File.SetAttributes(folder.FileName, FileAttributes.Normal);
                SendKeys.Send("^ ");
                Hidden("Hidden", 2, "ShowSuperHidden", 0);

            }
            else
            {
                SendKeys.Send("^ ");
                Hidden("Hidden", 2, "ShowSuperHidden", 0);
                
            }
        }
    }
}
