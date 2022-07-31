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
            int num1;
            int num2;

            Console.Write("Enter number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
    }
} 