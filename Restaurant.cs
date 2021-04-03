using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagment.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Provide Restaurant Name")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Select Cuisine Type")]
        [Display(Name = "Type of food")]
        public CuisineType Cuisine { get; set; }

        public enum CuisineType

        {

            Italian,

            Indian,

            French,

            Mexican,

            Chineese,

            Japaneese,

            Iranian,

            Spanish,

            Greece,

            American,

            Arabian

        }

        [Required(ErrorMessage = "Please Provide Online Orders")]
        [Display(Name = "Open for Online Orders?")]
        public bool OnlineOrders { get; set; }

         [Required(ErrorMessage = "Please Provide Valid Date")]
         [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime LaunchDate { get; set; }
    }

}
