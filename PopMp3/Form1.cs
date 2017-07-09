using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopMp3
{
    public partial class Form1 : Form
    {
        string rootPath;
        string saveDir = Directory.GetCurrentDirectory() + "\\savefile";
        

        public Form1()
        {
           
            DirectoryInfo fi = new DirectoryInfo(saveDir);
            if (!(fi.Exists))
            {
                fi.Create();
            }

            InitializeComponent();
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath.Length == 0) return;
            rootPath = fbd.SelectedPath;
            MessageBox.Show("선택 경로: "+rootPath);
            
            fbd.Dispose();
            string[] countStr = Directory.GetDirectories(rootPath);
            
        }

        private void btnRunLogic_Click(object sender, EventArgs e)
        {
            
            sreachFile(rootPath);
            string[] dirPath = Directory.GetDirectories(rootPath);
            foreach(var path in dirPath)
            {
                sreachFile(path);
            }
            writeTxtBox("done!");
        }

        private void sreachFile(string path) 
        {
            string[] mp3Files= { "\0" };
            string[] files = Directory.GetFiles(path);
            foreach(var fPath in files)
            {
                if (Path.GetExtension(fPath).Equals(".mp3"))
                {
                    using (var f = File.Open(fPath, FileMode.Open, FileAccess.Read))
                    {
                        string fName = Path.GetFileName(fPath);
                        byte[] fByte = new byte[(int)f.Length];
                        f.Read(fByte, 0, (int)f.Length);
                        FileStream cf = File.OpenWrite(saveDir+"\\"+fName);
                        cf.Write(fByte, 0, (int)f.Length);
                        cf.Close();

                        writeTxtBox(fName);
                    }
                }
                else
                    continue;
            }

            
        }

        private void writeTxtBox(string txt)
        {   
            txtDirList.Text += txt+Environment.NewLine;
        }
    

    }
}
