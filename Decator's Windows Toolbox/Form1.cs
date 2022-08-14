using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Decator_s_Windows_Toolbox
{
 
  public partial class WindowsToolbox : MaterialForm
    {
 

        List<string> WingetPrograms = new List<string>();
    List<string> ConfigActions = new List<string>();
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

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }

        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }


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
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = false;
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
            progressBar1.Visible = true;
            foreach (string Action in ConfigActions)
            {
                if (Action == "DisWinDef")
                Functions.ApplyRegistryEdits(Action);
                if (Action == "EnableNFS")
                    if (Functions.RunCommand("powershell", "Enable-WindowsOptionalFeature -FeatureName ServicesForNFS-ClientOnly, ClientForNFS-Infrastructure -Online -NoRestart") != 0)
                        Log("Couldn\'t enable NFS");
                    else
                        Log("NFS enabled.");


            }
            int i=0;
      foreach (string Program in WingetPrograms)
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
