using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age?:");
            string age = Console.ReadLine();
            int result;
            if (int.TryParse(age, out result)) 
            {
               
            }
            else
            {
                Console.WriteLine("Invalid input");
                string hold = Console.ReadLine();
                Environment.Exit(0);   
            } 
       
            Console.WriteLine("Monthly Salary?:");
            string salary = Console.ReadLine();
            if (int.TryParse(salary,out result))
            {
                
            }
            else
            {
                Console.WriteLine("Invalid input");
                string hold = Console.ReadLine();
                Environment.Exit(0);
            }

            int age_num = Convert.ToInt32(age);
            int sal_num = Convert.ToInt32(salary);

            if (age_num < 65 && sal_num <= 4999)
            {
                Console.WriteLine("Payable Tax : 0 ");
            }
            else if (age_num >= 65 && sal_num <= 9999)
            {
                Console.WriteLine("Payable Tax: 0 ");
            }
            if (age_num < 65 && sal_num >= 5000 && sal_num <= 6499)
            {
                Console.WriteLine("Payable Tax : 13 ");
            }
            if (age_num < 65 && sal_num >= 6500 && sal_num <= 7799)
            {
                Console.WriteLine("Payable Tax : 250 ");
            }
            if (age_num < 65 && sal_num >= 7800 && sal_num <= 9999)
            {
                Console.WriteLine("Payable Tax : 620 ");
            }
            if (age_num < 65 && sal_num >= 10000 && sal_num <= 13499)
            {
                Console.WriteLine("Payable Tax : 1200 ");
            }
            if (age_num < 65 && sal_num >= 13500 && sal_num <= 17899)
            {
                Console.WriteLine("Payable Tax : 2100 ");
            }
            if (age_num < 65 && sal_num >= 17900 && sal_num <= 19999)
            {
                Console.WriteLine("Payable Tax : 2700 ");
            }
            if (age_num < 65 && sal_num >= 20000 && sal_num <= 39999)
            {
                Console.WriteLine("Payable Tax : 8000 ");
            }
            if (age_num < 65 && sal_num >= 40000 && sal_num <= 59999)
            {
                Console.WriteLine("Payable Tax : 16000 ");
            }
            if (age_num < 65 && sal_num >= 60000)
            {
                Console.WriteLine("Payable Tax : 20000 ");
            }

            if (age_num >= 65 && age_num <=74 && sal_num >= 10000 && sal_num <= 13499)
            {
                Console.WriteLine("Payable Tax : 600 ");
            }
            if (age_num >= 65 && age_num <= 74 && sal_num >= 13500 && sal_num <= 17899)
            {
                Console.WriteLine("Payable Tax : 1500 ");
            }
            if (age_num >= 65 && age_num <= 74 && sal_num >= 17900 && sal_num <= 19999)
            {
                Console.WriteLine("Payable Tax : 2000 ");
            }
            if (age_num >= 65 && age_num <= 74 && sal_num >= 20000 && sal_num <= 39999)
            {
                Console.WriteLine("Payable Tax : 7500 ");
            }
            if (age_num >= 65 && age_num <= 74 && sal_num >= 40000 && sal_num <= 59999)
            {
                Console.WriteLine("Payable Tax : 15600 ");
            }
            if (age_num >= 65 && age_num <= 74 && sal_num >= 60000)
            {
                Console.WriteLine("Payable Tax : 17050 ");
            }

            if (age_num > 75 && sal_num >= 10000 && sal_num <= 13499)
            {
                Console.WriteLine("Payable Tax : 400 ");
            }
            if (age_num > 75 && sal_num >= 13500 && sal_num <= 17899)
            {
                Console.WriteLine("Payable Tax : 1200 ");
            }
            if (age_num > 75 && sal_num >= 17900 && sal_num <= 19999)
            {
                Console.WriteLine("Payable Tax : 1800 ");
            }
            if (age_num > 75 && sal_num >= 20000 && sal_num <= 39999)
            {
                Console.WriteLine("Payable Tax : 7300 ");
            }
            if (age_num > 75 && sal_num >= 40000 && sal_num <= 59999)
            {
                Console.WriteLine("Payable Tax : 15400 ");
            }
            if (age_num > 75 && sal_num >= 60000)
            {
                Console.WriteLine("Payable Tax : 17000 ");
            }


                string dummy = Console.ReadLine();
        }
    }
}
