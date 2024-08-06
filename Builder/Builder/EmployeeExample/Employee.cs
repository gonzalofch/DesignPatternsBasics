using System.Reflection.Metadata.Ecma335;
using Builder.Builder.Interface;
using Builder.EmployeeExample.Interface;

namespace Builder.EmployeeExample;

public class Employee
{
    private int Age;
    private string Name;
    private string LastName;
    private string Gender;
    private Address Address;
    private List<Phone> Phones;
    private List<Contact> Contacts;

    public Employee(int age, string name, string lastName, string gender, Address address, List<Phone> phones,
        List<Contact> contacts)
    {
        Age = age;
        Name = name;
        LastName = lastName;
        Gender = gender;
        Address = address;
        Phones = phones;
        Contacts = contacts;
    }
    public override string ToString()
    {
        string phones = string.Join(", ", Phones);
        string contacts = string.Join(", ", Contacts);
        return
            $"Employee: {Name} {LastName}, Age: {Age}, Gender: {Gender}, Address: {Address}, Phones: [{phones}], Contacts: [{contacts}]";
    }
    
    public class EmployeeBuilder : IBuilder<Employee>
    {
        private int Age;
        private string Name;
        private string LastName;
        private string Gender;
        private Address Address;
        private List<Phone> Phones = new List<Phone>();
        private List<Contact> Contacts = new List<Contact>();

        public EmployeeBuilder()
        {
        }

        public EmployeeBuilder EmployeeAge(int age)
        {
            this.Age = age;
            return this;
        }

        public EmployeeBuilder EmployeeName(string name)
        {
            this.Name = name;
            return this;
        }

        public EmployeeBuilder EmployeeLastName(string lastName)
        {
            this.LastName = lastName;
            return this;
        }

        public EmployeeBuilder EmployeeGender(string gender)
        {
            this.Gender = gender;
            return this;
        }

        public EmployeeBuilder EmployeeAddress(Address address)
        {
            this.Address = address;
            return this;
        }

        public EmployeeBuilder EmployeeAddress(string homeAddress, string city, string country, string postalCode)
        {
            this.Address = new Address(homeAddress, city, country, postalCode);
            return this;
        }

        /*Aqui tambien puedo aplicar polimorfismo y pedir los datos para instanciar un Phone y luego añadirlo*/
        public EmployeeBuilder EmployeePhone(Phone phone)
        {
            this.Phones.Add(phone);
            return this;
        }

        public EmployeeBuilder EmployeePhone(string phoneNumber, string countryCode)
        {
            this.Phones.Add(new Phone(phoneNumber, countryCode));
            return this;
        }

        public EmployeeBuilder EmployeeContacts(Contact contact)
        {
            this.Contacts.Add(contact);
            return this;
        }

        public EmployeeBuilder EmployeeContacts(string name, Phone phone, Address address)
        {
            this.Contacts.Add(new Contact(name, phone, address));
            return this;
        }

        public Employee Build()
        {
            /*aqui utilizo todos los atributos para ya instanciar el objeto real de Employee con todos los atributos seteados*/
            return new Employee(Age, Name, LastName, Gender, Address, Phones, Contacts);
        }
    }
}