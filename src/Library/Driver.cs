using System;

namespace RideShare
{
    public class Driver : Person
    {
        public Driver (string name, string lastName,int ci, string urlPhoto) : base (name, lastName, ci, urlPhoto)
        {
        }

        public string Car { get; set;}
        public string CalificationAsDriver { get; set; }
        public string Bio {get; set;}
    }
}