using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module6.ClassStruct
{
    internal class Rectangle
    {
        internal Int32 a;
        internal Int32 b;

        internal Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        internal Rectangle(int a)
        {
            this.a = a;
            this.b = a;
        }

        internal Rectangle()
        {
            this.a = 6;
            this.b = 4;
        }

        internal Int32 Square(Int32 a, Int32 b)
        {
            return a * b;
        }
    }
}
