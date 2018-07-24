using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip drop <in seconds> : ");
            String drip = Console.ReadLine();
            Int32 drop = Convert.ToInt32(drip);

            Double hour = (3600 / drop * 0.00025)*1000;
            Double day = (86400 / drop * 0.00025)*1000;
            Double week = (604800 / drop * 0.00025)*1000;

            Double glassh = hour / 250;
            Double glassd = day / 250;
            Double glassw = week / 250;


            //Double glssh = Math.Round(glassh, 0);
            //Double glssd = Math.Round(glassd, 0);
            //Double glssw = Math.Round(glassw, 0);
            Double glssh = Math.Floor(glassh);
            Double glssd = Math.Floor(glassd);
            Double glssw = Math.Floor(glassw);

           //tring result = string.Format("{0} glasses of water are being wasted every hour", glssh);
          //Console.WriteLine(result);
            String result2 = string.Format("{0} glasses of water are being wasted every day", glssd);
            Console.WriteLine(result2);
          //String result3 = string.Format("{0} glasses of water are being wasted every week", glssw);
          //Console.WriteLine(result3);
            string dummy = Console.ReadLine();
        }
    }
}
