using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decator_s_Windows_Toolbox
{

  public partial class WindowsToolbox : Form
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
    public WindowsToolbox()
    {
      InitializeComponent();
    }


    private void InstallInBackground(string program)
    {
      if (Functions.InstallProgramWinget(program) != 0)
      {
        Functions.Log(String.Format("Installation of {0} failed.", program));
      }
    }


    private void ConfirmButton_1(object sender, EventArgs e) //Confirm Button
    {
        if (WingetPrograms.Count == 0)
            {
                Log("No actions specified");
            }
           else if (!backgroundWorker2.IsBusy)
      {
        Log("Now running actions specified.");
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
    private void Log(string message)
    {
      message = String.Format("Decator\'s toolbox:: {0}\n", message);
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
      foreach (string Action in ConfigActions)
            {
                Functions.ApplyRegistryEdits(Action);
                    
            }
      foreach (string Program in WingetPrograms)
      {
        if (Functions.InstallProgramWinget(Program)!=0)
                {
                    Log(String.Format("Action {0} Failed!"));
                }

        if(InstallationWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
      }
    }
  }
}
