using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SkillFactory.CsMethods.Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(0,0));
            Console.ReadLine();
        }

        static void Echo(string message, Int32 deep)
        {
            Console.ForegroundColor = (ConsoleColor)deep;
            Console.WriteLine(message);            

            if (deep > 1)
            {
                Echo(message.Substring(2, message.Length-2), deep-1);
            }
        }

        static Decimal Factorial(Int32 x)
        {
            if (x == 0) return 1;

            return x * Factorial(x - 1);
        }

        static Int32 PowerUp(Int32 x, Byte power)
        {
            if (x == 0 && power == 0) throw new InvalidOperationException();
            if (power == 0) return 1;

            if (power > 0)
            {
                return x * PowerUp(x, --power);
            }

            return 0;
        }
    }
}
