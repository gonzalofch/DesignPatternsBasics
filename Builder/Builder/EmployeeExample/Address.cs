namespace Builder.EmployeeExample;

public class Address
{
    private string HomeAddress { get; set; }
    private string City { get; set; }
    private string Country { get; set; }
    private string PostalCode { get; set; }

    public Address(string homeAddress, string city, string country, string postalCode)
    {
        HomeAddress = homeAddress;
        City = city;
        Country = country;
        PostalCode = postalCode;
    }
}