using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module7.Polymorphism.T_7_2_3
{
    internal class DerivedClass : BaseClass
    {
        private Int32 _counter;

        internal override Int32 Counter
        {
            get => _counter;
            set
            {
                if (value >= 0)
                {
                    _counter = value;
                }
            }
        }
        internal override void Display()
        {
            base.Display();

            Console.WriteLine("Метод класса DerivedClass");
            Console.ReadLine();
        }
    }
}