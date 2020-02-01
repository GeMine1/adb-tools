using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace adb_tools
{
    static public class Methods
    {
        public static string help()
        {
            string value = "";
            value += "List of commands and short description\ntype <command> -h for detailed help\n\n";
            value += "path              specify the adb path";
            value += "\nbluetooth       debug over bluetooth for wear";
            value += "\nwifi            debug over wifi for android";
            value += "\npull            get file to .\\files";
            value += "\npush            send file from files";
            value += "\n";

            return value;
        }

        public static string changePath(string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter("config.txt");
                sw.Write(path);
                sw.Flush();
                sw.Dispose();
                return "Path changed";
            }
            catch (Exception)
            {
                return "Error while changing path in config.txt";
            }
        }

        public static string wifi(string ip)
        {
            return Util.AdbCmd("connect " + ip);
        }
        public static string bluetooth()
        {
            return Util.AdbCmd("forward tcp:4444 localabstract:/adb-hub & adb connect 127.0.0.1:4444");
        }


    }
}
