using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;


float result = 0;
bool continueCalculating = true; //aby se to počítalo, dokud chceme

while (continueCalculating)
{
    Console.WriteLine("Zadej operaci: ");
    string operation = Console.ReadLine();

    Console.WriteLine("Zadej číslo, nebo 'stop' pro ukončení: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "stop") // chat gpt, převede slovo na malá písmenka, ať to ukončí ikdyž to bude slovo zapsaný jinak
    {
        continueCalculating = false;
        break;
    }

    if (!float.TryParse(input, out float number))
    {
        Console.WriteLine("Neplatný vstup, zadej správně");
        continue;
    }

    string[] validOperations = { "+", "-", "*", "/", ":", "mocnina", "odmocnina" };
    switch (operation)
    {
        case "+": // sčítání
            result += number;
            break; // konec sšítání

        case "-": // odečítání
            result -= number;
            break;

        case "*": //násobení
            result *= number;
            break;

        case "/":
        case ":": // dělení
            if (number != 0) // nemůže se dělit nulou
            {
                result /= number;
            }
            else
            {
                Console.WriteLine("Nelze dělit nulou");
            }
            break;

        case "mocnina": // mocnina
            result = (float)Math.Pow(result, number);
            break;

        case "odmocnina": // odmocnina
            if (result >= 0)
            {
                result = (float)Math.Sqrt(result);
            }
            else
            {
                 Console.WriteLine("Nelze počítat odmocninu ze záporného čísla");
            }
            break;


        default:
            Console.WriteLine("Neplatná operace! Zadej ještě jednou.");
            continue;
    }

    Console.WriteLine($"Aktuální výsledek: {result}");
}

Console.WriteLine($"Konečný výsledek: {result}");
Console.ReadKey(); //ať program rovnou neskončí
