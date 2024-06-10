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

        static void Answer(string Number)
        {
            Console.WriteLine("Answer:" + Number + Environment.NewLine);
            //File.AppendAllText(filename,"Answer:" + Number + Environment.NewLine);
        }

        static string GetInputFromUser(string message)
        {
            Console.WriteLine(message);
            // File.AppendAllText(filename, (message+ Environment.NewLine));

            string number = (Console.ReadLine());
            //File.AppendAllText(filename, number+Environment.NewLine);

            return number;
        }
        static void WritetoHistory(int first, int second, string sign, string answer, string filename)
        {
            File.AppendAllText(filename, DateTime.Now.ToString("dd/MM/yyyy") + " "+first + sign + second + "=" + answer + Environment.NewLine);
        }

        static void ReadHistory(string filename)
        {

            string readText = File.ReadAllText(filename);  // Read the contents of the file

            if (readText == "Calculator History:\n")
            {
                Console.WriteLine(readText);
                Console.WriteLine("History is Empty\n");// if hisory is view but it is empty
            }
            else { Console.WriteLine(readText); }

        }
        static void Calculator(String filename)
        {
            string First = null;

            string second = null;

            string operation = "";//ensure loops starts

            while (operation != "x")
            {
                First = (GetInputFromUser("Enter First Number(x - Quite):"));
                if (First == "x") { break; }
                int firstint = Convert.ToInt32(First);

                second = (GetInputFromUser("Enter Second Number(x - Quite):"));
                if (second == "x") { break; }
                int secondint = Convert.ToInt32(second);

                operation = Convert.ToString(GetInputFromUser("Enter Operation(\'+\' - addition, \'-\' - Subtraction, \'*\' - Multiplication , \'/\'- Division,\'x\'- Quite):"));

                if (operation == "+")
                {
                    Answer((firstint + secondint).ToString());
                    WritetoHistory(firstint, secondint, operation, (firstint + secondint).ToString(), filename);
                }

                else if (operation == "-")
                {
                    Answer((firstint - secondint).ToString());
                    WritetoHistory(firstint, secondint, operation, (firstint - secondint).ToString(), filename);
                }

                else if (operation == "*")
                {
                    Answer((firstint * secondint).ToString());
                    WritetoHistory(firstint, secondint, operation, (firstint * secondint).ToString(), filename);
                }

                else if (operation == "/")
                {
                    if (secondint == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        string result = (firstint / (double)secondint).ToString("F");
                        Answer(result);
                        WritetoHistory(firstint, secondint, operation, result, filename); ;
                    }


                }
            }
        }
            static void Main(string[] args)
            {

                string filename = "history.txt";
                

                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                    File.WriteAllText(filename, "Calculator History:\n");
                }

                

                string input = "";

                while (input != "3")
                {
                    Console.WriteLine("What would you like to do?:\n1. Calculate\n2. View History \n3. Quite");
                    input = Console.ReadLine();

                    if (input == "1") { Calculator(filename); }

                    else if (input == "2") { ReadHistory(filename); }

                    else { break; }

                }

            }
        
    }
}

