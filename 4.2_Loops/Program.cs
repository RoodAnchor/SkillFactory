using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.CsClrBasics.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintColorsSwitchWhileLoop();
            PrintColorsSwitchDoWhileLoop();
        }

        internal static void PrintColorsSwitchForLoop()
        {
            for(; ; )
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет красный");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет зелёный");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет циан");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваш любимый цвет жёлтый");
                        break;
                }
            }
        }

        internal static void PrintColorsSwitchWhileLoop()
        {
            Byte k = 0;

            while(k < 0)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет красный");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет зелёный");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет циан");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваш любимый цвет жёлтый");
                        break;
                }

                k++;
            }
        }

        internal static void PrintColorsSwitchDoWhileLoop()
        {
            Byte t = 0;

            do
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет красный");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет зелёный");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет циан");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваш любимый цвет жёлтый");
                        break;
                }

                t++;
            }
            while (t < 0);
        }

        internal static void PrintColorsSwitchWhileBreakLoop()
        {
            Byte k = 0;

            while (k < 0)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

                var inp = Console.ReadLine();

                if (inp == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }

                switch (inp)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет красный");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет зелёный");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет циан");
                        break;
                    default:
                        continue;
                }

                k++;
            }
        }
    }
}
