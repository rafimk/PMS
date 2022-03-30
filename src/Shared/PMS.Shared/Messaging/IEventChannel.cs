using System.Threading.Channels;
using PMS.Shared.Events;

namespace PMS.Shared.Messaging;

internal interface IEventChannel
{
    ChannelReader<IEvent> Reader { get; }
    ChannelWriter<IEvent> Writer { get; }
}