using System;

namespace Projekt
{
    internal class Program
    {
        public void Main()
        {
            bool showMenu = true;

            while (showMenu)
            {
                MainMenu Menu = new MainMenu();
                Menu.Meny();     // anropar Meny
               
                //showMenu = MainMenu.Meny();  
            }

        }
     }
}



//switch (Console.ReadLine())
//{
//    case "1":
//        Console.WriteLine("1");
//        break;
//    case "2":
//        Console.WriteLine("2");
//        break;
//    case "3":
//        Console.WriteLine("3");
//        break;
//    case "4":
//        Console.WriteLine("4");
//        break;
//    case "5":
//        Console.WriteLine("5");
//        break;
//    default:
//        Console.WriteLine("Wrong input try again!");
//        Console.ReadLine();
//        break;
//}




// Klasser
// MainMenu     Ohmslaw      LengthConvert   SDTCalc   AreaVolume
