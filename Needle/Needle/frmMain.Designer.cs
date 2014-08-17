namespace Needle
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimiseToSystemTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTargetProcess = new System.Windows.Forms.GroupBox();
            this.grpDLLInfo = new System.Windows.Forms.GroupBox();
            this.btnInject = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFindDLL = new System.Windows.Forms.Button();
            this.btnProcessInfo = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.mainMenu.SuspendLayout();
            this.grpTargetProcess.SuspendLayout();
            this.grpDLLInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(335, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimiseToSystemTrayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // minimiseToSystemTrayToolStripMenuItem
            // 
            this.minimiseToSystemTrayToolStripMenuItem.Name = "minimiseToSystemTrayToolStripMenuItem";
            this.minimiseToSystemTrayToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.minimiseToSystemTrayToolStripMenuItem.Text = "Minimise To System Tray";
            // 
            // grpTargetProcess
            // 
            this.grpTargetProcess.Controls.Add(this.btnProcessInfo);
            this.grpTargetProcess.Controls.Add(this.comboBox2);
            this.grpTargetProcess.Location = new System.Drawing.Point(12, 27);
            this.grpTargetProcess.Name = "grpTargetProcess";
            this.grpTargetProcess.Size = new System.Drawing.Size(314, 112);
            this.grpTargetProcess.TabIndex = 1;
            this.grpTargetProcess.TabStop = false;
            this.grpTargetProcess.Text = "Target Process";
            // 
            // grpDLLInfo
            // 
            this.grpDLLInfo.Controls.Add(this.btnFindDLL);
            this.grpDLLInfo.Controls.Add(this.comboBox1);
            this.grpDLLInfo.Location = new System.Drawing.Point(12, 142);
            this.grpDLLInfo.Name = "grpDLLInfo";
            this.grpDLLInfo.Size = new System.Drawing.Size(314, 94);
            this.grpDLLInfo.TabIndex = 2;
            this.grpDLLInfo.TabStop = false;
            this.grpDLLInfo.Text = "DLL To Inject";
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(167, 269);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(75, 23);
            this.btnInject.TabIndex = 3;
            this.btnInject.Text = "Inject (+)";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(248, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(85, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnFindDLL
            // 
            this.btnFindDLL.Location = new System.Drawing.Point(276, 23);
            this.btnFindDLL.Name = "btnFindDLL";
            this.btnFindDLL.Size = new System.Drawing.Size(29, 23);
            this.btnFindDLL.TabIndex = 1;
            this.btnFindDLL.Text = "...";
            this.btnFindDLL.UseVisualStyleBackColor = true;
            // 
            // btnProcessInfo
            // 
            this.btnProcessInfo.Location = new System.Drawing.Point(276, 19);
            this.btnProcessInfo.Name = "btnProcessInfo";
            this.btnProcessInfo.Size = new System.Drawing.Size(29, 23);
            this.btnProcessInfo.TabIndex = 3;
            this.btnProcessInfo.Text = "...";
            this.btnProcessInfo.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 13;
            this.comboBox2.Location = new System.Drawing.Point(85, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 298);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.grpDLLInfo);
            this.Controls.Add(this.grpTargetProcess);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "Needle";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.grpTargetProcess.ResumeLayout(false);
            this.grpDLLInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimiseToSystemTrayToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpTargetProcess;
        private System.Windows.Forms.GroupBox grpDLLInfo;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFindDLL;
        private System.Windows.Forms.Button btnProcessInfo;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

