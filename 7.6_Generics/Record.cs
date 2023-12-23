using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.Generics
{
    internal class Record<T1, T2>
    {
        internal T1 id;
        internal T2 value;
        internal DateTime data;
    }
}
