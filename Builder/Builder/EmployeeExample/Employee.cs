namespace Builder.EmployeeExample;

public class Employee
{
    private int Age;
    private string Name;
    private string LastName;
    private string Gender;
    private Address Address;
    private List<Phone> Phones;
    private List<Contact> contacts;

    public Employee(int age, string name, string lastName, string gender, Address address, List<Phone> phones, List<Contact> contacts)
    {
        Age = age;
        Name = name;
        LastName = lastName;
        Gender = gender;
        Address = address;
        Phones = phones;
        this.contacts = contacts;
    }
}