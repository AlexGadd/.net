using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double num1;
            double num2;

            Console.Write("Enter number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
    }
} 