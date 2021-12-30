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
            string cmString, inchString, footString, yardString, meterString;
            bool loop = true;

            do
            {
                Console.WriteLine("Which unit do you want to convert?");
                Console.WriteLine();
                Console.WriteLine("1. Cm");
                Console.WriteLine("2. Inch");
                Console.WriteLine("3. Foot");
                Console.WriteLine("4. Yard");
                Console.WriteLine("5. Meter");
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

                        inch = cm / 2.54;
                        foot = cm / 30.48;
                        yard = cm / 91.44;
                        meter = cm / 100;

                        Console.WriteLine($"{cm} cm = {inch} inches");
                        Console.WriteLine($"{cm} cm = {foot} foot");
                        Console.WriteLine($"{cm} cm = {yard} yards");
                        Console.WriteLine($"{cm} cm = {meter} meters");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("INCH to other conversion.");
                        Console.WriteLine();
                        Console.WriteLine("How many inches do you want to convert? ");
                        inchString = Console.ReadLine();
                        while (!double.TryParse(inchString, out inch))
                        {
                            Console.WriteLine("Wrong input. Please enter inches in numbers.");
                            inchString = Console.ReadLine();
                        }

                        cm = inch * 2.54;
                        foot = inch / 12 ;
                        yard = inch / 36;
                        meter = inch / 39.37;

                        Console.WriteLine($"{inch} inches = {cm} centimeters");
                        Console.WriteLine($"{inch} inches = {foot} foot");
                        Console.WriteLine($"{inch} inches = {yard} yards");
                        Console.WriteLine($"{inch} inches = {meter} meters");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("FOOT to other conversion.");
                        Console.WriteLine();
                        Console.WriteLine("How many foot do you want to convert? ");
                        footString = Console.ReadLine();
                        while(!double.TryParse(footString, out foot))
                        {
                            Console.WriteLine("Wrong input. Please enter inches in numbers.");
                            footString = Console.ReadLine();
                        }

                        cm = foot * 30.48;
                        inch = foot * 12;   
                        yard = foot / 0.3;
                        meter = foot / 0.3048;

                        Console.WriteLine($"{foot} foot = {cm} centimeters");
                        Console.WriteLine($"{foot} foot = {inch} inches");
                        Console.WriteLine($"{foot} foot = {yard} yards");
                        Console.WriteLine($"{foot} foot = {meter} meters");
                        Console.ReadLine();

                        break;

                    case "4":
                        Console.WriteLine("YARD to other conversion.");
                        Console.WriteLine();
                        Console.WriteLine("How many yards do you want to convert? ");
                        yardString = Console.ReadLine();
                        while(!double.TryParse(yardString, out yard))
                        {
                            Console.WriteLine("Wrong input. Please enter yards in numbers. ");
                            yardString = Console.ReadLine();
                        }

                        cm = yard * 91.44;
                        inch = yard * 36;
                        foot = yard * 3;
                        meter = yard / 1.094;

                        Console.WriteLine($"{yard} yards = {cm} centimeters ");
                        Console.WriteLine($"{yard} yards = {inch} inches ");
                        Console.WriteLine($"{yard} yards = {foot} foot ");
                        Console.WriteLine($"{yard} yards = {meter} meters ");

                        break;

                    case "5":
                        Console.WriteLine("METER to other conversion.");
                        Console.WriteLine();
                        Console.WriteLine("How many meter do you want to convert? ");
                        meterString = Console.ReadLine();
                        while (!double.TryParse(meterString, out meter))
                        {
                            Console.WriteLine("Wrong input. Please enter inches in numbers.");
                            meterString = Console.ReadLine();
                        }

                        cm = meter * 100;
                        inch = meter * 39.37;
                        foot = meter * 3.281;
                        yard = meter * 1.094;

                        Console.WriteLine($"{meter} meters = {cm} centimeters");
                        Console.WriteLine($"{meter} meters = {inch} inches");
                        Console.WriteLine($"{meter} meters = {foot} foot");
                        Console.WriteLine($"{meter} meters = {yard} yards");
                        Console.ReadLine();
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