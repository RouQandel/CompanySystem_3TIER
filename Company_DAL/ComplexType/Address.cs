using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DAL.ComplexType
{
    [ComplexType]
    public class Address
    {
        public Address()
        {
        }

        public Address(string country, string governate, string city, string area, string address1, string address2, string address3)
        {
            Country = country;
            Governate = governate;
            City = city;
            Area = area;
            Address1 = address1;
            Address2 = address2;
            Address3 = address3;
        }

        public string Country { get; private set; }
        public string Governate { get; private set; }
        public string City { get; private set; }
        public string Area { get; private set; }
        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string Address3 { get; private set; }
    }
}