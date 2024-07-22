namespace Singleton;

public class SingletonDescription
{
    /* QUE PERMITE SINGLETON:
    - MANTENER UNA INSTANCIA ÚNICA PARA UN OBJETO, ESTO PERMITE AHORRAR MUCHO, PORQUE AL TRABAJAR, SOLAMENTE LLAMAMOS A 
    ESA UNICA INSTANCIA Y EN NINGÚN MOMENTO CREAMOS MÁS QUE PUEDAN CONSUMIR MEMORIA.
    - UN PUNTO GLOBAL DE ACCESO A ESA INSTANCIA.

     CUANDO UTILIZAR ESTE PATRON DE DISEÑO:
    - CUANDO VEAMOS QUE SOLAMENTE HACE FALTA TENER UN OBJETO CREADO PARA HACER FUNCIONAR EL PROGRAMA
    
    ALGUNOS CASOS DONDE SE PODRÍA UTILIZAR:
    - CALENDARIO , CONFIGURACIONES (por medio de un configmanager), DATABASE CONNECTIONS , SERVICIOS (Para asegurar 
    que solo una instancia este activa, funciona cuando tengo un servicio que me da acceso a funcionalidades mas
    específicas)
    
    PROBLEMAS:
    -ACCESO AL PUNTO GLOBAL, NO ES TAN SEGURO (Aunque no se pueda modificar), se puede arreglar con diferentes estrategias
     */
}