using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.Polymorphism.T_7_2_3
{
    internal class BaseClass
    {
        internal virtual Int32 Counter { get; set; }
        internal virtual void Display() 
        {
            Console.WriteLine("Метод класса BaseClass");
            Console.ReadLine();
        }
    }
}
