namespace ACM.BL
{
    public class OrderItem
    {
        public int OrderItemId { get; private set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int ProductId { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public bool Validate()
        {
            bool Isvalid = true;
            if (Quantity <= 0) Isvalid = false;
            if (ProductId <= 0) Isvalid = false;
            if (PurchasePrice == null) Isvalid = false;
            return Isvalid;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }
    }
}