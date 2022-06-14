using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Entities
{
    /// <summary>
    /// 菜单（餐馆）
    /// </summary>
    public class MenuItem : EntityBase
    {
        /// <summary>
        /// 餐厅ID
        /// </summary>
        public string RestaturantId { get; set; }

        /// <summary>
        /// 餐厅
        /// </summary>
        public Restaturant Restaturant { get; set; }
    }
}
