using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRockets.Models
{
    public class Concert
    {
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime ConcertDate { get; set; }
        public int tickets { get; set; }
        public double Price { get; set; }

        //Right-click on controller folder in the solution panel and add Concert controller to help retrive data
    }
}