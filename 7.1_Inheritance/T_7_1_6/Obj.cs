using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.Inheritance.T_7_1_6
{
    internal class Obj
    {
        private String _name;
        private String _owner;
        private Int32 _length;
        private Int32 _count;

        internal Obj(
            String name, String ownerName, 
            Int32 objLength, Int32 count)
        {
            _name = name;
            _owner = ownerName;
            _length = objLength;
            _count = count;
        }
    }
}
