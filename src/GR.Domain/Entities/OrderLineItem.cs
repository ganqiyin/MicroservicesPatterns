using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Entities
{
    /// <summary>
    /// 订单项
    /// </summary>
    public class OrderLineItem:EntityBase
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        public Order  Order { get; set; }
    }
}
