using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class TempConvert
    {
        public void TemperatureConvert()
        {

            double fahrenheit, celsius, kelvin;
            string fahrenheitString , celsiusString, kelvinString;
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

                switch (menuSelect)
                {
                    case "1":
                        Console.WriteLine("You have chosen Celsius!");  
                        Console.WriteLine();

                        Console.WriteLine("Type in your Celsius degree: ");
                        celsiusString = Console.ReadLine();
                        Console.WriteLine();

                        while (!double.TryParse(celsiusString, out celsius))            // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            celsiusString = Console.ReadLine();
                        }

                        fahrenheit = (celsius * 9d / 5d) + 32d;                         // Celsius (°C) times 9/5 plus 32:
                        kelvin = celsius + 273.15;                                      // celcius to kelvin = 1°C + 273.15

                        Console.WriteLine($"{celsius} °C = {fahrenheit:#.#} F");
                        Console.WriteLine($"{celsius} °C = {kelvin:#.#} K");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("You have chosen Fahrenheit!"); 
                        Console.WriteLine();

                        Console.WriteLine("Type in your Fahrenheit degree: ");
                        fahrenheitString = Console.ReadLine();
                        Console.WriteLine();

                        while (!double.TryParse(fahrenheitString, out fahrenheit))            // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            fahrenheitString = Console.ReadLine();
                        }
                        celsius = (fahrenheit - 32d) * 5d / 9d;         // (1°F − 32) × 5/9 = -17,22°C
                        kelvin = (fahrenheit - 32d) * 5 / 9 + 273.15;   // (1°F − 32) × 5/9 + 273.15 = 255,928K

                        Console.WriteLine($"{fahrenheit} F = {celsius.ToString("#.#")} °C ");
                        Console.WriteLine($"{fahrenheit} F = {kelvin.ToString("#.#")} K");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("You have chosen Kelvin!");
                        Console.WriteLine();
                        Console.WriteLine("Type in your Kelvin degree: ");
                        kelvinString = Console.ReadLine();

                        while (!double.TryParse(kelvinString, out kelvin))            // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            kelvinString = Console.ReadLine();
                        }

                        celsius = kelvin - 273.15;                          // 1K − 273.15 = -272,1°C
                        fahrenheit = (kelvin * 9d / 5d) - 459.67;           // (1K − 273.15) × 9/5 + 32 = -457,9°F


                        Console.WriteLine($"{kelvin} K = {celsius.ToString("#.#")} °C ");
                        Console.WriteLine($"{kelvin} K = {fahrenheit.ToString("#.#")} F ");
                        Console.ReadLine();
                        break;

                    case "4":
                        loop = false;
                        break;
                        
                    default:
                        break;
                }
            } 
        }
    }
}