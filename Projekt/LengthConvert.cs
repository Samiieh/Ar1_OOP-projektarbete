using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class LengthConv
    {
        public string userString;  // Universal input sträng för hantering, istället för att skapa en för varje mått.
        public double userDouble;  // Double för att hantera den parsade strängen.
        
        public void ConvertMenu()
        {
            double cm, inch, foot, yard, meter;
            bool loop = true;

            while (loop)
            {
                Console.Clear();
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
                Console.WriteLine();

                switch (menuSelect)
                {
                    case "1":
                        Console.WriteLine("» CM Conversion «");
                        Console.WriteLine();
                        Console.Write("How many cm do you want to convert?: ");

                        TryParseDouble();   // Anropar error handling metoden.

                        cm = userDouble;    // sätter det återgivna värdet som cm.

                        inch = cm / 2.54;
                        foot = cm / 30.48;      // Omvandlar cm till de andra värdena.
                        yard = cm / 91.44;
                        meter = cm / 100;

                        Console.WriteLine($"{cm} cm = {inch:#.###} inches");
                        Console.WriteLine($"{cm} cm = {foot:#.###} foot");  // Skriver ut vad inmatad värde i cm är i de övriga med 3decimalers precision.
                        Console.WriteLine($"{cm} cm = {yard:#.###} yards");
                        Console.WriteLine($"{cm} cm = {meter:#.###} meters");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("» INCH Conversion «");
                        Console.WriteLine();
                        Console.Write("How many inches do you want to convert? ");

                        TryParseDouble();
                        inch = userDouble;
                      
                        cm = inch * 2.54;
                        foot = inch / 12 ;
                        yard = inch / 36;
                        meter = inch / 39.37;

                        Console.WriteLine($"{inch} inches = {cm:#.###} centimeters");
                        Console.WriteLine($"{inch} inches = {foot:#.###} foot");
                        Console.WriteLine($"{inch} inches = {yard:#.###} yards");
                        Console.WriteLine($"{inch} inches = {meter:#.###} meters");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("» FOOT Conversion «");
                        Console.WriteLine();
                        Console.Write("How many foot do you want to convert?: ");

                        TryParseDouble();
                        foot = userDouble;

                        cm = foot * 30.48;
                        inch = foot * 12;   
                        yard = foot / 0.3;
                        meter = foot / 0.3048;

                        Console.WriteLine($"{foot} foot = {cm:#.###} centimeters");
                        Console.WriteLine($"{foot} foot = {inch:#.###} inches");
                        Console.WriteLine($"{foot} foot = {yard:#.###} yards");
                        Console.WriteLine($"{foot} foot = {meter:#.###} meters");
                        Console.WriteLine();
                        Console.ReadLine();

                        break;

                    case "4":
                        Console.WriteLine("» YARD Conversion «");
                        Console.WriteLine();
                        Console.Write("How many yards do you want to convert?: ");

                        TryParseDouble();
                        yard = userDouble;
                       
                        cm = yard * 91.44;
                        inch = yard * 36;
                        foot = yard * 3;
                        meter = yard / 1.094;

                        Console.WriteLine($"{yard} yards = {cm:#.###} centimeters ");
                        Console.WriteLine($"{yard} yards = {inch:#.###} inches ");
                        Console.WriteLine($"{yard} yards = {foot:#.###} foot ");
                        Console.WriteLine($"{yard} yards = {meter:#.###} meters ");
                        Console.WriteLine();
                        Console.ReadLine();

                        break;

                    case "5":
                        Console.WriteLine("» METER Conversion «");
                        Console.WriteLine();
                        Console.Write("How many meter do you want to convert?: ");

                        TryParseDouble();
                        meter = userDouble;
                       
                        cm = meter * 100;
                        inch = meter * 39.37;
                        foot = meter * 3.281;
                        yard = meter * 1.094;

                        Console.WriteLine($"{meter} meters = {cm:#.###} centimeters");
                        Console.WriteLine($"{meter} meters = {inch:#.###} inches");
                        Console.WriteLine($"{meter} meters = {foot:#.###} foot");
                        Console.WriteLine($"{meter} meters = {yard:#.###} yards");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case "6":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Wrong selection. Please pick an option from the menu!");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public double TryParseDouble()      // Error hanterings metod - Som kollar så att inmatade värdet är en siffra.
        {          
            userString = Console.ReadLine();
            Console.WriteLine();

            while (!double.TryParse(userString, out userDouble))
            {
              Console.WriteLine("Input is not valid, try again!");
              userString = Console.ReadLine();
            }

            return userDouble;
        }
    }
}