using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.ClassStruct
{
    internal class Pen
    {
        internal String color;
        internal Int32 cost;

        internal Pen()
        {
            color = "Black";
            cost = 100;
        }

        internal Pen(string color, int cost)
        {
            this.color = color;
            this.cost = cost;
        }
    }
}
