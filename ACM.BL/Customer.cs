using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        public Customer() : this(0)
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public int Customertype { get; set; }
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

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}