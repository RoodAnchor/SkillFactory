﻿using System;

using SkillFactory.Module7.Project.Customers;

namespace SkillFactory.Module7.Project.Deliveries
{
    public sealed class HomeDelivery<TCustomer> : Delivery<TCustomer> 
        where TCustomer : Customer
    {
        #region Properties
        public ShippingService ShippingService { get; private set; }
        #endregion Properties

        #region Constructors
        public HomeDelivery(
            DateTime eta, TCustomer customer, 
            ShippingService shippingService) : 
            base(eta, customer) 
        {
            ShippingService = shippingService;
        }
        #endregion Constructors

        #region Methods
        public override void CalculateDeliveryPrice()
        {
            Price = ShippingService.GetDeliveryPrice();
        }
        #endregion Methods
    }
}
