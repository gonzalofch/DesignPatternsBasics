namespace Builder.EmployeeExample;

public class Phone
{
    public string PhoneNumber { get; set; }
    public string CountryCode { get; set; }

    public Phone(string phoneNumber, string countryCode)
    {
        PhoneNumber = phoneNumber;
        CountryCode = countryCode;
    }
}