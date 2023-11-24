using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module5.PassingParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 num = 5;
            var arr = GetArrayFromConsole(ref num);
            SortArray(arr, out Int32[] sortedDesc, out Int32[] sortedAsc);
        }

        internal static void GetName(out String newName, out String oldName)
        {
            oldName = "Silent Bob";
            Console.WriteLine("Введите имя");
            newName = Console.ReadLine();
        }

        internal static void BigDataOperation(in Int32[] arr)
        {
            arr[0] = 4;
        }

        internal static Int32[] GetArrayFromConsole(ref Int32 num)
        {
            num = 6;

            Int32[] result = new Int32[num];

            for (Int32 i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива №{i + 1}");
                result[i] = Int32.Parse(Console.ReadLine());
            }

            return result;
        }

        /// <summary>
        /// Метод к заданию 5.3.13
        /// </summary>
        /// <param name="arr">Оригинальный массив</param>
        /// <param name="sortedDesc">Сортированный массив по убыванию</param>
        /// <param name="sortedAsc">Сортированный массив по возрастанию</param>
        internal static void SortArray(in Int32[] arr, out Int32[] sortedDesc, out Int32[] sortedAsc)
        {
            sortedDesc = SortArrayDesc(arr);
            sortedAsc = SortArrayAsc(arr);
        }

        internal static Int32[] SortArrayDesc(Int32[] arr)
        {
            for (Int32 i = 0; i < arr.Length; i++)
            {
                for (Int32 j = i + 1; j < arr.Length; j++)
                {
                    Int32 temp = arr[i];
                    if (arr[i] < arr[j])
                    {
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        internal static Int32[] SortArrayAsc(Int32[] arr)
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
    }
}
