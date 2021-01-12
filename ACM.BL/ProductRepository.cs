namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName = "product";
                product.ProductDisceiption = "info";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}