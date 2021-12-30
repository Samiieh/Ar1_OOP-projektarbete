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
                Menu.Meny();                                // anropar Meny ifrån klassen
              

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
                        Console.WriteLine("You picked three!");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("You picked four");
                        Console.ReadLine();
                        break;
                    case "5":
                    case "breKK":
                        Console.WriteLine("Thank you for using our program, have a great day.");
                        Environment.Exit(0);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Its stored in the \"HEAP!\" - Baklauv Chau -2021 ");
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
// MainMenu     Ohmslaw      LengthConvert   SDTCalc   AreaVolume
