using GR.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Order
{
    public class OrderService
    {
        private readonly OrderMamagement _orderMamagement;

        public OrderService(OrderMamagement orderMamagement)
        {
            this._orderMamagement = orderMamagement;
        }

        public void CreateOrder()
        {

        }
    }
}
