using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.CsMethods.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintArray(SortArray());
        }

        internal static String GetShowColor()
        {
            Console.WriteLine("Напишите свой любымый цвет на английском языке с маленькой буквы");

            String color = Console.ReadLine();

            switch (color)
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

            return color;
        }

        internal static void PrintColors()
        {
            String[] favColors = new String[3];

            for (Byte i = 0; i< favColors.Length; i++)
            {
                favColors[i] = GetShowColor();
            }

            Console.WriteLine("Ваши любимые цвета:");
            for (Byte i = 0;i< favColors.Length;i++)
            {
                Console.WriteLine(favColors[i]);
            }

            Console.ReadLine();
        }

        internal static Int32[] GetArrayFromConsole()
        {
            Int32[] result = new Int32[5];

            for (Int32 i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива №{i+1}");
                result[i] = Int32.Parse( Console.ReadLine() );
            }

            return result;
        }

        internal static Int32[] SortArray()
        {
            Int32[] arr = GetArrayFromConsole();

            for (Int32 i = 0; i < arr.Length; i++) 
            { 
                for (Int32 j = i+1; j < arr.Length; j++)
                {
                    Int32 temp = arr[i];
                    if (arr[i] > arr[j])
                    {
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        internal static void PrintArray(Int32[] array)
        {
            for(Int32 i = 0; i< array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadLine();
        }
    }
}
