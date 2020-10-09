using System;
using TwitterUCU;
using System.Collections.Generic;

namespace RideShare
{
    /*En esta clase usamos el patrón polymorphism para registrar personas al sistema. Consideramos 
    como persona (clase Person) tanto a un chofer que lleva solo a un pasajero (clase Driver) 
    como a un chofer con más de un pasajero (PoolDriver) y también al pasajero (clase Passenger).
    Cada objeto persona tiene definido una operación que es GoodPhoto para verificar que la imagen es válida
    y una operación Publish para saber qué mensaje publicar.
    */

    public class UcuRideShare
    {
        private List<Person> persons; 
        private string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        private string consumerKeySecret="6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        private string accessToken="1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
        private string accessTokenSecret="gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        private TwitterImage twitter;
        
        public UcuRideShare()
        {
            twitter = new TwitterImage(consumerKey,consumerKeySecret,accessToken,accessTokenSecret);
            persons = new List<Person>();
        }

        public void Add(Person person)
        {
            if (person.GoodPhoto())
            {
                persons.Add(person);
                twitter.PublishToTwitter(person.Publish(),person.UrlPhoto);
            }
                
        }

        
    }
}