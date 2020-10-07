using System;
using CognitiveCoreUCU;
namespace RideShare
{
    public class Driver : Person
    {
        public Driver (string name, string lastName,int ci, string urlPhoto) 
        :base (name, lastName, ci, urlPhoto)
        {
        }

        public string Car { get; set;}
        public string CalificationAsDriver { get; set; }
        public string Bio {get; set;}
        public override string Publish()
        {
           return ($"Welcome new Driver {this.Name} {this.LastName}") ;
        }
        public override bool GoodPhoto()
        {
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242",false);
            if (cog.FaceFound)
            {
               if(cog.SmileFound)
               {
                   return true;
               }
               else
               {
                   return false;
               }
            }
            else
            {
               return false;
            }
        }
    }
}