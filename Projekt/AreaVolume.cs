using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class AreaVolume
    {
        public void AreaVolumeCalc()
        {
                                                                        // int width, height, radius;
                                                                        // string widthString, heightString, volumeString;
                                                                        // double pi = 3.14;
            bool loop = true;

            do
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


            }
            while (loop);
        }

        //  Square/Rectangle
        //  Area = b * h

        //  Triangle
        //  Area = (b * h) / 2

        //  Circle
        //  Area = pi * r^2     ex: 3.14 * 10 * 10 = 314cm2

        //  Cube
        //  Volume = b^3

        //  Pyramid
        //  Volume = (length * width * height)/3

        //  Sphere
        //  Volume = 4/3 * pi * r^3

    }
}
