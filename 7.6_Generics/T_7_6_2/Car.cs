using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkillFactory.Module6.Generics.T_7_6_2.Parts;

namespace SkillFactory.Module6.Generics.T_7_6_2
{
    abstract internal class Car<TEngine> where TEngine : Engine
    {
        internal TEngine engine = default(TEngine);

        internal abstract void ChangePart<TPart>(TPart newPart)
        where TPart : Part;
    }
}