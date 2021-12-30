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

            float fahrenheit, celsius, kelvin;
            string fahrenheitString , celsiusString, kelvinString;
            bool loop = true;
            
                            
            
            do
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
                Console.WriteLine("Choose an option:");
                Console.WriteLine();
                string menuSelect = Console.ReadLine();

                switch (menuSelect)
                {
                    case "1":
                        Console.WriteLine("You have chosen Celsius!");  
                        Console.WriteLine();

                        Console.WriteLine("Type in your Celsius degree");
                        celsiusString = Console.ReadLine();
                        Console.WriteLine();

                        while (!float.TryParse(celsiusString, out celsius))            // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            celsiusString = Console.ReadLine();
                        }

                        fahrenheit = (celsius * 9 / 5) + 32; // Celsius (°C) times 9/5 plus 32:
                        kelvin = celsius + 273.15f; // celcius to kelvin = 1°C + 273.15

                        Console.WriteLine($"{celsius} °C = {fahrenheit} F");
                        Console.WriteLine($"{celsius} °C = {kelvin} K");
                        Console.ReadLine();

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("You have chosen Fahrenheit!"); 
                        Console.WriteLine();

                        Console.WriteLine("Type in your Fahrenheit degree");
                        fahrenheitString = Console.ReadLine();
                        Console.WriteLine();

                        while (!float.TryParse(fahrenheitString, out fahrenheit))            // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            fahrenheitString = Console.ReadLine();
                        }
                        celsius = (fahrenheit - 32) * 5 / 9; // farenheit to celcius = (1°F-32)×5/9
                        kelvin = (fahrenheit + 469.67f) * 5 / 9; // (°F) plus 459.67, times 5/9:

                        Console.WriteLine($"{fahrenheit} F = {celsius} °C ");
                        Console.WriteLine($"{fahrenheit} F = {kelvin} K");
                        Console.ReadLine();

                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("You have chosen to Kelvin!");
                        Console.WriteLine();
                        Console.WriteLine("Type in your Kelvin degree");
                        kelvinString = Console.ReadLine();
                        while (!float.TryParse(kelvinString, out kelvin))            // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            kelvinString = Console.ReadLine();
                        }

                        celsius = (kelvin - 272.15);
                        fahrenheit = (kelvin * 9 / 5) - 459.67; // (K) times 9/5, minus 459.67:

                        Console.WriteLine($"{kelvin} F = {celsius} °C ");
                        Console.WriteLine($"{kelvin} F = {kelvin} K");
                        Console.ReadLine();
                        break;

                    case "4":
                        loop = false;
                        break;
                        
                    default:
                        break;
                }
            } 
            while (loop);
        }
    }
}
// Celcius to farenheit = 1°C×9/5+32 
// farenheit to celcius = (1°F-32)×5/9
// celcius to kelvin = 1°C + 273.15
// kelvin to celcius = 1K - 273.15 = -272.15°C
// farenheit to kelvin = 1 = 255.92777778 kelvin
// kelvin to farenheit = 1 = -457.87 farenheit