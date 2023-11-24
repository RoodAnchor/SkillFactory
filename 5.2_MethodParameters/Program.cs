using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module5.MethodParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            var sortedArray = SortArray(array);
        }

        internal static String GetShowColor(String name, Byte age)
        {
            Console.WriteLine($"{name}, {age},{Environment.NewLine} напишите свой любымый цвет на английском языке с маленькой буквы");

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

        internal static (String, String, String, Int32, Boolean, Byte, String[]) GetUserProfileData()
        {
            (String FirstName, String LastName, String Login,
            Int32 LoginLength, Boolean HasPet, Byte UserAge,
            String[] FavColors) User;

            Console.WriteLine("Enter your first name");
            User.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Enter your login");
            User.Login = Console.ReadLine();

            User.LoginLength = User.Login.Length;

            Console.WriteLine("Do you have a pet? Yes/No");
            User.HasPet = Console.ReadLine() == "Yes" ? true : false;

            Console.WriteLine("Enter your age");
            User.UserAge = Byte.Parse(Console.ReadLine());

            User.FavColors = new String[3];

            Console.WriteLine("Enter 3 of your favourite colors");

            for (int j = 0; j < User.FavColors.Length; j++)
            {
                Console.WriteLine($"Enter your {j + 1} favourite color");
                User.FavColors[j] = Console.ReadLine();
            }

            Console.WriteLine("Thank you.\n");

            return User;
        }

        internal static void ShowColors(params String[] favColors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            for (Int32 i = 0; i < favColors.Length; i++)
            {
                Console.WriteLine(favColors[i]);
            }
        }

        /// <summary>
        /// Метод к заданию 5.2.8
        /// </summary>
        /// <returns></returns>
        internal static Int32[] GetArrayFromConsole(Int32 num = 5)
        {
            Int32[] result = new Int32[num];

            for (Int32 i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива №{i + 1}");
                result[i] = Int32.Parse(Console.ReadLine());
            }

            return result;
        }

        /// <summary>
        /// Метод к заданию 5.2.8
        /// </summary>
        /// <param name="arr">Массив чисел который необходимо сортировать.</param>
        /// <returns>Сортированный массив</returns>
        internal static Int32[] SortArray(Int32[] arr)
        {
            for (Int32 i = 0; i < arr.Length; i++)
            {
                for (Int32 j = i + 1; j < arr.Length; j++)
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

        /// <summary>
        /// Метод к заданию 5.2.17
        /// </summary>
        /// <param name="array">Массив данных который необходимо 
        /// отобразить в консоли</param>
        /// <param name="sort">Признак сортировки</param>
        internal static void ShowArray(Int32[] array, Boolean sort = false)
        {
            Int32[] retVal = array;

            if (sort)
            {
                retVal = SortArray(array);
            }

            else PrintArray(retVal);
        }

        internal static void PrintArray(Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadLine();
        }
    }
}
