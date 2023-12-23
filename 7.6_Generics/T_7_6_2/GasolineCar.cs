using SkillFactory.OopBasics.Generics.T_7_6_2.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.OopBasics.Generics.T_7_6_2
{
    internal class GasolineCar : Car<GasolineEngine>
    {
        internal override void ChangePart<TPart>(TPart newPart) { }        
    }
}
