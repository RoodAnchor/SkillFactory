using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module7.Polymorphism.T_7_2_7
{
    internal class ClassB : ClassA
    {
        new internal void Display()
        {
            Console.WriteLine("B");
        }
    }
}
