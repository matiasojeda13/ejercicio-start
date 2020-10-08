using System;

namespace RideShare
{
    public abstract class Person
    {
        public string Name{get;set;}
        public string LastName{get;set;}
        public int Ci{get;set;}
        public string UrlPhoto{get;set;}

        public Person (string name, string lastName, int ci, string urlPhoto)
        {
            this.Name=name;
            this.LastName=lastName;
            this.Ci=ci;
            this.UrlPhoto=urlPhoto;
        }
        public abstract String Publish();
        public abstract bool GoodPhoto();
    }
}