namespace ACM.BL
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDisceiption { get; set; }
        public decimal? CurrentPrice { get; set; }

        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public Product Retrieve(int pruductId)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }
    }
}