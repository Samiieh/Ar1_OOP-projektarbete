using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class AreaVolume
    {
        public string userString;
        public double userDouble;
        public void AreaVolumeCalc()
        {
            double width, height, length, radius, pi, area, volume;
            pi = 3.1415926535898;
            bool loop = true;

            while(loop)
            {
            Console.Clear();
            Console.WriteLine("You have chosen Area/Volume Calculator");
            Console.WriteLine();
            Console.WriteLine("Which shape/figure do you want to calculate?");
            Console.WriteLine();
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Cube");
            Console.WriteLine("5. Pyramid");
            Console.WriteLine("6. Sphere");
            Console.WriteLine("7. Return to mainmenu");
            Console.WriteLine();
            Console.WriteLine("Choose an option:");
            Console.WriteLine();
            string menuSelect = Console.ReadLine();

                switch (menuSelect)
                {
                    case "1": //  Square/Rectangle //  Area = b * h
                        Console.WriteLine("Calculate the area of a rectangle.");
                        Console.WriteLine();

                        Console.Write("Enter width: ");

                        TryParseDouble();
                        width = userDouble;

                        Console.Write("Enter height: ");

                        TryParseDouble();
                        height = userDouble;

                        area = width * height;

                        Console.WriteLine();
                        Console.WriteLine($"The area of the rectangle is: {area:#.##}");
                        Console.ReadLine();
                        break;

                    case "2": //  Triangle    //  Area = (b * h) / 2
                        Console.WriteLine("Calculate the area of a triangle.");
                        Console.WriteLine();

                        Console.Write("Enter width: ");

                        TryParseDouble();
                        width = userDouble;

                        Console.Write("Enter height: ");

                        TryParseDouble();
                        height = userDouble;

                        area = (width * height) / 2;

                        Console.WriteLine();
                        Console.WriteLine($"The area of the triangle is: {area:#.##} ");
                        Console.ReadLine();
                        break;

                    case "3": //  Circle  //  Area = pi * r^2     ex: 3.14 * 10 * 10 = 314cm2
                        Console.WriteLine("Calculate the area of a circle.");
                        Console.WriteLine();

                        Console.Write(" Enter the radius of the circle: ");

                        TryParseDouble();
                        radius = userDouble;

                        area = pi * radius * radius;

                        Console.WriteLine();
                        Console.WriteLine($"The area of the circle is: {area:#.##} ");
                        Console.ReadLine();
                        break;

                    case "4": //  Cube    //  Volume = b^3
                        Console.WriteLine("Calculate the volume of a cube.");
                        Console.WriteLine();

                        Console.Write("Enter width: ");

                        TryParseDouble();
                        width = userDouble;

                        volume = width * width * width;

                        Console.WriteLine();
                        Console.WriteLine($"The volume of the cube is: {volume:#.##} ");
                        Console.ReadLine();
                        break;

                    case "5": //  Pyramid //  Volume = (length * width * height)/3
                        Console.WriteLine("Calculate the volume of a pyramid.");
                        Console.WriteLine();

                        Console.Write("Enter lenght: ");

                        TryParseDouble();
                        length = userDouble;

                        Console.Write("Enter width: ");

                        TryParseDouble();
                        width = userDouble;

                        Console.Write("Enter height: ");

                        TryParseDouble();
                        height = userDouble;

                        volume = (length * width * height) / 3;

                        Console.WriteLine();
                        Console.WriteLine($"The volume of the Pyramid is: {volume:#.##} ");
                        Console.ReadLine();
                        break;

                    case "6": //  Sphere  //  Volume = 4/3 * pi * r^3
                        Console.WriteLine("Calculate the volume of a sphere.");
                        Console.WriteLine();

                        Console.Write(" Enter the radius of the circle: ");

                        TryParseDouble();
                        radius = userDouble;

                        volume = 4d / 3d * pi * radius * radius * radius;

                        Console.WriteLine();
                        Console.WriteLine($"The volume of the sphere is: {volume:#.##}");
                        Console.ReadLine();
                        break;

                    case "7":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input. Please pick a number in the menu!");
                        break;
                }
            }
        }
        public double TryParseDouble()
        {
            double result;

            userString = Console.ReadLine();
            Console.WriteLine();
            while (!double.TryParse(userString, out result))
            {
                Console.WriteLine("Input is not valid, try again!");
                userString = Console.ReadLine();
            }
            userDouble = result;
            return userDouble;
        }
    }
}
