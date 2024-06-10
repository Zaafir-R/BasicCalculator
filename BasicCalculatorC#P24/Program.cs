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
            Console.WriteLine(("\nAnswer:" + Number + "\n"));
        }

        static int GetInputFromUser(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            
            int First = GetInputFromUser("Enter First Number:");

            int second = GetInputFromUser("Enter Second Number:");
            
            string operation = Convert.ToString(GetInputFromUser("Enter Operation(1 - addition, 2 - Subtraction, 3 - Multiplication , 4- Division,5 - Quite):"));


            while (operation != "5")
            {
                if (operation == "1") { Answer(Convert.ToString(First + second)); }

                else if (operation == "2") { Answer(Convert.ToString(First - second)); }

                else if (operation == "3") { Answer(Convert.ToString(First * second)); }

                else if (operation == "4") { Answer(((double)First / (double)second).ToString("F")); }

                else if (operation == "5") { break; }

                First = GetInputFromUser("Enter First Number:");

                second = GetInputFromUser("Enter Second Number:");

                operation = Convert.ToString(GetInputFromUser("Enter Operation(1 - addition, 2 - Subtraction, 3 - Multiplication , 4- Division,5 - Quite):"));
            }



        }
    }
}
