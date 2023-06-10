//using Kotlin.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPhotosProject.Models
{
    public class MonkeyResources
    {
        public string name { get; set; }
        public string location { get; set; }
        public string details { get; set; }
        public string image { get; set; }
        public string population { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
       

        public MonkeyResources(string name, string location, string details, string image, string population, string lat, string longt)
        {
            this.name = name;
            this.location = location;
            this.details = details;
            this.image = image;
            this.population = population;
            this.latitude = lat;
            this.longitude = longt;
        }
    }
}
