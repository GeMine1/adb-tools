using System;

namespace adb_tools
{
    class Program
    {
        static void Main(string[] args)
        {
            string return_value;
            Util.path = Util.getAdb();
            if (Util.path != "null")
            {
                try
                {
                    switch (args[0])
                    {
                        case "help":
                            return_value = Methods.help();
                            break;
                        case "path":
                            return_value = Methods.changePath(args[1]);
                            break;
                        case "wifi":
                            return_value = Methods.wifi(args[1]);
                            break;
                        case "bluetooth":
                            return_value = Methods.bluetooth();
                            break;
                        default:
                            return_value = args[0] + " not found, try \"adb-tools help\" for a list with all commands";
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    return_value = "Maybe consider adding arguments";
                }
            }
            else
            {
                if (args[0] == "path")
                {
                    return_value = Methods.changePath(args[1]);
                }
                else
                {
                    return_value = "Specify adb path first: \"adb-tools path <path>\"";
                }
            }
            Console.WriteLine(return_value);
        }
    }
}
