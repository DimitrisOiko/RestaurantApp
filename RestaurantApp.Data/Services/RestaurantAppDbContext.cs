﻿using RestaurantApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Services 
{
    public class RestaurantAppDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
