using System;
using System.IO;

namespace LR25
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates Square = new Coordinates();
        a:
            Console.Clear();
            Square.points();
            Square.menu();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Exit")
                {
                    break;
                }
                switch (command)
                {
                    case "1":
                        {
                            Console.Clear();
                            Square.longer();
                            Console.ReadKey();
                            goto a;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Square.area();
                            Console.ReadKey();
                            goto a;
                        }
                }
            }
        }
    }
}
