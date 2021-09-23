using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.tbFolderPath.Text = @"D:\Release";
            this.tbExt.Text = ".pdb";
            this.tbContain.Text = "Upgrade|BouncyCastle.Crypto|ICSharpCode.SharpZipLib";
            this.tbName.Text = "NPOI.OOXML.dll|NPOI.OpenXml4Net.dll|NPOI.OpenXmlFormats.dll";
            this.tbDelForder.Text = "app.publish";
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
        }
        /// <summary>
        /// 删除文件夹名
        /// </summary>
        /// <param name="strPath"></param>
        private void DelFolderName(string strPath)
        {
            List<string> lstFolder = this.tbDelForder.Text.Split('|').ToList();
            foreach (string folderPath in Directory.GetDirectories(strPath))
            {
                if (Directory.Exists(folderPath))
                {
                    int index = folderPath.LastIndexOf('\\');
                    string folderName = folderPath.Substring(index + 1, folderPath.Length - index - 1);
                    if (lstFolder.Contains(folderName))
                        Directory.Delete(folderPath,true);
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

    }
}
