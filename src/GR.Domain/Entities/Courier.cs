using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Entities
{
    /// <summary>
    /// 送餐员
    /// </summary>
    public class Courier : EntityBase
    {
        /// <summary>
        /// 定位
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// 更新定位：当前位置
        /// </summary>
        public void UpdateLocation()
        {
            //noteUpdateLoacation()
        }


        /// <summary>
        /// 已取餐
        /// </summary>
        public void DeliveryPickedUp()
        {
            //noteDeliveryPickedUp
        }


        /// <summary>
        /// 已送餐
        /// </summary>
        public void DeliveryDelivered()
        {
            //noteDeliveryDelivered
        }
    }
}
