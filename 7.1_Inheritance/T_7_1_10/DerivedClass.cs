using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module7.Inheritance.T_7_1_10
{
    internal class DerivedClass : BaseClass
    {
        internal String Description;
        internal Int32 Counter;

        internal DerivedClass(String name, 
            String description) : base(name)
        {
            Description = description;
        }

        internal DerivedClass(String name, 
            String description, Int32 counter) : base(name)
        {
            Description = description;
            Counter = counter;
        }
    }
}
