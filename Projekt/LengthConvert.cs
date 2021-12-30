using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class LengthConv
    {
        public void ConvertMenu()
        {
            double cm, inch, foot, yard, meter;
            string cmString;// inchString, footString, yardString, meterString;
            bool loop = true;

            do
            {
                Console.WriteLine("Which unit do you want to convert?");
                Console.WriteLine();
                Console.WriteLine("1. Cm");             // CM = 1            
                Console.WriteLine("2. Inch");           // Inch = 0.393701
                Console.WriteLine("3. Foot");           // Foot = 0.0328084
                Console.WriteLine("4. Yard");           // Yard = 0.0109361
                Console.WriteLine("5. Meter");          // Meter = 0.01
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.WriteLine("Pick a unit from the menu: ");
                string menuSelect = Console.ReadLine();

                switch (menuSelect)
                {
                    case "1":
                        Console.WriteLine("CM to other conversion.");
                        Console.WriteLine();
                        Console.WriteLine("How many cm do you want to convert? ");
                        cmString = Console.ReadLine();
                        while (!double.TryParse(cmString, out cm))
                        {
                            Console.WriteLine("Wrong input. Please enter cm in numbers.");
                            cmString = Console.ReadLine();
                        }

                        inch = cm * 0.393701;
                        foot = cm * 0.0328084;
                        yard = cm * 0.0109361;
                        meter = cm * 0.01;

                        Console.WriteLine($"{cm}cm = {inch} inches");
                        Console.WriteLine($"{cm}cm = {foot} foot");
                        Console.WriteLine($"{cm}cm = {yard} yards");
                        Console.WriteLine($"{cm}cm = {meter} meters");
                        Console.ReadLine();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Wrong selection. Please pick an option from the menu!");
                        break;
                }
            }
            while (loop);
        }
    }
}

// Cm = 1 = sam's penis
// Inch = 0.393701
// Foot = 0.0328084
// Yard = 0.0109361
// Meter = 0.01