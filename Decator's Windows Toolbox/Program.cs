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
        public string tempPath = System.IO.Path.GetTempPath();

        static public void Log(string message)
        {
            message = String.Format("Decator\'s toolbox:: {0}", message);
            Console.WriteLine(message);
        }

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
                    Log(String.Format("{0}", WindowsDefenderFeatures.GetValue("MpPlatformKillbitsFromEngine")));
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
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowsToolbox());
        }
    }
}
