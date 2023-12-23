using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.CsClrBasics.Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDaysEnum day;
            day = WeekDaysEnum.Friday;

            Console.WriteLine(day);
            Console.ReadKey();
        }
    }
}
