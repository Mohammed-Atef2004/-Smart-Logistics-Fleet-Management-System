using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shipment.Events
{

    // Change from 'record' to 'class' to allow inheritance from DomainEvent (which is a class, not a record)
    public class ShipmentCreatedEvent : DomainEvent
    {
        public Guid ShipmentId { get; }

        public ShipmentCreatedEvent(Guid shipmentId)
        {
            ShipmentId = shipmentId;
        }
    }

}
