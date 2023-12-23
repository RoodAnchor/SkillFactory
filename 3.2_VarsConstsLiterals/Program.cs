using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.CsClrBasics.VarsConstsLiterals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintWithCorrectTypes();
        }

        private static void PrintStuffWithEscChars()
        {
            const String MyName = "Андрей";
            Console.WriteLine(MyName);

            Console.WriteLine("\tПривет, мир!");
            Console.WriteLine("\tМне 36");
            Console.WriteLine($"\tМеня зовут\n {MyName}");
            Console.WriteLine("\u0040");
            Console.WriteLine("\u0023");

            Console.ReadKey();
        }

        private static void PrintLogicalLiterals()
        {
            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.ReadKey();
        }

        private static void PrintNumericLiterals()
        {
            Console.WriteLine(5);

            Console.ReadKey();
        }

        private static void PrintHexDecDouble()
        {
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);

            Console.ReadKey();
        }

        private static void PrintWithCorrectTypes()
        {
            const String name = "Андрей";
            Byte age = 36;
            Boolean havePet = true;
            Single shoeSize = 41.5F;

            Console.WriteLine($"Меня зовут {name}");
            Console.WriteLine($"Мне {age} лет");
            Console.WriteLine($"Есть ли у меня домашнее животное? {havePet}");
            Console.WriteLine($"У меня {shoeSize} размер обуви");

            Console.ReadKey();
        }
    }
}