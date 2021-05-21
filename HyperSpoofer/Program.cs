using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HyperSpoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Title = "Hyper Spoofer | DogWater Spoofer since 2019";
            DogWater.CringyAscii();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[ 1 ] Spoof");
            Console.WriteLine("[ 2 ] Check HWID");
            Console.WriteLine();
            Console.Write("Selection : ");
            var Skiddedspooferoptions = Console.ReadLine();
            if (Skiddedspooferoptions == "1")
            {
                DogWater.SpoofHWID();
            }
            if (Skiddedspooferoptions == "2")
            {
                DogWater.CheckHWID();
            }
            else
            {
                Console.WriteLine("Maybe actually select one thats valid.");
            }
        }


    }
}
