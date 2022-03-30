using PMS.Shared.Events;

namespace PMS.Shared.Messaging;

public interface IMessageBroker
{
    Task PublishAsync(IEvent @event, CancellationToken cancellationToken = default);
}