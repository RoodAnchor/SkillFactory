using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Oop.ClassStruct
{
    internal struct Animal
    {
        public String type;
        public String name;
        public Int32 age;

        public void PrintInfo()
        {
            Console.WriteLine($"It's a {type}, it's name is {name} " +
                $"and it's {age} years old.");
        }
    }
}
