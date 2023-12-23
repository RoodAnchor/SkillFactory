using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.ClassStruct
{
    internal class Bus
    {
        internal Int32 Load;

        internal void PrintStatus()
        {
            Console.WriteLine(Load > 0 ? Load.ToString() : "Bus is empty");
        }
    }
}
