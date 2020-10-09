using System;

namespace RideShare
{
    /* La clase Person es la clase base de Passenger y Driver. La usamos para aplicar herencia,
    para poder reutilizar el código que esta clase contiene y además poder aplicar el principio OCP 
    a fin de extender el código y tener las clases cerradas a las modificaciones.   
    También aplicamos el principio LSP que si sustituimos una instancia del objeto passenger 
    por una de un subtipo de Person, el programa sigue funcionando como debe, registrando a 
    los usuarios en el sistema.
    */

    public abstract class Person
    {
        public string Name{get;set;}
        public string LastName{get;set;}
        public int Ci{get;set;}
        public string UrlPhoto{get;set;}

        public Person (string name, string lastName, int ci, string urlPhoto)
        {
            this.Name=name;
            this.LastName=lastName;
            this.Ci=ci;
            this.UrlPhoto=urlPhoto;
        }
        public abstract String Publish();
        public abstract bool GoodPhoto();
    }
}