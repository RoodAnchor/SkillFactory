using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module6.ClassStruct
{
    internal class Human
    {
        internal String name;
        internal Int32 age;

        internal Human()
        {
            name = "N/A";
            age = 18;
        }

        internal Human(String name)
        {
            this.name = name;
            this.age = 18;
        }

        internal Human(String name, Int32 age)
        {
            this.name = name;
            this.age = age;
        }

        internal void Greetings()
        {
            Console.WriteLine($"My name is {name}, I'm {age} years old.");
        }
    }
}
