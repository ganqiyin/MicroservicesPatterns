using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Entities
{
    /// <summary>
    /// 餐厅
    /// </summary>
    public class Restaturant : EntityBase
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
        /// 接收订单
        /// </summary>
        public void AcceptOrder(string orderId,DateTime readyByTime)
        {

        }

        /// <summary>
        /// 订单准备完成，可以送餐
        /// </summary>
        public void OrderReadyForPickup()
        {
            // 通知送餐：NoteOrderReadyForPickup
        }
    }
}
