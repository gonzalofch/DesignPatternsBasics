using Builder.EmployeeExample;

namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        /*PATRON DE DISEÑO BUILDER:

         Ayuda a mostrar mas legibilidad a la hora de instanciar y crear objetos.
         Nos permite saber que valor pertenece a que atributo
         Ademas de estandarizar la manera de creacion de objetos y la forma de validarlos.



         */


        /*Ejemplo de una intancia de Employee normal*/
        /*var aliceAddress = new Address
        (
            "Calle Montevideo",
            "Santander",
            "España",
            "39999"
        );
        var john = new Contact("John Doe", new Phone("671-233-093", "+34"),
            new Address("JohnHouse", "Santander", "España", "39001"));

        var jane = new Contact("Jane Smith", new Phone("871-233-093", "+51"),
            new Address("JaneHouse", "Torrelavega", "España", "39231"));

        var alicePhone = new List<Phone>
        {
            new Phone("571-233-093", "+34"),
            new Phone("563-261-915", "+51"),
        };

        var aliceContacts = new List<Contact>
        {
            john, jane
        };

        var employeeAlice = new Employee(30, "Alice", "Johnson", "Female", aliceAddress, alicePhone, aliceContacts);
        */

        /*Utilizando un Builder*/

        var oscarContact = new Contact("Oscar", new Phone("671235832", "+11"),
            new Address("Casa de Oscar", "Ciudad de Oscar", "Pais de Oscar", "23983"));

        var miguelContact = new Contact("Miguel", new Phone("62372912", "+22"),
            new Address("Casa de Miguel", "Ciudad de Miguel", "Pais de Miguel", "23456"));
        
        Employee employeeGonzalo = new Employee.EmployeeBuilder()
            .EmployeeName("Gonzalo")
            .EmployeeLastName("Flores")
            .EmployeeAddress("Casa de Gonzalo", "Santander", "España", "39008")
            .EmployeeAge(19)
            .EmployeeGender("Masculino")
            .EmployeePhone("671312993", "+34")
            .EmployeeContacts(oscarContact)
            .EmployeeContacts(miguelContact)
            .Build();

        /*Info de Employee y contactos*/
        Console.WriteLine(employeeGonzalo.ToString());
    }
}