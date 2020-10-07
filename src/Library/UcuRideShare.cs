using System;
using TwitterUCU;
using System.Collections.Generic;

namespace RideShare
{
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
            persons.Add(person);
            twitter.PublishToTwitter(person.Publish(),person.UrlPhoto);
        }

        
    }
}