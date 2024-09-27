using Shared.Messages;
using MassTransit;
namespace Shared.OrderEvents;

public class OrderCreatedEvent: CorrelatedBy<Guid>
{
    public OrderCreatedEvent(Guid correlationId)
    {
        CorrelationId = correlationId;
    }
    public Guid CorrelationId { get; }
    public List<OrderItemMessage> OrderItems { get; set; }

}