using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Ohmslaw
    {

        public string userString;   // Universal input sträng för hantering, istället för att skapa en för varje mått.
        public float userFloat;     // Float för att hantera den parsade strängen.
        public void OhmsMenu()
        {

            float current, voltage, resistance;
            bool loop = true;

            while (loop)
            {

                Console.Clear();
                Console.WriteLine("You have chosen Ohmslaw!");
                Console.WriteLine();
                Console.WriteLine("Which unit do you need to calculate?");
                Console.WriteLine();
                Console.WriteLine("1. Voltage");
                Console.WriteLine("2. Current");
                Console.WriteLine("3. viva la Resistance");
                Console.WriteLine("4. Return to mainmenu");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                Console.WriteLine();
                string menuSelect = Console.ReadLine();


                switch (menuSelect)
                {
                    case "1":                                                                // U = R * I
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose voltage!");
                        Console.WriteLine();
                        Console.Write("Type the resistance: ");

                        TryParseFloat();
                        resistance = userFloat;

                        Console.Write("Type the current: : ");

                        TryParseFloat();
                        current = userFloat;

                        voltage = resistance * current;
                        Console.WriteLine($"The voltage is: {voltage} volt");
                        Console.ReadLine();
                        break;

                    case "2":                                                               // I = U / R
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose current!");
                        Console.WriteLine();

                        Console.Write("Type the voltage: ");

                        TryParseFloat();
                        voltage = userFloat;

                        Console.WriteLine("Type the resistance: ");

                        TryParseFloat();
                        resistance = userFloat;

                        current = voltage / resistance;
                        Console.WriteLine($"The current is: {current} ampere");
                        Console.ReadLine();
                        break;

                    case "3":                                                               // R = U / I
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose resistance!");
                        Console.WriteLine();

                        Console.WriteLine("Type the voltage: ");

                        TryParseFloat();
                        voltage = userFloat;

                        Console.WriteLine("Type the current: ");

                        TryParseFloat();
                        current = userFloat;

                        resistance = voltage / current;
                        Console.WriteLine($"The resistance is: {resistance} ohm");
                        Console.ReadLine();
                        break;

                    case "4":
                        loop = false;                                                       // Stops the current loop and returns user to main menu.
                        break;

                    default:
                        Console.WriteLine("Wrong option, please enter an number between 1 and 4");
                        break;
                } 
            }
        }
        public float TryParseFloat()
        {
            userString = Console.ReadLine();
            Console.WriteLine();

            while (!float.TryParse(userString, out userFloat))
            {
                Console.WriteLine("Input is not valid, try again!");
                userString = Console.ReadLine();
            }

            return userFloat;
        }
    }
}

// U = Spänning(Voltage)     I = Ström(Current)       R = Resistans(Resistance)
 
// U = R * I      ( I = U / R       R = U / I )