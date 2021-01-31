using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public int ProductId { get; set; }
        private string _productName;
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public string ProductName
        {
            get
            {
                //return StringHandler.InsertSpaces(_productName);
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public string Log() =>
    $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}