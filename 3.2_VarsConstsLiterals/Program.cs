using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.VarsConstsLiterals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHexDecDouble();
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
    }
}
