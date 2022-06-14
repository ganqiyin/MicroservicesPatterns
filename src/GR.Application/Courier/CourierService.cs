using GR.Domain.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Courier
{
    public class CourierService
    {
        private readonly CourierManagement _courierManagement;

        public CourierService(CourierManagement courierManagement) {
            this._courierManagement = courierManagement;
        }
    }
}
