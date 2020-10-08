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
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242",false);
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