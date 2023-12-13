using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module7.StaticClassesAndElements
{
    public static class Int32Extensions
    {
        public static Int32 GetNegative(this Int32 value)
        {
            if (value < 0) return value;

            return value - value * 2;
        }
        public static Int32 GetPositive(this Int32 value)
        {
            if (value > 0) return value;

            return value - value * 2;
        }
    }
}
