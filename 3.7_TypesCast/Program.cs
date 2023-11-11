using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module3.TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntToStringPrint();
            Console.ReadKey();
        }

        private static void IntToStringPrint()
        {
            Console.Write("Введите ваше имя: ");
            String name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            var age = checked ((Byte)Int16.Parse(Console.ReadLine()));

            Console.WriteLine($"Вас зовут {name} и ваш возраст {age} лет");

            Console.WriteLine("Укажите дату вашего дня рождения в формате дд.мм.ггг: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Ваш день рождения {birthday:dd.MM.yyyy}");
        }
    }
}
