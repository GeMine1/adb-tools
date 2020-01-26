using System;
using System.Collections.Generic;
using System.Text;

namespace adb_tools
{
    static public class Methods
    {
        public static string help()
        {
            string value = "";
            value += "List of commands and short description\ntype <command> -h for detailed help\n\n";
            value += "bluetooth     debug over bluetooth for wear";
            value += "\nwifi          debug over wifi for android";
            value += "\npull          get file to .\\files";
            value += "\npush          send file from files";
            value += "\n";

            return value;
        }

        public static string wifi()
        {
            
        }


    }
}
