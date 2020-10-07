using System;

namespace RideShare
{
   public class Passenger : Person
   {
       public string CalificationAsPassenger {get;set;}
       public Passenger(string name, string lastName,int ci, string urlPhoto) 
       : base(name, lastName, ci, urlPhoto)
       {
        
       }
   } 
}