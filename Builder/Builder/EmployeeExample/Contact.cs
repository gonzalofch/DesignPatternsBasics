namespace Builder.EmployeeExample;

public class Contact
{
    private string Name { get; set; }
    private Phone Phone { get; set; }
    private Address Address { get; set; }

    public Contact(string name, Phone phone, Address address)
    {
        Name = name;
        Phone = phone;
        Address = address;
    }

    public string ToString(IFormatProvider? provider)
    {
        return Name.ToString(provider);
    }
}