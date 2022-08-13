namespace Decator_s_Windows_Toolbox
{
    partial class WindowsToolbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsToolbox));
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InstallVscode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InstallGsudo = new System.Windows.Forms.Button();
            this.InstallVLC = new System.Windows.Forms.Button();
            this.InstallPython = new System.Windows.Forms.Button();
            this.InstallWaterfox = new System.Windows.Forms.Button();
            this.InstallNuGet = new System.Windows.Forms.Button();
            this.DisWinDef = new System.Windows.Forms.Button();
            this.InstallTerminal = new System.Windows.Forms.Button();
            this.InstallAalacritty = new System.Windows.Forms.Button();
            this.InstallVim = new System.Windows.Forms.Button();
            this.InstallGit = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.InstallationWorker = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            resources.ApplyResources(this.LogoBox, "LogoBox");
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.TabStop = false;
            // 
            // ConfirmButton
            // 
            resources.ApplyResources(this.ConfirmButton, "ConfirmButton");
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(79)))), ((int)(((byte)(191)))));
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_1);
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(79)))), ((int)(((byte)(191)))));
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // InstallVscode
            // 
            resources.ApplyResources(this.InstallVscode, "InstallVscode");
            this.InstallVscode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallVscode.Name = "InstallVscode";
            this.InstallVscode.UseVisualStyleBackColor = true;
            this.InstallVscode.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.InstallGsudo);
            this.panel1.Controls.Add(this.InstallVLC);
            this.panel1.Controls.Add(this.InstallPython);
            this.panel1.Controls.Add(this.InstallWaterfox);
            this.panel1.Controls.Add(this.InstallNuGet);
            this.panel1.Controls.Add(this.DisWinDef);
            this.panel1.Controls.Add(this.InstallTerminal);
            this.panel1.Controls.Add(this.InstallAalacritty);
            this.panel1.Controls.Add(this.InstallVim);
            this.panel1.Controls.Add(this.InstallGit);
            this.panel1.Controls.Add(this.InstallVscode);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // InstallGsudo
            // 
            resources.ApplyResources(this.InstallGsudo, "InstallGsudo");
            this.InstallGsudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallGsudo.Name = "InstallGsudo";
            this.InstallGsudo.UseVisualStyleBackColor = true;
            this.InstallGsudo.Click += new System.EventHandler(this.InstallGsudo_Click);
            // 
            // InstallVLC
            // 
            resources.ApplyResources(this.InstallVLC, "InstallVLC");
            this.InstallVLC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallVLC.Name = "InstallVLC";
            this.InstallVLC.UseVisualStyleBackColor = true;
            this.InstallVLC.Click += new System.EventHandler(this.InstallVLC_Click);
            // 
            // InstallPython
            // 
            resources.ApplyResources(this.InstallPython, "InstallPython");
            this.InstallPython.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallPython.Name = "InstallPython";
            this.InstallPython.UseVisualStyleBackColor = true;
            this.InstallPython.Click += new System.EventHandler(this.InstallPython_Click);
            // 
            // InstallWaterfox
            // 
            resources.ApplyResources(this.InstallWaterfox, "InstallWaterfox");
            this.InstallWaterfox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallWaterfox.Name = "InstallWaterfox";
            this.InstallWaterfox.UseVisualStyleBackColor = true;
            this.InstallWaterfox.Click += new System.EventHandler(this.InstallWaterfox_Click);
            // 
            // InstallNuGet
            // 
            resources.ApplyResources(this.InstallNuGet, "InstallNuGet");
            this.InstallNuGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallNuGet.Name = "InstallNuGet";
            this.InstallNuGet.UseVisualStyleBackColor = true;
            this.InstallNuGet.Click += new System.EventHandler(this.InstallNuGet_Click);
            // 
            // DisWinDef
            // 
            resources.ApplyResources(this.DisWinDef, "DisWinDef");
            this.DisWinDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisWinDef.Name = "DisWinDef";
            this.DisWinDef.UseVisualStyleBackColor = true;
            this.DisWinDef.Click += new System.EventHandler(this.DisWinDef_Click);
            // 
            // InstallTerminal
            // 
            resources.ApplyResources(this.InstallTerminal, "InstallTerminal");
            this.InstallTerminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallTerminal.Name = "InstallTerminal";
            this.InstallTerminal.UseVisualStyleBackColor = true;
            this.InstallTerminal.Click += new System.EventHandler(this.InstallTerminal_Click);
            // 
            // InstallAalacritty
            // 
            resources.ApplyResources(this.InstallAalacritty, "InstallAalacritty");
            this.InstallAalacritty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallAalacritty.Name = "InstallAalacritty";
            this.InstallAalacritty.UseVisualStyleBackColor = true;
            this.InstallAalacritty.Click += new System.EventHandler(this.InstallAalacritty_Click);
            // 
            // InstallVim
            // 
            resources.ApplyResources(this.InstallVim, "InstallVim");
            this.InstallVim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallVim.Name = "InstallVim";
            this.InstallVim.UseVisualStyleBackColor = true;
            this.InstallVim.Click += new System.EventHandler(this.InstallVim_Click);
            // 
            // InstallGit
            // 
            resources.ApplyResources(this.InstallGit, "InstallGit");
            this.InstallGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallGit.Name = "InstallGit";
            this.InstallGit.UseVisualStyleBackColor = true;
            this.InstallGit.Click += new System.EventHandler(this.InstallGit_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // InstallationWorker
            // 
            this.InstallationWorker.WorkerSupportsCancellation = true;
            this.InstallationWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InstallationWorker_DoWork);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // WindowsToolbox
            // 
            this.AcceptButton = this.ConfirmButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.CancelButton = this.ExitButton;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.LogoBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowsToolbox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.WindowsToolbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button InstallVscode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InstallGit;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker InstallationWorker;
        private System.Windows.Forms.Button InstallVim;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button InstallTerminal;
        private System.Windows.Forms.Button InstallAalacritty;
        private System.Windows.Forms.Button DisWinDef;
        private System.Windows.Forms.Button InstallGsudo;
        private System.Windows.Forms.Button InstallVLC;
        private System.Windows.Forms.Button InstallPython;
        private System.Windows.Forms.Button InstallWaterfox;
        private System.Windows.Forms.Button InstallNuGet;
    }
}
