using GR.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Delivery
{
    public class DeliveryService
    {
        private readonly CurierAvailabilityManagement _curierAvailabilityManagement;

        public DeliveryService(CurierAvailabilityManagement curierAvailabilityManagement, DeliveryManagement deliveryManagement)
        {
            this._curierAvailabilityManagement = curierAvailabilityManagement;
        }

        public void NoteUpdateLocation()
        {

        }

        public void NoteDeliveryPickedUp()
        {

        }

        public void NoteDeliveryDelivered()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void ScheduleDelivery()
        {

        }
    }
}
