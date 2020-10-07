using System;
using CognitiveCoreUCU;

namespace RideShare
{
   public class Passenger : Person
   {
        public string CalificationAsPassenger {get;set;}
        public Passenger(string name, string lastName,int ci, string urlPhoto) 
        :base(name, lastName, ci, urlPhoto)
        {
        
        }
        public override string Publish()
        {
           return ($"Welcome new Passenger {this.Name} {this.LastName}") ;
        }
        public override bool GoodPhoto()
        {
            CognitiveFace cog = new CognitiveFace("a36648d3c5134ab692acd35605d491f7",false);
            if (cog.FaceFound)
            {
               return true;
            }
            else
            {
               return false;
            }
        }
 
   } 
}