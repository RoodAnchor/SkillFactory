using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SkillFactory.Module5.Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Echo("Ты меня слышишь?", 3);
            Console.ReadLine();
        }

        static void Echo(string message, Int32 deep)
        {
            Console.WriteLine(message);

            if (deep > 1)
            {
                Echo(message.Substring(2, message.Length-2), deep-1);
            }
        }
    }
}
