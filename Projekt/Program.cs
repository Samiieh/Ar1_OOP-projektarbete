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

            // Klasser
            // MainMenu     Ohmslaw      LengthConvert   SDTCalc   AreaVolume
        }
     }
}

