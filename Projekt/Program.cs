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
                MainMenu Menu = new();             // Skapar en instans av klassen "MainMenu"
                Menu.Meny();                                // Anropar "Meny" metoden från instansen av klassen.
              

                switch (Console.ReadLine())
                {
                    case "1":
                        Ohmslaw ohms = new();       // Skapar en instans av klassen "Ohmslaw".
                        ohms.OhmsMenu();                    // Anropar metoden "OhmsMenu" från instansen av klassen.
                        break;

                    case "2":
                        LengthConv lengthConv = new();
                        lengthConv.ConvertMenu();
                        break;

                    case "3":
                        SDTCalc stdc = new();
                        stdc.SDTCalcMenu();
                        break;

                    case "4":
                        AreaVolume areaVolume = new();
                        areaVolume.AreaVolumeCalc();

                        break;

                    case "5":
                        TempConvert TempConv = new();
                        TempConv.TemperatureConvert();
                        break;

                    case "6":
                        Console.WriteLine("Thank you for using our program, have a great day.");
                        run = false;        //Avslutar programmet genom att återge false till run som avslutar loopen.
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
