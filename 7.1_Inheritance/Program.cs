using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkillFactory.Module7.Inheritance.T_7_1_7;

namespace SkillFactory.Module7.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal class BaseClass
    {
        public String name;
        protected String description;
        private Int32 value;

        internal BaseClass(Int32 value)
        {
            this.value = value;
        }
    }

    internal class InheritedClass : BaseClass
    {
        private Int32 value;

        public InheritedClass(int value) : base(value)
        {
            this.value = value;
        }
    }
}
