using System;

using SkillFactory.OopBasics.FinalTask.Enums;
using SkillFactory.OopBasics.FinalTask.Products;
using SkillFactory.OopBasics.FinalTask.Deliveries;
using SkillFactory.OopBasics.FinalTask.Customers;
using System.Runtime.Remoting.Messaging;

namespace SkillFactory.OopBasics.FinalTask
{
    public class Order<TDelivery, TCustomer, TNumber>
        where TDelivery : Delivery<TCustomer>
        where TCustomer : Customer
    {
        #region Properties;
        public TDelivery Delivery { get; set; }
        public TNumber Number { get; private set; }
        public String Description { get; set; }
        public ProductCollection<Product> Products { get; set; }
        public OrderStateEnum State { get; private set; } = OrderStateEnum.New;
        public Double BasePrice { get; private set; }
        public Double FinalPrice { get; private set; }
        public Double Discount { get; set; }
        #endregion Properties;

        #region Constructors
        public Order(TNumber number)
        {
            Number = number;
        }

        public Order(Double basePrice)
        {
            BasePrice = basePrice;
        }
        #endregion Constructors

        #region Methods
        public void DisplayAddress() 
        {
            throw new NotImplementedException();
        }

        public void NotifyStateChanged(OrderStateEnum State) 
        {
            throw new NotImplementedException();
        }
        public void CancelOrder() 
        {
            State = OrderStateEnum.Cancelled;
            Delivery.State = DeliveryStateEnum.Canceled;
        }
        public void CalculateOrderBasePrice() 
        {
            BasePrice = Products.GetTotalPrice();
        }
        public void CalculateOrderFinalPrice()
        {
            FinalPrice = BasePrice * Discount / 100 + Delivery.Price;
        }
            
        #endregion Methods
    }
}
