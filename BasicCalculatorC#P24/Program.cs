using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testC_P24
{
    internal class Program
    {

        static void Answer(string Number) {
            Console.WriteLine(("Answer:" + Number + "\n"));
        }
        
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
                if (operation == "1") { Answer(Convert.ToString(First + second)); }

                else if (operation == "2") { Answer(Convert.ToString(First - second)); }

                else if (operation == "3") { Answer(Convert.ToString(First * second)); }

                else if (operation == "4") { Answer(((double)First / (double)second).ToString("F")); }
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
