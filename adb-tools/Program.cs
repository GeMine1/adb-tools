using System;

namespace adb_tools
{
    class Program
    {
        static void Main(string[] args)
        {
            string return_value = "";
            switch (args[0])
            {
                case "help":
                    return_value = Methods.help();
                    break;
                default:
                    break;
            }
            Console.WriteLine(return_value);
        }
    }
}
