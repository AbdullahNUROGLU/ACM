namespace ACM.BL
{
    public class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; set; }

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
    }
}