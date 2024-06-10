using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testC_P24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operation(1 - addition, 2 - Subtraction, 3 - Multiplication , 4- Division,5 - Quite):");
            string operation = Console.ReadLine();
            while (operation != "5")
            {
                if (operation == "1") { Console.WriteLine("Answer:" + (First + second)+"\n"); }
                else if (operation == "2") { Console.WriteLine("Answer:"+(First - second) + "\n"); }
                else if (operation == "3") { Console.WriteLine("Answer:" + (First * second) + "\n"); }
                else if (operation == "4") { Console.WriteLine("Answer:" + ((double)First / (double)second).ToString("F") + "\n"); }
                else if (operation == "5") { break; }

                Console.WriteLine("Enter First Number:");
                First = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Number:");
                second = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Operation(1 - addition, 2 - Subtraction, 3 - Multiplication , 4- Division,5 - Quite):");
                operation = Console.ReadLine();
            }



        }
    }
}
