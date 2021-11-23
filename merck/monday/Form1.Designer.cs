namespace monday
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayRunningProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socketsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAFilefolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFiledirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAFilefolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputOutputInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startApsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sockets1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryManagementInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driveInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processManagementToolStripMenuItem,
            this.fileManagementToolStripMenuItem,
            this.inputOutputInformationToolStripMenuItem,
            this.communicationToolStripMenuItem,
            this.memoryManagementInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(963, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processManagementToolStripMenuItem
            // 
            this.processManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAProcessToolStripMenuItem,
            this.displayRunningProcessToolStripMenuItem,
            this.killProcessesToolStripMenuItem,
            this.socketsToolStripMenuItem1});
            this.processManagementToolStripMenuItem.Name = "processManagementToolStripMenuItem";
            this.processManagementToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.processManagementToolStripMenuItem.Text = "process management";
            this.processManagementToolStripMenuItem.Click += new System.EventHandler(this.processManagementToolStripMenuItem_Click);
            // 
            // startAProcessToolStripMenuItem
            // 
            this.startAProcessToolStripMenuItem.Name = "startAProcessToolStripMenuItem";
            this.startAProcessToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.startAProcessToolStripMenuItem.Text = "start a process";
            this.startAProcessToolStripMenuItem.Click += new System.EventHandler(this.startAProcessToolStripMenuItem_Click);
            // 
            // displayRunningProcessToolStripMenuItem
            // 
            this.displayRunningProcessToolStripMenuItem.Name = "displayRunningProcessToolStripMenuItem";
            this.displayRunningProcessToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.displayRunningProcessToolStripMenuItem.Text = "display running process";
            this.displayRunningProcessToolStripMenuItem.Click += new System.EventHandler(this.displayRunningProcessToolStripMenuItem_Click);
            // 
            // killProcessesToolStripMenuItem
            // 
            this.killProcessesToolStripMenuItem.Name = "killProcessesToolStripMenuItem";
            this.killProcessesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.killProcessesToolStripMenuItem.Text = "kill processes";
            this.killProcessesToolStripMenuItem.Click += new System.EventHandler(this.killProcessesToolStripMenuItem_Click);
            // 
            // socketsToolStripMenuItem1
            // 
            this.socketsToolStripMenuItem1.Name = "socketsToolStripMenuItem1";
            this.socketsToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.socketsToolStripMenuItem1.Text = "end";
            this.socketsToolStripMenuItem1.Click += new System.EventHandler(this.socketsToolStripMenuItem1_Click);
            // 
            // fileManagementToolStripMenuItem
            // 
            this.fileManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAFilefolderToolStripMenuItem,
            this.createFiledirectoryToolStripMenuItem,
            this.deleteAFilefolderToolStripMenuItem});
            this.fileManagementToolStripMenuItem.Name = "fileManagementToolStripMenuItem";
            this.fileManagementToolStripMenuItem.Size = new System.Drawing.Size(109, 19);
            this.fileManagementToolStripMenuItem.Text = "file management";
            // 
            // openAFilefolderToolStripMenuItem
            // 
            this.openAFilefolderToolStripMenuItem.Name = "openAFilefolderToolStripMenuItem";
            this.openAFilefolderToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openAFilefolderToolStripMenuItem.Text = "open a file/folder";
            this.openAFilefolderToolStripMenuItem.Click += new System.EventHandler(this.openAFilefolderToolStripMenuItem_Click);
            // 
            // createFiledirectoryToolStripMenuItem
            // 
            this.createFiledirectoryToolStripMenuItem.Name = "createFiledirectoryToolStripMenuItem";
            this.createFiledirectoryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.createFiledirectoryToolStripMenuItem.Text = "create file/directory";
            this.createFiledirectoryToolStripMenuItem.Click += new System.EventHandler(this.createFiledirectoryToolStripMenuItem_Click);
            // 
            // deleteAFilefolderToolStripMenuItem
            // 
            this.deleteAFilefolderToolStripMenuItem.Name = "deleteAFilefolderToolStripMenuItem";
            this.deleteAFilefolderToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteAFilefolderToolStripMenuItem.Text = "delete a file/folder";
            this.deleteAFilefolderToolStripMenuItem.Click += new System.EventHandler(this.deleteAFilefolderToolStripMenuItem_Click);
            // 
            // inputOutputInformationToolStripMenuItem
            // 
            this.inputOutputInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startApsToolStripMenuItem,
            this.systemInfoToolStripMenuItem,
            this.devicesToolStripMenuItem});
            this.inputOutputInformationToolStripMenuItem.Name = "inputOutputInformationToolStripMenuItem";
            this.inputOutputInformationToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
            this.inputOutputInformationToolStripMenuItem.Text = "input output information";
            // 
            // startApsToolStripMenuItem
            // 
            this.startApsToolStripMenuItem.Name = "startApsToolStripMenuItem";
            this.startApsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.startApsToolStripMenuItem.Text = "power options";
            this.startApsToolStripMenuItem.Click += new System.EventHandler(this.startApsToolStripMenuItem_Click);
            // 
            // systemInfoToolStripMenuItem
            // 
            this.systemInfoToolStripMenuItem.Name = "systemInfoToolStripMenuItem";
            this.systemInfoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.systemInfoToolStripMenuItem.Text = "system info";
            this.systemInfoToolStripMenuItem.Click += new System.EventHandler(this.systemInfoToolStripMenuItem_Click);
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.devicesToolStripMenuItem.Text = "devices";
            this.devicesToolStripMenuItem.Click += new System.EventHandler(this.devicesToolStripMenuItem_Click);
            // 
            // communicationToolStripMenuItem
            // 
            this.communicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socketsToolStripMenuItem,
            this.sockets1ToolStripMenuItem});
            this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            this.communicationToolStripMenuItem.Size = new System.Drawing.Size(104, 19);
            this.communicationToolStripMenuItem.Text = "communication";
            this.communicationToolStripMenuItem.Click += new System.EventHandler(this.communicationToolStripMenuItem_Click);
            // 
            // socketsToolStripMenuItem
            // 
            this.socketsToolStripMenuItem.Name = "socketsToolStripMenuItem";
            this.socketsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.socketsToolStripMenuItem.Text = "Network connection";
            this.socketsToolStripMenuItem.Click += new System.EventHandler(this.socketsToolStripMenuItem_Click);
            // 
            // sockets1ToolStripMenuItem
            // 
            this.sockets1ToolStripMenuItem.Name = "sockets1ToolStripMenuItem";
            this.sockets1ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sockets1ToolStripMenuItem.Text = "sockets1";
            this.sockets1ToolStripMenuItem.Click += new System.EventHandler(this.sockets1ToolStripMenuItem_Click);
            // 
            // memoryManagementInformationToolStripMenuItem
            // 
            this.memoryManagementInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveInfoToolStripMenuItem});
            this.memoryManagementInformationToolStripMenuItem.Name = "memoryManagementInformationToolStripMenuItem";
            this.memoryManagementInformationToolStripMenuItem.Size = new System.Drawing.Size(207, 19);
            this.memoryManagementInformationToolStripMenuItem.Text = "memory  management information";
            // 
            // driveInfoToolStripMenuItem
            // 
            this.driveInfoToolStripMenuItem.Name = "driveInfoToolStripMenuItem";
            this.driveInfoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.driveInfoToolStripMenuItem.Text = "drive info";
            this.driveInfoToolStripMenuItem.Click += new System.EventHandler(this.driveInfoToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 349);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(963, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "CLICK HERE TO EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(963, 384);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "interface";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputOutputInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryManagementInformationToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem startAProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayRunningProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAFilefolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFiledirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAFilefolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startApsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socketsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem systemInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sockets1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
    }
}

