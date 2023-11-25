using SkillFactory.Module4.Tuples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module4.Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserProfileData();
        }

        static void PrintNameAge()
        {
            var (name, age) = ("Andrey", 36);

            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your age is {age}");

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter you age");
            age = Byte.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your age is {age}");

            Console.ReadLine();
        }
        
        static (String, String, Byte, Int32) PrintPetData()
        {
            (String Name, String Type, Byte Age, Int32 NameCount) Pet;

            Pet.Name = "Dizzy";
            Pet.Type = "cat";
            Pet.Age = 2;

            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine(Pet);
            Console.ReadLine();

            return Pet;
        }

        static void GetUserProfileData()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"User #{i + 1}\n");

                (String FirstName, String LastName, String Login,
                Int32 LoginLength, Boolean HasPet, Byte UserAge,
                String[] FavColors) User;

                Console.WriteLine("Enter your first name");
                User.FirstName = Console.ReadLine();

                Console.WriteLine("Enter your last name");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Enter your login");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Do you have a pet? Yes/No");
                User.HasPet = Console.ReadLine() == "Yes" ? true : false;

                Console.WriteLine("Enter your age");
                User.UserAge = Byte.Parse(Console.ReadLine());

                User.FavColors = new String[3];

                Console.WriteLine("Enter 3 of your favourite colors");

                for (int j = 0; j < User.FavColors.Length; j++)
                {
                    Console.WriteLine($"Enter your {j + 1} favourite color");
                    User.FavColors[j] = Console.ReadLine();
                }

                Console.WriteLine("Thank you.\n");
            }
        }
    }
}
