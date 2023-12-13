﻿using System;

namespace SkillFactory.Module7.Project.Customers
{
    public sealed class PrivateCustomer : Customer
    {
        #region Constructors
        public PrivateCustomer(
            String firstName, String lastName,
            String phoneNumber, String email, Address address) :
            base(firstName, lastName, phoneNumber, address)
        {
            Email = email;
        }
        #endregion Constructors
    }
}
