using System;

namespace SkillFactory.Module7.Project.Customers
{
    public sealed class BusinessCustomer : Customer
    {
        #region Properties
        public Company Company { get; set; }
        #endregion Properties

        #region Constructors
        public BusinessCustomer(
            String firstName, String lastName,
            String phoneNumber, Company company) :
            base(firstName, lastName, phoneNumber, company.Address)
        {

        }
        #endregion Constructors

        #region Methods
        public override String GetAddress()
        {
            return Company?.Address?.ToString();
        }
        #endregion Methods
    }
}
