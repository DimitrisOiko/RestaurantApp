using RestaurantApp.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Services
{
    interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

    }
}
