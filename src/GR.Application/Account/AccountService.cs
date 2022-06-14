using GR.Domain.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Account
{
    /// <summary>
    /// 统一处理支付和计费
    /// </summary>
    public class AccountService
    {
        public AccountService(ConsumerAccounting consumerAccounting, RestaurantAccounting restaurantAccounting, CourierAccounting courierAccounting)
        { }

        public void AuthorizeCard()
        {

        }
    }
}
