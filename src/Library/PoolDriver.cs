using System;

namespace RideShare
{
    public class PoolDriver: Driver
    {
        public int NumberOfPassengers{get;set;}
        
        public PoolDriver (string name, string lastName,int ci, string urlPhoto) 
            : base (name, lastName, ci, urlPhoto)
        {
        }
    }
}