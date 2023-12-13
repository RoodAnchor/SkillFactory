using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module6.Generics
{
    internal class Record<T1, T2>
    {
        internal T1 id;
        internal T2 value;
        internal DateTime data;
    }
}
