using _5._6_Project.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SkillFactory.Module6.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userProfile = GetUserProfile();
            PrintuserProfile(userProfile);
        }

        /// <summary>
        /// Метод собирающий инфу о пользователе
        /// </summary>
        /// <returns>Кортеж</returns>
        static 
        (String FirstName, String SecondName, Int32 Age, 
        Boolean HasPet, Int32 PetCount, String[] PetNames, 
        Boolean HasFavColors, Int32 FavColorsCount, String[] FavColors)
        GetUserProfile()
        {
            String FirstName;
            String SecondName;
            Int32 Age; 
            Boolean HasPet;
            Int32 PetCount = 0;
            String[] PetNames = null;
            Boolean HasFavColors;
            Int32 FavColorsCount = 0;
            String[] FavColors = null;

            List<String> expectedBinVals = new List<String>() { Resources.Yes, Resources.No };

            Console.WriteLine(Resources.FirstNamePromptMsg);
            FirstName = Console.ReadLine();

            Console.WriteLine(Resources.SecondNamePromptMsg);
            SecondName = Console.ReadLine();

            Console.WriteLine(Resources.AgePromptMsg);
            Age = ValidateNumericInput(Console.ReadLine(), Resources.AgePromptMsg);

            
            String petsPromptMessage = String.Format(Resources.PetsPromptMsg, String.Join("/", expectedBinVals));
            Console.WriteLine(petsPromptMessage);
            HasPet = ValidateStringInput(Console.ReadLine(), expectedBinVals, petsPromptMessage)  == Resources.Yes ? true : false;

            if (HasPet)
            {
                Console.WriteLine(Resources.PetsCountPromptMsg);
                PetCount = ValidateNumericInput(Console.ReadLine(), Resources.PetsCountPromptMsg);
                PetNames = GetStringArr(PetCount, Resources.PetNamePromptMsg);
            }

            String colorsPromptMessage = String.Format(Resources.FavColorsPromptMsg, String.Join("/", expectedBinVals));
            Console.WriteLine(colorsPromptMessage);
            HasFavColors = ValidateStringInput(Console.ReadLine(), expectedBinVals, colorsPromptMessage) == Resources.Yes ? true : false;

            if (HasFavColors)
            {
                Console.WriteLine(Resources.ColorsCountPromptMsg);
                FavColorsCount = ValidateNumericInput(Console.ReadLine(), Resources.ColorsCountPromptMsg);
                FavColors = GetStringArr(FavColorsCount, Resources.ColorNamePromptMsg);
            }

            Console.WriteLine($"{Environment.NewLine}{Resources.ByeMsg}");

            Thread.Sleep(1000);

            return (FirstName, SecondName, Age, HasPet, PetCount, PetNames, HasFavColors, FavColorsCount, FavColors);
        }

        /// <summary>
        /// Метод получает данные введённые пользователем
        /// и возвращает эти данные в массиве
        /// </summary>
        /// <param name="arrLength">Длина создаваемого массива</param>
        /// <param name="promptMessage">Сообщение пользователю</param>
        /// <returns>Массив строк</returns>
        private static String[] GetStringArr(Int32 arrLength, String promptMessage)
        {
            String[] arr = new String[arrLength];

            for (Int32 i = 0; i < arrLength; i++)
            {
                Console.WriteLine(promptMessage, ((OrdinalNumbers)i).ToString().ToLower());
                arr[i] = Console.ReadLine();
            }

            return arr;
        }

        /// <summary>
        /// Метод проводит валидацию введённого пользователем числового значения.
        /// Если введённое значение не число, или число но меньше 0 - возвращается ошибка с повторным запросом на ввод.
        /// </summary>
        /// <param name="inp">Введённое пользователем значение</param>
        /// <param name="promptMessage">Сообщение пользователю</param>
        /// <returns>Приведённое к <seealso cref="Int32"/> значение</returns>
        private static Int32 ValidateNumericInput(String inp, String promptMessage)
        {
            Int32 retVal = ParseInput(inp, promptMessage);

            while (retVal <= 0)
            {
                Console.WriteLine(String.Format(Resources.NumValidationErrorMsg, promptMessage));
                retVal = ParseInput(Console.ReadLine(), promptMessage);
            }

            return retVal;
        }

        /// <summary>
        /// Метод парсит введённое значение и выводит сообщение с ошибкой
        /// если значение не число.
        /// </summary>
        /// <param name="inp">Введённое пользователем значение</param>
        /// <param name="promptMessage">Сообщение пользователю</param>
        /// <returns>Приведённое к <seealso cref="Int32"/> значение</returns>
        private static Int32 ParseInput(String inp, String promptMessage)
        {
            Int32 retVal = 0;

            if (Int32.TryParse(inp, out retVal))
            {
                return retVal;
            }
            
            Console.WriteLine(String.Format(Resources.ParseNumberErrorMsg, promptMessage));
            retVal = ParseInput(Console.ReadLine(), promptMessage);

            return retVal;
        }

        /// <summary>
        /// Метод проводит валидацию строкового значния введённого пользователем.
        /// Если список ожидаемых значений не содержит пользовательского - возвращается сообщение с ошибкой.
        /// </summary>
        /// <param name="inp">Введённое пользователем значение</param>
        /// <param name="expectedValues">Список ожидаемых значений</param>
        /// <param name="promptMessage">Сообщение пользователю</param>
        /// <returns>Введённое значение</returns>
        private static String ValidateStringInput(String inp, List<String> expectedValues, String promptMessage)
        {
            String retVal = ToPascalCase(inp);

            while(!expectedValues.Contains(retVal))
            {
                Console.WriteLine(String.Format(Resources.StringValidationErrorMsg, String.Join("/", expectedValues), promptMessage));
                retVal = ToPascalCase(Console.ReadLine());
            }

            return retVal;
        }

        /// <summary>
        /// Метод выводит в консоль инофрмаицю о пользователе.
        /// </summary>
        /// <param name="userProfile">Кортеж</param>
        internal static void PrintuserProfile(
            (String FirstName, String SecondName, Int32 Age, 
            Boolean HasPet, Int32 PetCount, String[] PetNames, 
            Boolean HasFavColors, Int32 FavColorsCount, String[] FavColors) userProfile)
        {
            Console.WriteLine($"{Environment.NewLine}{Resources.UserProfile}");
            Console.WriteLine(new String('-',10));

            Console.WriteLine($"{Resources.FirstName}: {userProfile.FirstName}");
            Console.WriteLine($"{Resources.SecondName}: {userProfile.SecondName}");
            Console.WriteLine($"{Resources.Age}: {userProfile.Age}");

            if (userProfile.HasPet)
            {
                Console.WriteLine($"{Resources.Pets}: {String.Join(", ", userProfile.PetNames)}");
            }

            if (userProfile.HasFavColors)
            {
                Console.WriteLine($"{Resources.FavColors}: {String.Join(", ", userProfile.FavColors)}");
            }

            Console.WriteLine($"{Environment.NewLine}{Resources.PressAnyKey}");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод делает первую букву строкового значения заглавной.
        /// </summary>
        /// <param name="inp">Исходная строка</param>
        /// <returns>Конвертированное значение.</returns>
        private static String ToPascalCase(String inp)
        {
            String loweredInp = inp.ToLower();

            return String.Concat(loweredInp.Substring(0, 1).ToUpper(), loweredInp.Substring(1, loweredInp.Length - 1));
        }
    }

    internal enum OrdinalNumbers : Byte
    {
        First = 0,
        Second,
        Thirs,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Eighth,
        Ninth,
        Tenth
    }
}
