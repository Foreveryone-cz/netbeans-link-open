using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetbeansLinkOpen
{
    class CallbackHandler
    {

        public static void processCallback()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length <= 2)
            {
                MessageBox.Show("2 arguments is minimum, 1) sourceFile path with line number, 2) NetBeans exe path");
                return;
            }
            string uriToOpen = args[1];
            string netbeansPath = args[2];

            Uri uri = new Uri(uriToOpen);
            System.Collections.Specialized.NameValueCollection parts
                    = System.Web.HttpUtility.ParseQueryString(uri.Query);
            string filePath = parts.Get("f");

            string search = parts.Get("s");
            if (search != "")
            {
                if (filePath.Substring(0, search.Length) == search)
                {
                    string replace = parts.Get("r");
                    filePath = replace + filePath.Substring(search.Length);
                }
            }
            filePath = filePath.Replace("/", "\\");

            if (!File.Exists(filePath.Substring(0, filePath.LastIndexOf(':'))))
            {
                MessageBox.Show("File not found:" + filePath);
                return;
            }
            if (!File.Exists(netbeansPath))
            {
                MessageBox.Show("Netbeans file not found:" + netbeansPath);
                return;
            }

            Process.Start(netbeansPath, "--nosplash --console suppress --open " + filePath);
            ProcessManipulator.bringProcessToFront(Path.GetFileName(netbeansPath));
        }
    }
}
