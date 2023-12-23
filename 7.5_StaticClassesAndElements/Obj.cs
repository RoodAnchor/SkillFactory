using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.StaticClassesAndElements
{
    internal class Obj
    {
        internal String name;
        internal String description;

        internal static String parent;
        internal static Int32 daysInWeek;
        internal static Int32 maxValue;

        static Obj()
        {
            parent = "System.Object";
            daysInWeek = 7;
            maxValue = 2_000;
        }
    }
}
