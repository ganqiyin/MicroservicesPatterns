using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Entities
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Order : EntityBase
    {

        /// <summary>
        /// 订单项目
        /// </summary>
        public IComparable<OrderLineItem> Items { get; set; }
    }
}
