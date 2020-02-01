using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace adb_tools
{
    static class Util
    {

        internal static string path;
        public static string AdbCmd(string cmd)
        {
            string outa;
            using (Process proc = new Process())
            {
                ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo(path);
                //procStartInfo.Arguments = "shell ls sdcard/Pictures/data/";
                //procStartInfo.Arguments = "push " + filepath + " /sdcard/Pictures/data/" + filepathSplitted[filepathSplitted.Length - 1];
                procStartInfo.Arguments = cmd;
                procStartInfo.RedirectStandardInput = true;
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = false;
                proc.StartInfo = procStartInfo;
                proc.Start();
                //proc.StandardInput.WriteLine("adb shell");
                //proc.StandardInput.WriteLine("ls"); // this will not work on some newer os
                outa = proc.StandardOutput.ReadToEnd();
                /*while (!proc.StandardOutput.EndOfStream)
                {
                    outa += proc.StandardOutput.ReadLine();
                    // do something with line
                }*/
                //proc.StandardInput.WriteLine("adb tcpip 5555"); // this will turn on ADB to wifi on port 5555
                //proc.StandardInput.WriteLine("adb connect " + deviceip + " 5555"); // this allows you to at this point unplug your device
                //proc.StandardInput.WriteLine("adb -s " + deviceip + ":5555" + cmd);  // this connects running the command on the specific ip address so when you disconnect usb it will continue creating movie
                //proc.WaitForExit();
            }
            return outa;
        }

        internal static string getAdb()
        {
            try
            {
                StreamReader sr = new StreamReader("config.txt");
                string path = sr.ReadToEnd();
                sr.Close();
                return path;
            }
            catch (FileNotFoundException)
            {
                return "null";
            }
        }
    }
}
