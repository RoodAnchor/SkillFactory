using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.StaticClassesAndElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 num1 = 3;
            Int32 num2 = -4;
            Int32 num3 = 0;

            Console.WriteLine(num1.GetNegative());
            Console.WriteLine(num1.GetPositive());
            Console.WriteLine(num2.GetNegative());
            Console.WriteLine(num2.GetPositive());
            Console.WriteLine(num3.GetNegative());
            Console.WriteLine(num3.GetPositive());
            Console.ReadLine();
        }
    }
}
