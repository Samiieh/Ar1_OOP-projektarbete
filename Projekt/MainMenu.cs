using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class MainMenu
    {       
        public void Meny()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Niklas, Daniel and Samiies Project!");
            Console.WriteLine();
            Console.WriteLine("» Main Menu «");
            Console.WriteLine();
            Console.WriteLine("1. » Ohmslaw");
            Console.WriteLine("2. » Length converter");
            Console.WriteLine("3. » Speed Distance Time Calculator");
            Console.WriteLine("4. » Calculate Area/Volume");
            Console.WriteLine("5. » Convert between Fahrenheit / Celsius / Kelvin");
            Console.WriteLine("6. » Exit");
            Console.WriteLine();
            Console.Write("Pick an option from the menu: ");
        }
    }
}
