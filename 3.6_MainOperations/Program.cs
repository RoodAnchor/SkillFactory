using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.MainOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IncrementPosfixPrint(2);
            Console.ReadKey();
        }

        private static void DivideAndPrint(Double a, Double b)
        {
            Double result = a / b;

            Console.WriteLine($"{a} / {b} = {result}");
            
        }

        private static void RemainderPrint(Double a, Double b)
        {
            Double result = a % b;

            Console.WriteLine($"{a} % {b} = {result}");
        }

        private static void IncrementPrefixPrint(Int32 value)
        {
            Console.WriteLine($"Initial: {value}, Increment: {++value}");
        }

        private static void IncrementPosfixPrint(Int32 value)
        {
            Console.WriteLine($"Initial: {value}, Increment: {value++}");
        }
    }
}