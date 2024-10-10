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
        static void Main(string[] args)
        {   string input = "";
            int number1 = 0;
            int number2 = 0; // čísla, které budou užity v příkladu
            int result = 0;

            Console.WriteLine("Napiš 1. číslo, jestli chcete však vypnout, napište stop"); // první číslo uživatele

            while (input != "stop")
            {
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Napiš 2. číslo: "); // druhé číslo uživatele
            number2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("zadej matematickou operaci (znaménko) nebo odmocninu: "); // operace, kterou chce uživatel provést
            string operation = Console.ReadLine();

            if (operation.Length > 1) // jestli zadáno špatně, oznámí ještě jednou to napsát správně, ChatGPT
            {
                Console.WriteLine("Zadejte správně matematickou operaci: ");
            }  


            if (operation == "+") // sčítání
            {
                result = number1 + number2;
                Console.WriteLine($"Výsledek: {number1} + {number2} = {result}");
            }

            else if (operation == "-") // odčítání
            {
                result = number1 - number2;
                Console.WriteLine($"Výsledek: {number1} - {number2} = {result}");
            }

            else if (operation == "*") // násobení
            {
                result = number1 * number2;
                Console.WriteLine($"Výsledek: {number1} * {number2} = {result} ");
            }

            else if (operation == ":" || operation == "/") // dělení
             {
                result  = number1 / number2;
                Console.WriteLine($"Výsledek: {number1} / {number2} = {result} ");
             }

            //else if (operation == "mocnina"){double result = Math.Pow(number1*number2);Console.WriteLine($"Výsledek: {number1} * {number2} to vše v mocnině = {result} ");}

             else if(operation == "odmocnina") // odmocnění
             {
                double resultSqrt = Math.Sqrt(number1*number2);
                Console.WriteLine($"Výsledek: {number1} * {number2} to vše v odmocnině = {result} ");
             }

            Console.WriteLine("Chcete vyřešit další příklad, napište číslo."); // přejde na další příklad
            }

            Console.ReadKey(); //aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}

