namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "Apo";
                customer.LastName = "kajj";
                customer.EmailAddress = "busy.heart@live.com";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}