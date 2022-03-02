using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelFile
{
    public partial class frmDelFile : Form
    {
        public frmDelFile()
        {
            InitializeComponent();            
        }

        private void frmDelFile_Load(object sender, EventArgs e)
        {
            InitValue();
        }
        /// <summary>
        /// 初始化值
        /// </summary>
        private void InitValue()
        {
            this.cbModel.Items.Add("Q1600");
            this.cbModel.Items.Add("Q3200");
            this.cbModel.SelectedIndex = 0;

            this.tbFolderPath.Text = @"D:\桌面文档\PCR打包\打包upgrade\Release";
            this.tbDelForder.Text = "All";
            this.tbExt.Text = ".pdb";
            this.tbContain.Text = "BG1600.Upgrade|BouncyCastle.Crypto|ICSharpCode.SharpZipLib";
            //this.tbName.Text = "NPOI.OOXML.dll|NPOI.OpenXml4Net.dll|NPOI.OpenXmlFormats.dll";
            this.tbName.Text = "BG1600.Firmware.Upgrade.exe.config|BG1600.Firmware.Upgrade.pdb";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (folderDialogDel.ShowDialog() == DialogResult.OK)
            {
                this.tbFolderPath.Text = folderDialogDel.SelectedPath;
            }
        }
        private void btnDelFolder_Click(object sender, EventArgs e)
        {
            string strFolderPath = this.tbFolderPath.Text.Trim();
            if (Directory.Exists(strFolderPath))
                DelFolderName(strFolderPath);
        }
        private void btnDelExt_Click(object sender, EventArgs e)
        {
            string strFolderPath = this.tbFolderPath.Text.Trim();
            if (Directory.Exists(strFolderPath))
                DelExt(strFolderPath);
        }

        private void btnDelContain_Click(object sender, EventArgs e)
        {
            string strFolderPath = this.tbFolderPath.Text.Trim();
            if (Directory.Exists(strFolderPath))
                DelContain(strFolderPath);
        }

        private void btnDelName_Click(object sender, EventArgs e)
        {
            string strFolderPath = this.tbFolderPath.Text.Trim();
            if (Directory.Exists(strFolderPath))
                DelName(strFolderPath);
        }

        private void btnAllExecute_Click(object sender, EventArgs e)
        {
            string strFolderPath = this.tbFolderPath.Text.Trim();
            if (Directory.Exists(strFolderPath))
            {
                DelFolderName(strFolderPath);
                DelExt(strFolderPath);
                DelName(strFolderPath);
                DelContain(strFolderPath);
            }
            Clipboard.SetText(strFolderPath);
            this.lbDelStatus.Text = "删除成功";
            btnStart_Click(sender, e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName("WindowsFormsApp11").ToList().Count > 0)
            {
                MessageBox.Show("打包程序已经开始运行！");
            }
            else
            {
                string baseDir = @"D:\桌面文档\PCR打包\打包upgrade\PCR打包程序";
                Process startProc = new Process();
                startProc.StartInfo.FileName = System.IO.Path.Combine(baseDir, "Bg1600UpgradeFileCreate.exe");  //就是你要打开的文件的详细路径
                startProc.StartInfo.UseShellExecute = true;
                startProc.StartInfo.WorkingDirectory = baseDir; //就是如APGIS.Tools.exe 执行文件是在那个文件夹下。
                try
                {
                    startProc.Start();
                    System.Threading.Thread.Sleep(500);
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    MessageBox.Show("打包程序启动失败！");
                }
            }
        }
        /// <summary>
        /// 删除文件夹名
        /// </summary>
        /// <param name="strPath"></param>
        private void DelFolderName(string strPath)
        {
            string strForder = this.tbDelForder.Text.Trim();
            if (strForder == "All")
            {
                foreach (string folderPath in Directory.GetDirectories(strPath))
                {
                    if (Directory.Exists(folderPath))
                    {
                        Directory.Delete(folderPath, true);
                    }
                }
            }
            else
            {
                List<string> lstFolder = this.tbDelForder.Text.Split('|').ToList();
                foreach (string folderPath in Directory.GetDirectories(strPath))
                {
                    if (Directory.Exists(folderPath))
                    {
                        int index = folderPath.LastIndexOf('\\');
                        string folderName = folderPath.Substring(index + 1, folderPath.Length - index - 1);
                        if (lstFolder.Contains(folderName))
                            Directory.Delete(folderPath, true);
                    }
                }
            }            
        }
        /// <summary>
        /// 删除后缀名
        /// </summary>
        /// <param name="strPath"></param>
        private void DelExt(string strPath)
        {
            string strExt = "";
            List<string> lstExt = this.tbExt.Text.Split('|').ToList();
            foreach (string filePath in Directory.GetFileSystemEntries(strPath))
            {
                if (File.Exists(filePath))
                {
                    strExt = System.IO.Path.GetExtension(filePath);
                    if (lstExt.Contains(strExt))
                        //如果有子文件删除文件
                        File.Delete(filePath);

                }
                else if(Directory.Exists(filePath))
                {
                    //循环递归删除子文件夹
                    DelExt(filePath);
                }
            }
        }
        /// <summary>
        /// 删除包含名
        /// </summary>
        /// <param name="strPath"></param>
        private void DelContain(string strPath)
        {
            List<string> lstContain = this.tbContain.Text.Split('|').ToList();
            foreach (string filePath in Directory.GetFileSystemEntries(strPath))
            {
                if (File.Exists(filePath))
                {
                    for (int i = 0; i < lstContain.Count; i++)
                    {
                        if (filePath.Contains(lstContain[i]))
                        {
                            File.Delete(filePath);
                        }
                    }
                }
                else if (Directory.Exists(filePath))
                {
                    //循环递归删除子文件夹
                    DelContain(filePath);
                }
            }
        }
        /// <summary>
        /// 删除指定名
        /// </summary>
        /// <param name="strPath"></param>
        private void DelName(string strPath)
        {
            string strName;
            List<string> lstName = this.tbName.Text.Split('|').ToList();
            foreach (string filePath in Directory.GetFileSystemEntries(strPath))
            {
                if (File.Exists(filePath))
                {
                    strName = System.IO.Path.GetFileName(filePath);
                    if (lstName.Contains(strName))
                    {
                        File.Delete(filePath);
                    }
                }
                else if (Directory.Exists(filePath))
                {
                    //循环递归删除子文件夹
                    DelName(filePath);
                }
            }
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModel.SelectedIndex == 0)//Q1600
            {
                this.tbContain.Text = "BG1600.Upgrade|BouncyCastle.Crypto|ICSharpCode.SharpZipLib";
                this.tbName.Text = "BG1600.Firmware.Upgrade.exe.config|BG1600.Firmware.Upgrade.pdb";
            }
            else if(cbModel.SelectedIndex == 1)//Q3200
            {
                this.tbContain.Text = "BouncyCastle.Crypto|ICSharpCode.SharpZipLib";
                this.tbName.Text = "Firmware.Upgrade.exe.config|Firmware.Upgrade.pdb|Upgrade.exe";
            }
        }
    }
}
