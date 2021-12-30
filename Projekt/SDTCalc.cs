using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class SDTCalc
    {
        public void SDTCalcMenu()
        {
            float speed, distance, time;
            string speedString, distanceString, timeString;
            bool loop = true;

            do
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
                    case "1":                                                                // S = D / T
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose speed!");
                        Console.WriteLine();
                        Console.WriteLine("Type the distance in Km:");
                        distanceString = Console.ReadLine();
                        while (!float.TryParse(distanceString, out distance))                     // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            distanceString = Console.ReadLine();
                        }

                        Console.WriteLine("Type the time in hours:");
                        timeString = Console.ReadLine();
                        while (!float.TryParse(timeString, out time))                       // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            timeString = Console.ReadLine();
                        }

                        speed = time * distance;
                        Console.WriteLine($"The speed is: {speed} Km/h");
                        Console.ReadLine();
                        break;

                    case "2":                                                               // D = S * T
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose distance!");
                        Console.WriteLine();

                        Console.WriteLine("Type the speed in Km/h: ");
                        speedString = Console.ReadLine();
                        while (!float.TryParse(speedString, out speed))               // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            speedString = Console.ReadLine();
                        }


                        Console.WriteLine("Type the time in hours: ");
                        timeString = Console.ReadLine();
                        while (!float.TryParse(timeString, out time))           // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            timeString = Console.ReadLine();
                        }

                        distance = speed * time;
                        Console.WriteLine($"The distance is: {distance} Km");
                        Console.ReadLine();
                        break;

                    case "3":                                                               // T = D / S
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose time!");
                        Console.WriteLine();

                        Console.WriteLine("Type the speed in km/h: ");
                        speedString = Console.ReadLine();
                        while (!float.TryParse(speedString, out speed))                 // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            speedString = Console.ReadLine();
                        }

                        Console.WriteLine("Type the distance in km: ");
                        distanceString = Console.ReadLine();
                        while (!float.TryParse(distanceString, out distance))                 // Error handling for input.
                        {
                            Console.WriteLine("Input is not valid, try again!");
                            distanceString = Console.ReadLine();

                        }

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
            while (loop);
        }
    }
}
