using System;
using TwitterUCU;

namespace RideShare
{
    public class RideShare
    {
        private string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        private string consumerKeySecret="6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        private string accessToken="1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
        private string accessTokenSecret="gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        private TwitterImage twitter;
        
        public RideShare()
        {
            twitter = new TwitterImage(consumerKey,consumerKeySecret,accessToken,accessTokenSecret);

        }

        public void Add(Person persona)
        {
            twitter.PublishToTwitter($"{persona.Name} {persona.LastName}",persona.Photo);
        }



    }
}