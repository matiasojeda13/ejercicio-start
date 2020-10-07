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
            CognitiveFace cog = new CognitiveFace("a36648d3c5134ab692acd35605d491f7",false);
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