using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module5.Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (String Name, String[] Dishes) User;

            Console.WriteLine("Введите ваше имя");
            User.Name = Console.ReadLine();
            User.Dishes = new String[5];

            for(Byte i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine($"Введите ваше любимое блюдо №{i+1}");
                User.Dishes[i] = Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
