using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Entities
{
    /// <summary>
    /// 消费者
    /// </summary>
    public class Consumer : EntityBase
    {
        /// <summary>
        /// 地址ID
        /// </summary>
        public string AddressId { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// 创建订单
        /// </summary>
        /// <returns>
        /// 返回订单ID
        /// </returns>
        public string CreateOrder(PaymentInfo payment, DeliveryInfo delivery, Restaturant restaturant, List<OrderLineItem> items)
        {
            return Guid.NewGuid().ToString();
        }
    }
}
