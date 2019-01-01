namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btTEST = new System.Windows.Forms.Button();
            this.ckIsForBack = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSelectAFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btTestBlueWayITF = new System.Windows.Forms.Button();
            this.buttonTestAssembly = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btTEST
            // 
            this.btTEST.Location = new System.Drawing.Point(345, 93);
            this.btTEST.Name = "btTEST";
            this.btTEST.Size = new System.Drawing.Size(75, 23);
            this.btTEST.TabIndex = 0;
            this.btTEST.Text = "测试";
            this.btTEST.UseVisualStyleBackColor = true;
            this.btTEST.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckIsForBack
            // 
            this.ckIsForBack.AutoSize = true;
            this.ckIsForBack.Checked = true;
            this.ckIsForBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckIsForBack.Location = new System.Drawing.Point(213, 100);
            this.ckIsForBack.Name = "ckIsForBack";
            this.ckIsForBack.Size = new System.Drawing.Size(126, 16);
            this.ckIsForBack.TabIndex = 1;
            this.ckIsForBack.Text = "当前文件为BAK文件";
            this.ckIsForBack.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "文件路径";
            // 
            // btSelectAFile
            // 
            this.btSelectAFile.Location = new System.Drawing.Point(397, 67);
            this.btSelectAFile.Name = "btSelectAFile";
            this.btSelectAFile.Size = new System.Drawing.Size(75, 23);
            this.btSelectAFile.TabIndex = 4;
            this.btSelectAFile.Text = "挑选文件";
            this.btSelectAFile.UseVisualStyleBackColor = true;
            this.btSelectAFile.Click += new System.EventHandler(this.btSelectAFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "FujiLogFile|*.dbl";
            // 
            // btTestBlueWayITF
            // 
            this.btTestBlueWayITF.Location = new System.Drawing.Point(118, 138);
            this.btTestBlueWayITF.Name = "btTestBlueWayITF";
            this.btTestBlueWayITF.Size = new System.Drawing.Size(273, 55);
            this.btTestBlueWayITF.TabIndex = 5;
            this.btTestBlueWayITF.Text = "测试蓝微接口";
            this.btTestBlueWayITF.UseVisualStyleBackColor = true;
            this.btTestBlueWayITF.Click += new System.EventHandler(this.btTestBlueWayITF_Click);
            // 
            // buttonTestAssembly
            // 
            this.buttonTestAssembly.Location = new System.Drawing.Point(118, 199);
            this.buttonTestAssembly.Name = "buttonTestAssembly";
            this.buttonTestAssembly.Size = new System.Drawing.Size(273, 55);
            this.buttonTestAssembly.TabIndex = 6;
            this.buttonTestAssembly.Text = "测试蓝微组装";
            this.buttonTestAssembly.UseVisualStyleBackColor = true;
            this.buttonTestAssembly.Click += new System.EventHandler(this.buttonTestAssembly_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Test DAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTestAssembly);
            this.Controls.Add(this.btTestBlueWayITF);
            this.Controls.Add(this.btSelectAFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ckIsForBack);
            this.Controls.Add(this.btTEST);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btTEST;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ckIsForBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelectAFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btTestBlueWayITF;
        private System.Windows.Forms.Button buttonTestAssembly;
        private System.Windows.Forms.Button button1;
    }
}

