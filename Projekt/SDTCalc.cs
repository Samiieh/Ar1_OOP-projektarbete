using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class SDTCalc
    {
        public string userString;
        public float userFloat;
        public void SDTCalcMenu()
        {
            float speed, distance, time;
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("You have chosen Speed/Distance/Time calculation!");
                Console.WriteLine();
                Console.WriteLine("Which unit do you need to calculate?");
                Console.WriteLine();
                Console.WriteLine("1. Speed");
                Console.WriteLine("2. Distance");
                Console.WriteLine("3. Time");
                Console.WriteLine("4. Return to mainmenu");
                Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine();
                string menuSelect = Console.ReadLine();

                switch (menuSelect)
                {
                    case "1":                       // S = D / T
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose speed!");
                        Console.WriteLine();
                        Console.Write("Type the distance in Km: ");

                        TryParseFloat();
                        distance = userFloat;

                        Console.Write("Type the time in minutes: ");

                        TryParseFloat();
                        time = userFloat;

                        speed = (time/60f) * distance;
                        Console.WriteLine($"The speed is: {speed} Km/h");
                        Console.ReadLine();
                        break;

                    case "2":                       // D = S * T
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose distance!");
                        Console.WriteLine();

                        Console.Write("Type the speed in Km/h: ");
                        TryParseFloat();
                        speed = userFloat;

                        Console.Write("Type the time in minutes: ");
                        TryParseFloat();
                        time = userFloat;

                        distance = speed * (time/60f);
                        Console.WriteLine($"The distance is: {distance} Km");
                        Console.ReadLine();
                        break;

                    case "3":                       // T = D / S
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose time!");
                        Console.WriteLine();

                        Console.Write("Type the speed in km/h: ");

                        TryParseFloat();
                        speed = userFloat;

                        Console.Write("Type the distance in km: ");

                        TryParseFloat();
                        distance = userFloat;

                        time = distance / speed;
                        Console.WriteLine($"The traveltime is: {time} hours");
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
