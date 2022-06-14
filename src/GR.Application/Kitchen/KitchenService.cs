using GR.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Kitchen
{
    public class KitchenService
    {
        private readonly RestaurantOrderTicketManagement _restaurantOrderTicketManagement;

        public KitchenService(RestaurantOrderTicketManagement restaurantOrderTicketManagement)
        {
            this._restaurantOrderTicketManagement = restaurantOrderTicketManagement;
        }
    }
}
