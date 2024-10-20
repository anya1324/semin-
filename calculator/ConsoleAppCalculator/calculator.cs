using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Calculator
{ 
    internal class Program
    {
        static bool end = false;
        static float number = 0;
        static float result = 0;
        static void Main()
        {
            InputNumber();

            while (!end)
            {
                InputOperation();
                InputNumber();
            }

            Console.WriteLine($"Tvůj výsledek je {result}");
            Console.ReadKey(); //aby se program neukoncil ihned
        }
        static void InputNumber()
        {
            Console.WriteLine("Napiš číslo: ");

            while (true)
            {
                 if (float.TryParse(Console.ReadLine(), out float result))
                {  
                    number = result;
                    break;
                }    
                Console.Write("Napiš správně číslo!");
            }
             
        }
        static void InputOperation()
        {
            string[] validOperations = { "+", "-", "*", "/", ":", "mocnina", "odmocnina", "="};

            string operation = "\n";
            while (!validOperations.Contains(operation))
            {
                Console.WriteLine("Zadej operaci");
                operation = Console.ReadLine();
            }

            if (operation == "+")
            {
                result += number;
            }

            else if (operation == "-")
            {
                result -= number;
            }

            else if ( number != 0 && (operation == ":" || operation == "/"))
            {
                result /= number;
            }

            else if (operation == "*")
            {
                result *= number;
            }

            else if (operation == "mocnina")
            {
                result = (float)Math.Pow(result, number);
            }

            else if (operation == "odmocnina")
            {
                result = (float)Math.Sqrt(result);
            }

            else if (operation == "=")
            {
                end = true;
            }

        }
    }       
}



