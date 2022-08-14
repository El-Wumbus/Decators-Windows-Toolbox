using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Linq;

namespace Decator_s_Windows_Toolbox
{
 
  public partial class WindowsToolbox : MaterialForm
    {
 

    List<string> WingetPrograms = new List<string>();
    List<string> ConfigActions = new List<string>();
        List<string> AddToPATH = new List<string>();
    bool install_vscode_winget = false, 
            install_git_winget = false, 
            install_vim_winget = false, 
            install_alacritty_winget= false, 
            install_terminal_winget=false, 
            install_nuget_winget=false, 
            install_python_winget =false, 
            install_waterfox_winget = false, 
            install_vlc_winget = false,
            install_gsudo_winget = false;

        public WindowsToolbox()
    {
      InitializeComponent();
            //            UseImmersiveDarkMode(this.Handle, true);
            this.ControlBox = true;
            this.FormBorderStyle = FormBorderStyle.None;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Log(string message)
        {
            message = String.Format("Decator\'s toolbox:: {0}\n", message);
            TextLog(message);

            using (FileStream fs = File.OpenWrite(Program.logfile))
            {
                char[] msg = message.ToCharArray();
                Byte[] text = new UTF8Encoding(true).GetBytes(msg);
                fs.Write(text, 0, message.Length);
            }
        }
       


    private void ConfirmButton_1(object sender, EventArgs e) //Confirm Button
    {
 
      if (!backgroundWorker2.IsBusy)
      {
        backgroundWorker2.RunWorkerAsync();
      }
      else
      {
        Log("Already running actions!");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (backgroundWorker2.IsBusy)
      {
        backgroundWorker2.CancelAsync();
      }

      Application.Exit(); // Exit the application
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      install_vscode_winget = true;
      InstallLog("vscode");

    }
        private void InstallGit_Click(object sender, EventArgs e)
    {
      install_git_winget = true;
      InstallLog("git");
    }
    private void InstallVim_Click(object sender, EventArgs e)
    {
      install_vim_winget = true;
      InstallLog("Vim");

    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
     
    }
    private void TextLog(string message)
    {
      richTextBox1.Text += message;

    }
    private void InstallLog(string message)
    {
      Log(String.Format("Added {0} to install list.", message));
    }

        private void InstallTerminal_Click(object sender, EventArgs e)
        {
            install_terminal_winget = true;
            InstallLog("Windows Terminal");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WindowsToolbox_Load(object sender, EventArgs e)
        {
            Log("Windows Tool Box Loaded.");
            Log(String.Format("Logging to '{0}'.", Program.logfile));
            progressBar1.Visible = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            textBox3.Text = "Author: Decator\r\n" +
                            "Github: https://tinyurl.com/DecatorsTools\r\n" +
                            "Version: 0.1.0\r\n" +
                            "";
        }

        private void EnableNFS_Click(object sender, EventArgs e)
        {
            Log("Will Enable NFS");
            ConfigActions.Add("EnableNFS");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            WingetPrograms.Clear();
            ConfigActions.Clear();
            AddToPATH.Clear();
            install_vscode_winget = false;
            install_git_winget = false;
            install_vim_winget = false;
            install_alacritty_winget = false;
            install_terminal_winget = false;
            install_nuget_winget = false;
            install_python_winget = false;
            install_waterfox_winget = false;
            install_vlc_winget = false;
            install_gsudo_winget = false;
            Log("All actions cleared.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add(textBox1.Text);
            InstallLog(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstallChrome_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("Google.Chrome");
            InstallLog("Google Chrome");
        }

        private void InstallSteam_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("Valve.Steam");
            InstallLog("Steam");
        }

        private void InstallVMeet_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("VB-Audio.Voicemeeter");
            InstallLog("Voicemeeter");
        }

        private void InstallVMP_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("VB-Audio.Voicemeeter.Potato");
                            InstallLog("Voicemeeter Potato");

        }

        private void InstallVMB_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("VB-Audio.Voicemeeter.Banana");
                            InstallLog("Voicemeeter Banana");

        }

        private void InstallQemu_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("SoftwareFreedomConservancy.QEMU");
            InstallLog("Qemu");


        }

        private void InstallDosBox_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("DOSBox.DOSBox");
            InstallLog("DOSBox");


        }

        private void InstallDebian_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("Debian.Debian");
            InstallLog("Debian (WSL)");


        }

        private void InstallGithubDesktop_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("GitHub.GitHubDesktop");
            InstallLog("Github Desktop");


        }

        private void InstallFirefox_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("Mozilla.Firefox");
            InstallLog("Firefox");


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void EnableWSL_Click(object sender, EventArgs e)
        {
            Log("Will Enable WSL");
            ConfigActions.Add("EnableWSL");
        }

        private void InstallAlpineWSL_Click(object sender, EventArgs e)
        {
            InstallLog("Alpine (WSL)");
            WingetPrograms.Add("9P804CRF0395");
        }

        private void InstallChoco_Click(object sender, EventArgs e)
        {
            Log("Chocolatey");
            ConfigActions.Add("AddChoco");
        }

        private void AddPATH_Click(object sender, EventArgs e)
        {
            ConfigActions.Add("AddPATH");
            AddToPATH.Add(PATHBox.Text);
            Log(String.Format("Adding {0} to PATH",PATHBox.Text));
            PATHBox.Text = "";
        }

        private void PATHBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstallNvim_Click(object sender, EventArgs e)
        {
            WingetPrograms.Add("Neovim.Neovim");
            InstallLog("Neovim");
        }

        private void DisWinDef_Click(object sender, EventArgs e)
        {
            Log("Will Disable Windows Defender");
            ConfigActions.Add("DisWinDef");
        }

        private void InstallNuGet_Click(object sender, EventArgs e)
        {
            install_nuget_winget = true;
            InstallLog("NuGet");
        }

        private void InstallPython_Click(object sender, EventArgs e)
        {
            install_python_winget = true;
            InstallLog("Python3");
        }

        private void InstallWaterfox_Click(object sender, EventArgs e)
        {
            install_waterfox_winget = true;
            InstallLog("Waterfox");
        }

        private void InstallVLC_Click(object sender, EventArgs e)
        {
            install_vlc_winget = true;
            InstallLog("VLC");
        }

        private void InstallGsudo_Click(object sender, EventArgs e)
        {
            install_gsudo_winget = true;
            InstallLog("Gsudo");
        }

        private void InstallAalacritty_Click(object sender, EventArgs e)
        {
            install_alacritty_winget = true;
            InstallLog("Alacritty");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
    {
            if (install_vscode_winget)
        WingetPrograms.Add("Microsoft.VisualStudioCode");
      if (install_git_winget)
        WingetPrograms.Add("git.git");
      if (install_vim_winget)
        WingetPrograms.Add("vim.vim");
      if (install_alacritty_winget)
        WingetPrograms.Add("Alacritty.Alacritty");
      if (install_terminal_winget)
        WingetPrograms.Add("Microsoft.WindowsTerminal");
      if (install_nuget_winget)
        WingetPrograms.Add("Microsoft.NuGet");
      if (install_python_winget)
        WingetPrograms.Add("Python.Python.3");
      if (install_waterfox_winget)
         WingetPrograms.Add("Waterfox.Waterfox");
      if (install_vlc_winget)
         WingetPrograms.Add("VideoLAN.VLC");
      if (install_gsudo_winget)
        WingetPrograms.Add("gerardog.gsudo");
      if (install_alacritty_winget)
        WingetPrograms.Add("Alacritty.Alacritty");
      if (WingetPrograms.Count == 0 && ConfigActions.Count == 0)
            {
                Log("No actions specified");
                return;
            }
            else
            {
                Log("Now running actions specified.");

            }
            InstallationWorker.RunWorkerAsync();
      while(true)
            {
                if (!InstallationWorker.IsBusy)
                {
                    Log(String.Format("Done Working. ({0})", DateTime.Now.ToString("hh:mm:ss tt")));
                    break;
                }
                if (backgroundWorker2.CancellationPending)
                {
                    InstallationWorker.CancelAsync();
                    e.Cancel = true;
                    break;
                }
            }
    }

    private void InstallationWorker_DoWork(object sender, DoWorkEventArgs e)
    {
            List<string> configurationList = ConfigActions.Distinct().ToList();
            List<string> installationList = WingetPrograms.Distinct().ToList();
            List<string> addPath = AddToPATH.Distinct().ToList();
            progressBar1.Visible = true;
            foreach (string Action in configurationList)
            {
                if (Action == "DisWinDef")
                    Functions.ApplyRegistryEdits(Action);
                else if (Action == "EnableNFS")
                    if (Functions.RunCommand("powershell", "Enable-WindowsOptionalFeature -FeatureName ServicesForNFS-ClientOnly, ClientForNFS-Infrastructure -Online -NoRestart") != 0)
                        Log("Couldn\'t enable NFS");
                    else
                        Log("NFS enabled.");
                else if (Action == "EnableWSL")
                    if (Functions.RunCommand("powershell", "Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux  -NoRestart") !=0)
                        Log("Couldn\'t enable WSL");
                    else {
                        Log("WSL enabled.");
                        Log("A restart is required for enabling of WSL to take effect.");
                    }
                else if (Action == "AddChoco")
                    if (Functions.RunCommand("powershell", "Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))") != 0)
                        Log("Couldn\'t install Chocolatey");
                    else
                    {
                        Log("Chocolatey installed.");
                    }

                else if (Action == "AddPATH")
                {
                List<string> strings = new List<string>();
                string realpath;
                    foreach (string item in addPath) {
                        if (!item.EndsWith("\\"))
                        {
                            realpath = item + @"\";
                        }
                        else
                        { 
                            realpath = item; 
                        }
                        strings.Add(realpath);
                    }

                    string path = string.Join(";", strings);
                        string Command = String.Format("/C setx path \"%PATH%;{0}\"",path);
                    Log(Command);
                        if (Functions.RunCommand("cmd.exe", Command) != 0) {
                            Log(String.Format("Couldn't add {0} to PATH.", path));
                   }
                }
                   
            }
      foreach (string Program in installationList)
      {
        if (Functions.InstallProgramWinget(Program)!=0)
                {
                    Log(String.Format("{0} installation failed!", Program));
                }
        else
                {
                    Log(String.Format("{0} has been installed.", Program));
                }

        if(InstallationWorker.CancellationPending)
                {
                    e.Cancel = true;
                    progressBar1.Visible = false;
                    break;
                }
      }
            progressBar1.Visible = false;
        }
 
    }
}
