using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.Polymorphism.T_7_2_12
{
    internal class Obj
    {
        internal Int32 value;

        public static Obj operator + (Obj x, Obj y)
        {
            return new Obj() { value = x.value + y.value };
        }

        public static Obj operator - (Obj x, Obj y)
        {
            return new Obj() { value = x.value - y.value };
        }
    }
}
