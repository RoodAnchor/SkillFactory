using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.StaticClassesAndElements
{
    internal class Helper
    {
        internal static void Swap(ref Int32 a, ref Int32 b) 
        {
            Int32 tempA = a;

            a = b;
            b = tempA;
        }
    }
}
