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
            Console.WriteLine("");
            Console.WriteLine("Choose an option below");
            Console.WriteLine("");
            Console.WriteLine("1. Calculate Area/Volume");
            Console.WriteLine("");
            Console.WriteLine("2. Length converter");
            Console.WriteLine("");
            Console.WriteLine("3. Ohmslaw");
            Console.WriteLine("");
            Console.WriteLine("4. Speed Distance Time Calculator");
            Console.WriteLine("");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;
                case "3":
                    Console.WriteLine("3");
                    break;
                case "4":
                    Console.WriteLine("4");
                    break;
                case "5":
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Wrong input try again!");
                    Console.ReadLine();
                    break;
            }
        }

    }
}
