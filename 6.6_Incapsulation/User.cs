using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module6.Incapsulation
{
    public class User
    {
        private Int32 _age;
        private String _login;
        private String _email;

        public Int32 Age
        {
            get => _age;

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("You have to be older than 18 to proceed");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public String Login
        {
            get => _login;
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Login should be at least 3 characters long");
                }
                else
                {
                    _login = value;
                }
            }
        }

        public String Email
        {
            get => _email;
            set
            {
                if (!value.Contains("@"))
                {
                    Console.WriteLine("Email shold contain @ character");
                }
                else
                {
                    _email = value;
                }
            }
        }
    }
}
