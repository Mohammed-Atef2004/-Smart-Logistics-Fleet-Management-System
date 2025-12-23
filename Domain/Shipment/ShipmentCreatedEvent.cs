using Domain.Common;

namespace Domain.Shipment
{
    internal class ShipmentCreatedEvent : DomainEvent
    {
        private object id;

        public ShipmentCreatedEvent(object id)
        {
            this.id = id;
        }
    }
}