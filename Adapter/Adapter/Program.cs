namespace Adapter;

class Program
{
    static void Main(string[] args)
    {
        /*Diseño Adapter
         
         Soluciona aplicaciones que necesitan implementar un tipo de servicio ya existente, aplicaciones donde 
         se quiere utilizar un nuevo formato (Json, xml, etc)
         Suele ser necesario cuando se utiliza una Api externa para traernos datos         
         Permite la utilizacion de interfaces son incompatibles en conjunto.
         
        En este caso si queremos traernos un nuevo servicio de email que manda emails al igual que el anterior servico,
        pero de diferente modo, se puede utilizar el diseño Adapter.   
         
         */
        /*Luego de aplicar el diseño de adapter, podremos hacer esto y no sera necesario cambiar las implementaciones
         del primer Provider ni nada*/
        
        var emailer = new EmailAdapter();
        emailer.Send();
    }
}