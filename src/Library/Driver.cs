using System;

namespace RideShare
{
    public class Driver : Person
    {
        public Driver (string name, string lastName,int ci) : base (name, lastName, ci)
        {
        }

        public bool HasCar { get; set;}
        public string CalificationAsDriver { get; set; }
        public string Bio {get; set;}
    }
}