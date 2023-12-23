using System;

namespace SkillFactory.OopBasics.FinalTask.Customers
{
    abstract public class Customer : Person
    {
        #region Constructors
        public Customer(
            String firstName, String lastName,
            String phoneNumber, Address address) :
            base(firstName, lastName, phoneNumber)
        {
            Address = address;
        }
        #endregion Constructors
    }
}
