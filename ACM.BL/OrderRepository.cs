using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset();
                order.ShippingAddress = "Address";
            }

            return order;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}