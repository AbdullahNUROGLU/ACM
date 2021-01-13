using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrive(int addressId)
        {
            Address address = new Address();
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "line1";
                address.StreetLine2 = "line2";
                address.City = "city";
                address.Country = "country";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customeId)
        {
            List<Address> addressesList = new List<Address>();
            Address address1 = new Address
            {
                AddressType = 1,
                StreetLine1 = "line1",
                StreetLine2 = "line2",
                City = "city",
                Country = "country",
                PostalCode = "144",
            };
            Address address2 = new Address
            {
                AddressType = 1,
                StreetLine1 = "line1",
                StreetLine2 = "line2",
                City = "city",
                Country = "country",
                PostalCode = "144",
            };
            addressesList.Add(address1);
            addressesList.Add(address2);

            return addressesList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}