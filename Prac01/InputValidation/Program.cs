using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip drop <in seconds> : ");
            String drip = Console.ReadLine();
            int result;
            if (int.TryParse(drip,out result))
            {
                Console.WriteLine("Input is valid");
            }
            else
            {
                Console.WriteLine("Input is invalid");
                string dummy2 = Console.ReadLine();
                Environment.Exit(0);
            }
            Int32 drop = Convert.ToInt32(drip);
            
            Double hour = (3600 / drop * 0.00025) * 1000;
            Double day = (86400 / drop * 0.00025) * 1000;
            Double week = (604800 / drop * 0.00025) * 1000;

            Double glassh = hour / 250;
            Double glassd = day / 250;
            Double glassw = week / 250;

            Double glssh = Math.Floor(glassh);
            Double glssd = Math.Floor(glassd);
            Double glssw = Math.Floor(glassw);

            
            String result2 = string.Format("{0} glasses of water are being wasted every day", glssd);
            {
                int Num;
                if (int.TryParse(drip, out Num))
                {
                    Console.WriteLine(result2);
                }
                string dummy = Console.ReadLine();
            }

        }
    }
}
