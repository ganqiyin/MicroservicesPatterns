using GR.Domain.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Restaurant
{
    public class RestaurantService
    {
        private readonly RestaurantInfoManagement _restaurantInfoManagement;

        public RestaurantService(RestaurantInfoManagement restaurantInfoManagement) {
            this._restaurantInfoManagement = restaurantInfoManagement;
        }
    }
}
