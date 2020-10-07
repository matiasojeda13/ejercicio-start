using System;

namespace RideShare
{
   public class Passenger : Person
   {
       public string CalificationAsPassenger {get;set;}
       public Passenger(string name, string lastName,int ci) 
       : base(name, lastName, ci)
       {
        
       }
   } 
}