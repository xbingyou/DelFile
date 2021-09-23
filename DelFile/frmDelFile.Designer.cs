﻿
namespace DelFile
{
    partial class frmDelFile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.folderDialogDel = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelExt = new System.Windows.Forms.Button();
            this.lbFolder = new System.Windows.Forms.Label();
            this.tbExt = new System.Windows.Forms.TextBox();
            this.lbExt = new System.Windows.Forms.Label();
            this.lbContain = new System.Windows.Forms.Label();
            this.tbContain = new System.Windows.Forms.TextBox();
            this.btnDelContain = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnDelName = new System.Windows.Forms.Button();
            this.btnAllExecute = new System.Windows.Forms.Button();
            this.lbDelFolder = new System.Windows.Forms.Label();
            this.tbDelForder = new System.Windows.Forms.TextBox();
            this.btnDelFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(102, 12);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(586, 27);
            this.tbFolderPath.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(694, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(94, 29);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "选择文件夹";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelExt
            // 
            this.btnDelExt.Location = new System.Drawing.Point(694, 129);
            this.btnDelExt.Name = "btnDelExt";
            this.btnDelExt.Size = new System.Drawing.Size(94, 29);
            this.btnDelExt.TabIndex = 2;
            this.btnDelExt.Text = "删除后缀名";
            this.btnDelExt.UseVisualStyleBackColor = true;
            this.btnDelExt.Click += new System.EventHandler(this.btnDelExt_Click);
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.Location = new System.Drawing.Point(12, 15);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(69, 20);
            this.lbFolder.TabIndex = 3;
            this.lbFolder.Text = "文件夹：";
            // 
            // tbExt
            // 
            this.tbExt.Location = new System.Drawing.Point(102, 129);
            this.tbExt.Name = "tbExt";
            this.tbExt.Size = new System.Drawing.Size(586, 27);
            this.tbExt.TabIndex = 4;
            // 
            // lbExt
            // 
            this.lbExt.AutoSize = true;
            this.lbExt.Location = new System.Drawing.Point(12, 132);
            this.lbExt.Name = "lbExt";
            this.lbExt.Size = new System.Drawing.Size(69, 20);
            this.lbExt.TabIndex = 5;
            this.lbExt.Text = "后缀名：";
            // 
            // lbContain
            // 
            this.lbContain.AutoSize = true;
            this.lbContain.Location = new System.Drawing.Point(12, 196);
            this.lbContain.Name = "lbContain";
            this.lbContain.Size = new System.Drawing.Size(69, 20);
            this.lbContain.TabIndex = 8;
            this.lbContain.Text = "包含名：";
            // 
            // tbContain
            // 
            this.tbContain.Location = new System.Drawing.Point(102, 193);
            this.tbContain.Name = "tbContain";
            this.tbContain.Size = new System.Drawing.Size(586, 27);
            this.tbContain.TabIndex = 7;
            // 
            // btnDelContain
            // 
            this.btnDelContain.Location = new System.Drawing.Point(694, 193);
            this.btnDelContain.Name = "btnDelContain";
            this.btnDelContain.Size = new System.Drawing.Size(94, 29);
            this.btnDelContain.TabIndex = 6;
            this.btnDelContain.Text = "删除包含名";
            this.btnDelContain.UseVisualStyleBackColor = true;
            this.btnDelContain.Click += new System.EventHandler(this.btnDelContain_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 263);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "指定名：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 260);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(586, 27);
            this.tbName.TabIndex = 10;
            // 
            // btnDelName
            // 
            this.btnDelName.Location = new System.Drawing.Point(694, 260);
            this.btnDelName.Name = "btnDelName";
            this.btnDelName.Size = new System.Drawing.Size(94, 29);
            this.btnDelName.TabIndex = 9;
            this.btnDelName.Text = "删除指定名";
            this.btnDelName.UseVisualStyleBackColor = true;
            this.btnDelName.Click += new System.EventHandler(this.btnDelName_Click);
            // 
            // btnAllExecute
            // 
            this.btnAllExecute.Location = new System.Drawing.Point(694, 334);
            this.btnAllExecute.Name = "btnAllExecute";
            this.btnAllExecute.Size = new System.Drawing.Size(94, 29);
            this.btnAllExecute.TabIndex = 12;
            this.btnAllExecute.Text = "依次删除";
            this.btnAllExecute.UseVisualStyleBackColor = true;
            this.btnAllExecute.Click += new System.EventHandler(this.btnAllExecute_Click);
            // 
            // lbDelFolder
            // 
            this.lbDelFolder.AutoSize = true;
            this.lbDelFolder.Location = new System.Drawing.Point(12, 72);
            this.lbDelFolder.Name = "lbDelFolder";
            this.lbDelFolder.Size = new System.Drawing.Size(84, 20);
            this.lbDelFolder.TabIndex = 15;
            this.lbDelFolder.Text = "文件夹名：";
            // 
            // tbDelForder
            // 
            this.tbDelForder.Location = new System.Drawing.Point(102, 69);
            this.tbDelForder.Name = "tbDelForder";
            this.tbDelForder.Size = new System.Drawing.Size(586, 27);
            this.tbDelForder.TabIndex = 14;
            // 
            // btnDelFolder
            // 
            this.btnDelFolder.Location = new System.Drawing.Point(694, 69);
            this.btnDelFolder.Name = "btnDelFolder";
            this.btnDelFolder.Size = new System.Drawing.Size(94, 29);
            this.btnDelFolder.TabIndex = 13;
            this.btnDelFolder.Text = "删除文件夹";
            this.btnDelFolder.UseVisualStyleBackColor = true;
            this.btnDelFolder.Click += new System.EventHandler(this.btnDelFolder_Click);
            // 
            // frmDelFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDelFolder);
            this.Controls.Add(this.tbDelForder);
            this.Controls.Add(this.btnDelFolder);
            this.Controls.Add(this.btnAllExecute);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnDelName);
            this.Controls.Add(this.lbContain);
            this.Controls.Add(this.tbContain);
            this.Controls.Add(this.btnDelContain);
            this.Controls.Add(this.lbExt);
            this.Controls.Add(this.tbExt);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.btnDelExt);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbFolderPath);
            this.Name = "frmDelFile";
            this.Text = "删除指定文件程序";
            this.Load += new System.EventHandler(this.frmDelFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderDialogDel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelExt;
        private System.Windows.Forms.Label lbFolder;
        private System.Windows.Forms.TextBox tbExt;
        private System.Windows.Forms.Label lbExt;
        private System.Windows.Forms.Label lbContain;
        private System.Windows.Forms.TextBox tbContain;
        private System.Windows.Forms.Button btnDelContain;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnDelName;
        private System.Windows.Forms.Button btnAllExecute;
        private System.Windows.Forms.Label lbDelFolder;
        private System.Windows.Forms.TextBox tbDelForder;
        private System.Windows.Forms.Button btnDelFolder;
    }
}

