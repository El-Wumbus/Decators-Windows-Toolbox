using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;
using Microsoft.Win32;

namespace Decator_s_Windows_Toolbox {
    public class Functions
    {
        static public string startingTime = DateTime.Now.ToString("dd-hh-mm-ss");

        static public async void DownloadURL(string url,  string location)
        {
            HttpClient httpClient = new HttpClient();
            using var Stream = await httpClient.GetStreamAsync(url);
            using var Filestream = new FileStream(location, FileMode.CreateNew);
            await Stream.CopyToAsync(Filestream);

        }

        static public void ApplyRegistryEdits(string Edit)
        {
            if (Edit == "DisWinDef")
            {
                DisWinDef();
            }
        }
        static public void DisWinDef()
        {
            try
            {
                using (RegistryKey WindowsDefenderFeatures = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows Defender\Features\", true))
                {
                    WindowsDefenderFeatures.SetValue("MpPlatformKillbitsFromEngine", 0);
                    WindowsDefenderFeatures.SetValue("TamperProtectionSource", 0, RegistryValueKind.DWord);
                    WindowsDefenderFeatures.SetValue("MpCapability", 0);
                    WindowsDefenderFeatures.SetValue("TamperProtection", 0, RegistryValueKind.DWord);
                    WindowsDefenderFeatures.Close();
                }
            }
            catch (ArgumentNullException)
            {
                Application.Exit();
            }
        }

        static public int InstallProgramWinget(string program_name)
        {
            string command = String.Format("install {0}", program_name);
            Process winget = new Process();
            
            winget.StartInfo.FileName = "winget";
            winget.StartInfo.Arguments = command;
            winget.StartInfo.UseShellExecute = true;
            winget.StartInfo.CreateNoWindow = true;
            winget.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            winget.StartInfo.Verb = "runas";
            winget.Start();
            winget.WaitForExit();
            return winget.ExitCode;
        }
        static public int RunCommand(string programName, string arguments, bool UseAdmin=true)
        {
            string command = programName;
            Process program = new Process();
            program.StartInfo.FileName=command;
            program.StartInfo.Arguments = arguments;
            program.StartInfo.UseShellExecute = true;
            program.StartInfo.CreateNoWindow = true;
            program.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (UseAdmin)
                program.StartInfo.Verb = "runas";
            program.Start();
            program.WaitForExit();
            return program.ExitCode;
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static public string startingTime = DateTime.Now.ToString("dd-hh-mm-ss");
        static public string tempPath = System.IO.Path.GetTempPath();
        static public string logfile = String.Format("{0}decators_windows_toolbox_{1}", tempPath, startingTime);


        [STAThread]
        static void Main()
        {
            if (!File.Exists(logfile))
                File.Delete(logfile);
            using (File.Create(logfile)) ;



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowsToolbox());
        }
    }
}
