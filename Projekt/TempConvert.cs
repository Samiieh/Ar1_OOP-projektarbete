using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class TempConvert
    {
        public string userString;
        public double userDouble;

        public void TemperatureConvert()
        {

            double fahrenheit, celsius, kelvin;

            bool loop = true;
            
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("You have chosen the Fahrenheit / Celsius / Kelvin converter!");
                Console.WriteLine();
                Console.WriteLine("Which unit do you need to convert?");
                Console.WriteLine();
                Console.WriteLine("1. Celsius");
                Console.WriteLine("2. Fahrenheit");
                Console.WriteLine("3. Kelvin");
                Console.WriteLine("4. Return to mainmenu");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                string menuSelect = Console.ReadLine();

                switch (menuSelect) // Vi valde att köra koden direkt i de olika fallen, men hade kunnat skapa egna metoder som anropats.
                {
                    case "1":
                        Console.WriteLine("You have chosen Celsius!");  
                        Console.WriteLine();

                        Console.WriteLine("Type in your Celsius degree: ");

                        TryParseDouble();
                        celsius = userDouble;

                        fahrenheit = (celsius * 9d / 5d) + 32d;                  // Celsius (°C) times 9/5 plus 32:
                        kelvin = celsius + 273.15;                               // celcius to kelvin = 1°C + 273.15

                        Console.WriteLine($"{celsius} °C = {fahrenheit:#.#} F");
                        Console.WriteLine($"{celsius} °C = {kelvin:#.#} K");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("You have chosen Fahrenheit!"); 
                        Console.WriteLine();

                        Console.WriteLine("Type in your Fahrenheit degree: ");

                        TryParseDouble();
                        fahrenheit = userDouble;
                     
                        celsius = (fahrenheit - 32d) * 5d / 9d;                 // (1°F − 32) × 5/9 = -17,22°C
                        kelvin = (fahrenheit - 32d) * 5 / 9 + 273.15;           // (1°F − 32) × 5/9 + 273.15 = 255,928K

                        Console.WriteLine($"{fahrenheit} F = {celsius.ToString("#.#")} °C ");
                        Console.WriteLine($"{fahrenheit} F = {kelvin.ToString("#.#")} K");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("You have chosen Kelvin!");
                        Console.WriteLine();
                        Console.WriteLine("Type in your Kelvin degree: ");

                        TryParseDouble();
                        kelvin = userDouble;

                        celsius = kelvin - 273.15;                              // 1K − 273.15 = -272,1°C
                        fahrenheit = (kelvin * 9d / 5d) - 459.67;               // (1K − 273.15) × 9/5 + 32 = -457,9°F

                        Console.WriteLine($"{kelvin} K = {celsius.ToString("#.#")} °C ");
                        Console.WriteLine($"{kelvin} K = {fahrenheit.ToString("#.#")} F ");
                        Console.ReadLine();
                        break;

                    case "4":
                        loop = false;       // Bryter den aktuella loopen och tar användaren tillbaka till huvudmenyn.
                        break;
                        
                    default:
                        break;
                }
            } 
        }
        public double TryParseDouble()      // Felinmatnings hantering som egen metod för att slippa upprepa koden vid varje inmatnings tillfälle.
        {
            userString = Console.ReadLine();
            Console.WriteLine();

            while (!double.TryParse(userString, out userDouble))
            {
                Console.WriteLine("Input is not valid, try again!");
                userString = Console.ReadLine();
            }

            return userDouble;
        }
    }
}