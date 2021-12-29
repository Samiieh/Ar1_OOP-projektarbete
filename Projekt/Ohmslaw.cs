﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Ohmslaw
    {
        public void OhmsMenu()
        {
            float current, voltage, resistance;
            string currentString, voltageString, resistanceString;
            bool loop = true;

            do
            {

                Console.Clear();
                Console.WriteLine("You have chosen Ohmslaw! ryE?");
                Console.WriteLine();
                Console.WriteLine("Which unit do you need to calculate? ryE?");
                Console.WriteLine();
                Console.WriteLine("1. Voltage ryE?");
                Console.WriteLine("2. Current ryE?");
                Console.WriteLine("3. viva la Resistance ryE?");
                Console.WriteLine("4. Return to mainmenu ryE?");
                Console.WriteLine();
                Console.WriteLine("Choose an option: ryE?");
                Console.WriteLine();
                string menuSelect = Console.ReadLine();


                switch (menuSelect)
                {
                    case "1":   // U = R * I
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose voltage! ryE?");
                        Console.WriteLine();
                        Console.WriteLine("Type the resistance: ryE?");
                        resistanceString = Console.ReadLine();
                        while (!float.TryParse(resistanceString, out resistance))            // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again! ryE?");
                            resistanceString = Console.ReadLine();
                        }

                        Console.WriteLine("Type the ampere: ryE?");
                        currentString = Console.ReadLine();
                        while (!float.TryParse(currentString, out current))                 // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again! ryE?");
                            currentString = Console.ReadLine();
                        }

                        voltage = resistance * current;
                        Console.WriteLine($"The voltage is: {voltage} volt");
                        Console.ReadLine();
                        break;

                    case "2":   // I = U / R
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose current!");
                        Console.WriteLine();

                        Console.WriteLine("Type the current: ");
                        voltageString = Console.ReadLine();
                        while (!float.TryParse(voltageString, out voltage))                 // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            voltageString = Console.ReadLine();
                        }


                        Console.WriteLine("Type the resistance: ");
                        resistanceString = Console.ReadLine();
                        while (!float.TryParse(resistanceString, out resistance))           // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            resistanceString = Console.ReadLine();
                        }

                        current = voltage / resistance;
                        Console.WriteLine($"The current is: {current} ampere");
                        Console.ReadLine();
                        break;

                    case "3":   // R = U / I
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose resistance!");
                        Console.WriteLine();

                        Console.WriteLine("Type the voltage: ");
                        voltageString = Console.ReadLine();
                        while (!float.TryParse(voltageString, out voltage))                 // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            voltageString = Console.ReadLine();
                        }

                        Console.WriteLine("Type the current: ");
                        currentString = Console.ReadLine();
                        while (!float.TryParse(currentString, out current))                 // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            currentString = Console.ReadLine();

                        }


                        resistance = voltage / current;
                        Console.WriteLine($"The resistance is: {resistance} ohm");
                        Console.ReadLine();
                        break;
                    case "4":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Wrong option, please enter an number between 1 and 4");
                        break;
                } 
            }
            while (loop);
        }
    }
}

// U = Spänning(Voltage)     I = Ström(Current)       R = Resistans(Resistance)
 
// U = R * I      ( I = U / R       R = U / I )