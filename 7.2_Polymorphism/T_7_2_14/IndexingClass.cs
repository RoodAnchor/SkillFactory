using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.Polymorphism.T_7_2_14
{
    internal class IndexingClass
    {
        private Int32[] _array;

        internal IndexingClass(Int32[] array) 
        {
            _array = array;
        }

        internal Int32 this[Int32 index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
    }
}
