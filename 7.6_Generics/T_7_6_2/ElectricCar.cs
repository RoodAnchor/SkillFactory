using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkillFactory.OopBasics.Generics.T_7_6_2.Parts;

namespace SkillFactory.OopBasics.Generics.T_7_6_2
{
    internal class ElectricCar : Car<ElectricEngine>
    {
        internal override void ChangePart<TPart>(TPart newPart) { }
    }
}
