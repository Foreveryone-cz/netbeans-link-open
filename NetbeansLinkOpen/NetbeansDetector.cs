using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetbeansLinkOpen
{
    class NetbeansDetector
    {

        public static string detectNetbeansPath()
        {
            string[] dirsToScan = {
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
            };
            foreach (string dir in dirsToScan)
            {
                string result = NetbeansDetector.detectNetbeansUnder(dir);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        public static string detectNetbeansUnder(string parentDir)
        {
            foreach (string dir in Directory.EnumerateDirectories(parentDir, "Netbeans*"))
            {
                string fullpath = dir + "\\bin\\";
                fullpath += Environment.Is64BitOperatingSystem ? "netbeans64.exe" : "netbeans.exe";
                if (File.Exists(fullpath))
                {
                    return fullpath;
                }
            }

            return null;
        }

    }
}
