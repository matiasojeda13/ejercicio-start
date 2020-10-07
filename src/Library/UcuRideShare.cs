using System;
using TwitterUCU;
using System.Collections.Generic;

namespace RideShare
{
    public class UcuRideShare
    {
        private List<Passenger> passengers; 
        private List<Driver> drivers;
        private string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        private string consumerKeySecret="6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        private string accessToken="1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
        private string accessTokenSecret="gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        private TwitterImage twitter;
        
        public UcuRideShare()
        {
            twitter = new TwitterImage(consumerKey,consumerKeySecret,accessToken,accessTokenSecret);
            passengers = new List<Passenger>();
            drivers = new List<Driver>();
        }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
            twitter.PublishToTwitter($"{passenger.Name} {passenger.LastName}",passenger.UrlPhoto);
        }
        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
            twitter.PublishToTwitter($"Welcome new driver!! {driver.Name} {driver.LastName}",driver.UrlPhoto);
        }
    }
}