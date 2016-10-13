using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace ConsoleApplication3
{

    class Program
    {
        static void Main(string[] args)
        {
            //var Jax = new City("Jax");
            //var DC = new City("DC");
            string[] City = new string[1] { "Dallas" };  ///remember to add these single line arrays back in if this works
            string[] Jaxhoods = new string[5] { "Downtown", "Beach", "Mandarin", "OP", "Grove" };
            string[] DChoods = new string[5] { "OT", "Arlington", "GT", "Roslyn", "Ballstown" };
            string[] Dallashoods = new string[5] { "HP", "DE", "Carrol", "Plano", "SS" };
            //string[] neighborhoodsJax = new string[5] { "Downtown", "Beach", "Mandarin", "OP", "Grove" };
            //string[] neighborhoodsDC = new string[5] { "OT", "Arlington", "GT", "Roslyn", "Ballstown" };
            //string[] neighborhoodsDallas = new string[5] { "HP", "DE", "Carrol", "Plano", "SS" };
            List<string> restaurantsJax = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            string[] restaurantsDC = new string[10] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            string[] restaurantsDallas = new string[10] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

            Console.WriteLine(City);
            Console.ReadLine();

            //Jax.Jaxhoods(0).Add();
        }


        ////Create 3 Cities, each with atleast 5 Neighborhoods and 10 Restaurants.
        //A City should have a method to query for all the Restaurants near a LatLng.
        //A City should have a method to query for all the Restaurants of a certain Category.
        //A Neighborhood should also have a method to query for all the Restaurants of a certain Category.

    }

    enum Categories
    {
        Italian, American, Thai, German, French, English, Mexican, Spanish, Chinese, Korean, Japanese, Other
    };
    public class Cityactual
    {
        public string city;
    }

        //public string[] city;
        //public string name;
        //public string state;
        //public LatLng latlng;
        //public List<Neighborhood> burroughs = new List<Neighborhood>();
        //public List<Restaurant> restaurants = new List<Restaurant>();
        //public List<City> neighboringcities = new List<City>();
        //string hood;
        //string rests;
        //string cities;
        //public City(string hood = "", string cities = ""/*, string rests = "a"*/)  //we're just gonna do two at first then build up
        //{
        //    this.hood = hood;
        //    //this.city = "";

        //    //this.rests = rests;
        }
    public class City
    {
        
        public City()
        {
        List<City> c = new List<City>();
        string[] City = new string[1] { "Dallas" };
        string[] Dallashoods = "HP, DE, Carrol, Plano, SS".Split(new char[] { ',' });
            foreach (string city in City)
            {
                foreach (string hood in Dallashoods)
                {
                    c.Add(new City());
                }
        }
        //method to query for all rest near lat/long
        //query for all rest of cat
    }
        public class Hood
        {   
             public Hood(string hood)//, string cities = ""/*, string rests = "a"*/)  //we're just gonna do two at first then build up
            {
            this.hood = hood;
            }
            //this.city = "";
            public string hood;
            public City city;
            public List<Restaurant> restaurants;
            //query for rest of cat
        }
        public class Restaurant
        {
            public string name;
            public Address address;
            public string websiteURL;
            //public Categories;  something wrong with how calling enum
        }
        public class LatLng
        {
            public double Lat;
            public double Long;

            public LatLng(string coord)
            {
                var coords = coord.Split(',').Select(s => double.Parse(s)).ToArray();
                Lat = coords[0];
                Long = coords[1];
            }
            public override string ToString()
            {
                return Lat.ToString() + "," + Long.ToString();
            }
        }
        public class Address
        {
            public LatLng latlong;
            public string streetAddress;
            public int zip;
            public string state;
            public City city;
        }

    }

