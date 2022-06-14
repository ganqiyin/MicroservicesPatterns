using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Entities
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderState : int
    {
        /// <summary>
        /// 等待接受
        /// </summary>
        [Description("等待接受")]
        PENDING_ACCEPTANCE = 1,

        /// <summary>
        /// 已接受
        /// </summary>
        [Description("已接受")]
        ACCEPTED = 2
    }
}
