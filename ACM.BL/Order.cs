using System;

namespace ACM.BL
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public string ShippingAddress { get; set; }

        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }
    }
}