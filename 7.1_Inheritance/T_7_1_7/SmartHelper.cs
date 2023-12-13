using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module7.Inheritance.T_7_1_7
{
    internal class SmartHelper
    {
        private String _name;

        internal SmartHelper(String name)
        {
            _name = name;
        }

        public void Greetings(String name)
        {
            Console.WriteLine($"Привет, {name}, я" +
                $" интелектуальный помощник {_name}");
            Console.ReadLine();
        }
    }
}
