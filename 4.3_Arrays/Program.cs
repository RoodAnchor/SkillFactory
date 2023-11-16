using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module4.Arrays
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Print2dArrSort();
        }

        static void PrintColorForeachLoop()
        {
            String[] favColors = new String[3];

            for (UInt16 i = 0; i < favColors.Length; i++)
            {
                Console.WriteLine($"Введите любимый цвет #{i + 1}");
                favColors[i] = Console.ReadLine();
            }

            foreach (String color in favColors)
            {
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
            }
        }

        static void PrintSplitName()
        {
            Console.WriteLine("Введите своё имя");
            String name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам:");

            foreach(Char c in name)
            {
                Console.Write($"{c} ");
            }

            Console.WriteLine($"\nПоследняя буква вашего имени: {name[name.Length-1]}");
            Console.ReadKey();
        }

        static void PrintNameInvert()
        {
            Console.WriteLine("Введите ваше имя");
            String name = Console.ReadLine();

            for(Int32 i = name.Length-1; i >= 0; i--)
            {
                Console.Write($"{name[i]} ");
            }

            Console.ReadKey();
        }

        static void PrintMultiDimArr()
        {
            Int32[,] arr = { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 }, 
                { 10, 11, 12 } 
            };

            Console.Write("Строк: ");
            Console.WriteLine(arr.GetUpperBound(0) + 1);

            Console.Write("Колонок: ");
            Console.WriteLine(arr.GetUpperBound(1) + 1);

            for(Int32 i = 0; i < arr.GetUpperBound(1) + 1; i++)
            {
                for(Int32 j = 0; j < arr.GetUpperBound(0) + 1; j++)
                {
                    Console.Write($"{arr[j, i]} ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void PrintSortArrLinq()
        {
            Int32[] arr = new Int32[] { 5, 6, 9, 1, 3, 2, 4 };

            Int32[] newArr = arr.OrderBy(x => x).ToArray();

            foreach (Int32 i in newArr)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }

        static void PrintSortArrManual()
        {
            Int32[] arr = new Int32[] { 5, 6, 9, 1, 3, 2, 4 };

            Boolean changed;
            Int32 current;
            Int32 next;

            do
            {
                changed = false;

                for (Int32 i = 0; i < arr.Length; i++)
                {
                    if (i + 1 < arr.Length && arr[i] > arr[i + 1])
                    {
                        current = arr[i];
                        next = arr[i + 1];

                        arr[i] = next;
                        arr[i + 1] = current;
                        changed = true;
                    }
                }
            }
            while (changed);

            foreach(Int32 i in arr)
            {
                Console.Write(i);
            }

            Console.ReadKey();
        }

        static void PrintArrSum()
        {
            Int32[] arr = new Int32[] { 5, 6, 9, 1, 3, 2, 4 };

            Int32 sum = 0;

            foreach(Int32 i in arr)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static void PrintJaggedStringArr()
        {
            String[] favColors = new String[3];

            for (UInt16 i = 0; i < favColors.Length; i++)
            {
                Console.WriteLine($"Введите любимый цвет #{i + 1}");
                favColors[i] = Console.ReadLine();
            }

            foreach(String color in favColors)
            {
                foreach(Char c in color)
                {
                    Console.Write($"{c} ");
                }
            }

            Console.ReadLine();
        }

        static void PrintJaggedIntArr()
        {
            Int32[][] arrs = new Int32[3][];

            arrs[0] = new Int32[] { 1, 2 };
            arrs[1] = new Int32[] { 1, 2, 3, 4};
            arrs[2] = new Int32[] {1,2, 3, 4, 5};

            foreach(Int32[] arr in arrs)
            {
                foreach(Int32 i in arr)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Метод к заданию 4.3.16
        /// </summary>
        static void PrintArrPositives()
        {
            Int32[,] arr = new Int32[,] { { 23, 4, -6, 23, -47, -18, 7 },{ -8, 2, 15, -53, 61, -5, 37 } };
            Int32 positivesCount = 0;

            for(Int32 i = 0; i < arr.GetUpperBound(0)+1; i++)
            {
                for(Int32 j = 0; j < arr.GetUpperBound(1)+1; j++)
                {
                    if (arr[i,j] > 0)
                        positivesCount++;
                }
            }

            Console.WriteLine(positivesCount);
            Console.ReadLine();
        }

        /// <summary>
        /// Метод к заданию 4.3.17
        /// </summary>
        static void Print2dArrSort()
        {
            Int32[,] arr = new Int32[,] { { 23, 4, -6, 23, -47, -18, 7 }, { -8, 2, 15, -53, 61, -5, 37 } };
            Boolean changed;
            Int32 current;
            Int32 next;

            do
            {
                changed = false;
                for (Int32 i = 0; i < arr.GetUpperBound(0) + 1; i++)
                {
                    for (Int32 j = 0; j < arr.GetUpperBound(1) + 1; j++)
                    {
                        if (j+1 < arr.GetUpperBound(1) + 1 && arr[i,j] > arr[i,j+1])
                        {
                            current = arr[i,j];
                            next = arr[i, j + 1];

                            arr[i, j] = next;
                            arr[i, j + 1] = current;

                            changed = true;
                        }
                    }
                }

            }
            while(changed);

            for (Int32 i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (Int32 j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
