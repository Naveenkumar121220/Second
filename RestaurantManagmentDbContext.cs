using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantManagment.Models
{
    public partial class RestaurantManagmentDbContext:DbContext
    {
        public RestaurantManagmentDbContext()

            : base("RMS_DB")

        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {

        }


    }
}