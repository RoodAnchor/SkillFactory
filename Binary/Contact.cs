using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    [Serializable]
    public class Contact
    {
        public String Name { get; set; }
        public Int64 PhoneNumber { get; set; }
        public String Email { get; set; }

        public Contact(
            String name, Int64 phoneNumber, 
            String email)
        {
            Name = name; 
            PhoneNumber = phoneNumber; 
            Email = email;
        }
    }
}
