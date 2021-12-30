using System;

namespace Projekt
{
    internal class Program
    {
        public static void Main()
        {
            do
            {
                MainMenu Menu = new MainMenu();             // skapar en instans av klassen MainMenu
                Menu.Meny();                                // anropar Menyn ifrån klassen
              

                switch (Console.ReadLine())
                {
                    case "1":
                        Ohmslaw ohms = new Ohmslaw();       // Creates an instance of Ohms class
                        ohms.OhmsMenu();                    // Calls Ohms menu from ohms class
                        Console.ReadLine();
                        break;
                    case "2":
                        LengthConv lengthConv = new LengthConv();
                        lengthConv.ConvertMenu();
                        Console.ReadLine();
                        break;
                    case "3":
                        SDTCalc stdc = new SDTCalc();
                        stdc.SDTCalcMenu();
                        Console.ReadLine();
                        break;
                    case "4":
                        AreaVolume areaVolume = new AreaVolume();
                        areaVolume.AreaVolumeCalc();
                        Console.ReadLine();
                        break;
                    case "5":
                        TempConvert TempConv = new TempConvert();
                        TempConv.TemperatureConvert();
                        Console.ReadLine();
                        break;
                    case "6":
                    case "breKK":
                        Console.WriteLine("Thank you for using our program, have a great day.");
                        Environment.Exit(0);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong selection. Try again!");
                        Console.ReadLine();
                        break;
                }
            } 
            while (true) ;
       }

       
    }
}



// NOTES //

// Klasser
// MainMenu     Ohmslaw      LengthConvert   SDTCalc   AreaVolume  Celsius/FahrenheitCalc
