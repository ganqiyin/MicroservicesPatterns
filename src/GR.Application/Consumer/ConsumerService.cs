using GR.Domain.Consumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Consumer
{
    /// <summary>
    /// 消费者管理
    /// </summary>
    public class ConsumerService
    {
        private readonly ConsumerManagement _consumerManagement;

        public ConsumerService(ConsumerManagement consumerManagement)
        {
            this._consumerManagement = consumerManagement;
        }
    }
}
