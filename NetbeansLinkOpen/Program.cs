using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetbeansLinkOpen
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                string[] args = Environment.GetCommandLineArgs();
                if (args[1] == "install")
                {
                    // redirect console output to parent process;
                    // must be before any calls to Console.WriteLine()
                    AttachConsole(ATTACH_PARENT_PROCESS);

                    bool silentInstall = args.Length > 2 && args[2] == "silent";

                    string netbeansPath = NetbeansDetector.detectNetbeansPath();
                    if (netbeansPath == null)
                    {
                        if (!silentInstall)
                        {
                            Console.WriteLine("Error, cannot find netbeans");
                        }
                        Application.Exit();
                        return;
                    }

                    string error = NetbeansCallbackInstaller.installHandler(netbeansPath);
                    if (error != null)
                    {
                        if (!silentInstall)
                        {
                            Console.WriteLine("Error installing handler:" + error);
                        }
                    }
                    else
                    {
                        if (!silentInstall)
                        {
                            Console.WriteLine("Handler installed succesfully");
                        }
                    }
                    Application.Exit();
                    return;
                }

                CallbackHandler.processCallback();
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Setup());
        }
    }
}
