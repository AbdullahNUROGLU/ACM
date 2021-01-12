using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullName = "";
                if (LastName != null)
                {
                    fullName = LastName;
                    if (FirstName != null)
                    {
                        fullName += ", " + FirstName;
                    }
                }
                else
                {
                    fullName = FirstName;
                }

                return fullName;
            }
        }

        public bool Valid()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

        public Customer Retrieve(int cusomerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}