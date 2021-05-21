using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace HyperSpoofer
{
    class DogWater
    {
        public static void CringyAscii()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ██░ ██▓██   ██▓ ██▓███  ▓█████  ██▀███       ██████  ██▓███   ▒█████   ▒█████    █████▒▓█████  ██▀███  ");
            Console.WriteLine("▓██░ ██▒▒██  ██▒▓██░  ██▒▓█   ▀ ▓██ ▒ ██▒   ▒██    ▒ ▓██░  ██▒▒██▒  ██▒▒██▒  ██▒▓██   ▒ ▓█   ▀ ▓██ ▒ ██▒");
            Console.WriteLine("▒██▀▀██░ ▒██ ██░▓██░ ██▓▒▒███   ▓██ ░▄█ ▒   ░ ▓██▄   ▓██░ ██▓▒▒██░  ██▒▒██░  ██▒▒████ ░ ▒███   ▓██ ░▄█ ▒");
            Console.WriteLine("░▓█ ░██  ░ ▐██▓░▒██▄█▓▒ ▒▒▓█  ▄ ▒██▀▀█▄       ▒   ██▒▒██▄█▓▒ ▒▒██   ██░▒██   ██░░▓█▒  ░ ▒▓█  ▄ ▒██▀▀█▄  ");
            Console.WriteLine("░▓█▒░██▓ ░ ██▒▓░▒██▒ ░  ░░▒████▒░██▓ ▒██▒   ▒██████▒▒▒██▒ ░  ░░ ████▓▒░░ ████▓▒░░▒█░    ░▒████▒░██▓ ▒██▒");
            Console.WriteLine(" ▒ ░░▒░▒  ██▒▒▒ ▒▓▒░ ░  ░░░ ▒░ ░░ ▒▓ ░▒▓░   ▒ ▒▓▒ ▒ ░▒▓▒░ ░  ░░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒ ░    ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Console.WriteLine(" ▒ ░▒░ ░▓██ ░▒░ ░▒ ░      ░ ░  ░  ░▒ ░ ▒░   ░ ░▒  ░ ░░▒ ░       ░ ▒ ▒░   ░ ▒ ▒░  ░       ░ ░  ░  ░▒ ░ ▒░");
            Console.WriteLine(" ░  ░░ ░▒ ▒ ░░  ░░          ░     ░░   ░    ░  ░  ░  ░░       ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░       ░     ░░   ░ ");
            Console.WriteLine(" ░  ░  ░░ ░                 ░  ░   ░              ░               ░ ░      ░ ░             ░  ░   ░    ");
            Console.WriteLine("        ░ ░                             ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void CheckHWID()
        {   
            try
            {
                Console.Clear();

                string key = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";

                string guid = (string)Registry.GetValue(key, "GUID", (object)"default");

                Console.WriteLine("[HyperSpoofer] Current HWID: " + guid);

                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("[HyperSpoofer] There was an error while getting your HWID");

                Console.ReadKey();
            }
        }

        public static void SpoofHWID()
        {
            try
            {
                Console.Clear();

                string key = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";

                string oldHwid = (string)Registry.GetValue(key, "HwProfileGuid", (object)"default");

                string newHwid = "{HyperSpoofer-" + GenID(5) + "-" + GenID(5) + "-" + GenID(4) + "-" + GenID(9) + "}";

                Registry.SetValue(key, "GUID", (object)newHwid);

                Registry.SetValue(key, "HwProfileGuid", (object)newHwid);

                Console.WriteLine("[HyperSpoofer] Successfully Changed Your HWID!");

                Console.WriteLine("\n[HyperSpoofer] Old HWID: " + oldHwid);

                Console.WriteLine("\n[HyperSpoofer] New HWID: " + newHwid);

                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("[HyperSpoofer] - Failed to change hwid, try to run this as administrator");

                Console.ReadKey();

            }
        }

        private static Random random = new Random();

        public static string GenID(int length)
        {

            string chars = "123457869";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
