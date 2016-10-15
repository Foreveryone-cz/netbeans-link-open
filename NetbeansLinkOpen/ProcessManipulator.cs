using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace NetbeansLinkOpen
{
    class ProcessManipulator
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        private const int SW_HIDE = 0;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWDEFAULT = 10;


        public static void bringProcessToFront(string processName)
        {
            Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(processName));
            foreach (Process netbeansProcess in processes)
            {

                IntPtr hWnd = netbeansProcess.MainWindowHandle;
                // if iconic, we need to restore the window
                if (IsIconic(hWnd))
                {
                    ShowWindowAsync(hWnd, SW_RESTORE);
                }
                // bring it to the foreground
                SetForegroundWindow(hWnd);
            }
        }
    }
}
