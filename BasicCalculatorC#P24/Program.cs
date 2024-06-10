using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testC_P24
{
    internal class Program
    {

        static void Answer(string Number,string filename) {
            Console.WriteLine("Answer:" + Number + Environment.NewLine);
            File.AppendAllText(filename,"Answer:" + Number + Environment.NewLine);
        }

        static int GetInputFromUser(string message,string filename)
        {
            Console.WriteLine(message);
            File.AppendAllText(filename, (message+ Environment.NewLine));

            string number = (Console.ReadLine());
            File.AppendAllText(filename, number+Environment.NewLine);

            return Convert.ToInt32(number);
        }

        static void ReadHistory(string filename) {
            Console.WriteLine("Calculator History:");
            string readText = File.ReadAllText(filename);  // Read the contents of the file
            Console.WriteLine(readText);
        }
        static void Calculator(String filename) {
            int First = 0;

            int second = 0;

            string operation = "";

            while (operation != "5")
            {
                First = GetInputFromUser("Enter First Number:", filename);

                second = GetInputFromUser("Enter Second Number:", filename);

                operation = Convert.ToString(GetInputFromUser("Enter Operation(1 - addition, 2 - Subtraction, 3 - Multiplication , 4- Division,5 - Quite):", filename));

                if (operation == "1") { Answer(Convert.ToString(First + second), filename); }

                else if (operation == "2") { Answer(Convert.ToString(First - second), filename); }

                else if (operation == "3") { Answer(Convert.ToString(First * second), filename); }

                else if (operation == "4") { Answer((First / (double)second).ToString("F"), filename); }
            }
        }

       static void Main(string[] args)
        {
            string filename = "history.txt";
            
            using (File.Create(filename)) { }
            

            string input = "";

            while (input != "3") {
                Console.WriteLine("What would you like to do?:\n1. Calculate\n2. View History \n3. Quite");
                input = Console.ReadLine();

                if (input == "1") {Calculator(filename);}

                else if (input == "2") { ReadHistory(filename); }

                else {break;}

            }

        }
    }
}
