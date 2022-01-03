using System;

namespace Projekt
{
    internal class Program
    {
        public static void Main()
        {
            bool run = true;

            while (run)
            {
                MainMenu Menu = new MainMenu();             // skapar en instans av klassen MainMenu
                Menu.Meny();                                // anropar Menyn ifrån klassen
              

                switch (Console.ReadLine())
                {
                    case "1":
                        Ohmslaw ohms = new Ohmslaw();       // Creates an instance of Ohms class
                        ohms.OhmsMenu();                    // Calls Ohms menu from ohms class
                        break;

                    case "2":
                        LengthConv lengthConv = new LengthConv();
                        lengthConv.ConvertMenu();
                        break;

                    case "3":
                        SDTCalc stdc = new SDTCalc();
                        stdc.SDTCalcMenu();
                        break;

                    case "4":
                        AreaVolume areaVolume = new AreaVolume();
                        areaVolume.AreaVolumeCalc();

                        break;

                    case "5":
                        TempConvert TempConv = new TempConvert();
                        TempConv.TemperatureConvert();
                        break;

                    case "6":
                        Console.WriteLine("Thank you for using our program, have a great day.");
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Wrong selection. Try again!");
                        Console.ReadLine();
                        break;
                }
            }
        } 
    }
}



// NOTES //

// Klasser
// MainMenu     Ohmslaw      LengthConvert   SDTCalc   AreaVolume  Celsius/FahrenheitCalc
