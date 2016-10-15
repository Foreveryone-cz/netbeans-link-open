using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetbeansLinkOpen
{
    class NetbeansCallbackInstaller
    {

        public static string getValidHandlerValue(string netbeansPath)
        {
            return "\"" + Environment.GetCommandLineArgs()[0] + "\" \"%1\" \"" + netbeansPath + "\"";
        }

        public static string getCurrentHandler()
        {
            RegistryKey netbeansKey = Registry.ClassesRoot.OpenSubKey("netbeans\\shell\\open\\command");
            if (netbeansKey == null)
            {
                return null;
            }
            object v = netbeansKey.GetValue(null);
            if (v is string)
            {
                return (string)v;
            }
            return null;
        }

        public static string installHandler(string netbeansPath)
        {
            if (!File.Exists(netbeansPath))
            {
                return "Invalid path: " + netbeansPath;
            }
            try
            {
                RegistryKey netbeansMainKey = Registry.ClassesRoot.CreateSubKey("netbeans");
                netbeansMainKey.SetValue("URL Protocol", "URL:Netbeans Protocol");

                RegistryKey netbeansKey = Registry.ClassesRoot.CreateSubKey("netbeans\\shell\\open\\command");
                netbeansKey.SetValue(null, NetbeansCallbackInstaller.getValidHandlerValue(netbeansPath));

                RegistryKey netbeansIconKey = Registry.ClassesRoot.CreateSubKey("netbeans\\DefaultIcon");
                netbeansIconKey.SetValue(null, "\"" + netbeansPath + ",1\"");
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
            return null;
        }


    }
}
