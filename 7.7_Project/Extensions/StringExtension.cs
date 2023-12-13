using System;

namespace SkillFactory.Module7.Project.Extensions
{
    public static class StringExtension
    {
        public static Address ToAddress(this String inputString)
        {
            String[] arr = inputString.Split(new char[] { ',' });

            return new Address(arr[0], arr[1], arr[2], Int32.Parse(arr[3]), Int32.Parse(arr[4]), Int32.Parse(arr[5]));
        }
    }
}
