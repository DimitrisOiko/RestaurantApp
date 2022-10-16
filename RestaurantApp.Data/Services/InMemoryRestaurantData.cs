﻿using RestaurantApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id=1, Name="Dimitris' Pizza", Cuisine=CuisineType.Italian },
                new Restaurant {Id=2, Name="Dimitris' Gyros", Cuisine=CuisineType.Indian },
                new Restaurant {Id=3, Name="Dimitris' Baguete", Cuisine=CuisineType.French }
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}