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

        public void FindAvailableRestaurants()
        {

        }


        /// <summary>
        /// 验证订单行项目，验证送货地址和时间是否在餐厅服务区域内，验证订单最低要求，并获得订单行项目的价格
        /// </summary>
        public void VerifyOrderDetail() { }
    }
}
