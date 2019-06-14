using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRockets.Models
{
    public class Concert
    {
        //Using Entity Framework
        //Create an Id Property and => right click on Controller & add new Entity view contoller
        //Ass part it this will create a local database and add connection in t Web.config anf IdentityModel.cs files
        public String Id { get; set; }

        //Adding (DataAnnotation) is used to format field
        [Required]
        [StringLength(50)] //Max field lenght
        public string Name { get; set; }

        public string City { get; set; }

        [Display(Name = "Concert Date")] //Adds display item
        public DateTime ConcertDate { get; set; }

        [Display(Name = "Backstage Pass")]
        public int tickets { get; set; }

        [DataType(DataType.Currency)]//shows in browsers default currency
        public double Price { get; set; }

        [Display(Name = "Passcode")]
        [RegularExpression(@"\d{3,9}", ErrorMessage ="Passcode Must be 3-9 digits")]
        public double Password { get; set; }
        //After adding this password field - //right-click on the View() in -> re-Add view -> give it a name and select Edit (Concert (MVCRockets.Models)) adn tick Reference scrpit Libraries


        //Right-click on controller folder in the solution panel and add Concert controller to help retrive data


        public string PromoterName { get; set; }
        //Use the Package Manager Console to perform migrations after adding new property

    }
}