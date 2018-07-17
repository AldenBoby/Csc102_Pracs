using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip drop <in seconds> : ");
            String drip = Console.ReadLine();
            Int32 drop = Convert.ToInt32(drip);

            Double hour = 3600 / drop * 0.00025;
            Double day = 86400 / drop * 0.00025;
            Double week = 604800 / drop * 0.00025;

            String result = string.Format("This wastes {0} litres of water every hour",hour);
            Console.WriteLine(result);
            String result2 = string.Format("This wastes {0} litres of water every hour", day);
            Console.WriteLine(result2);
            String result3 = string.Format("This wastes {0} litres of water every hour", week);
            Console.WriteLine(result3);
            string dummy = Console.ReadLine();
        }
    }
}
