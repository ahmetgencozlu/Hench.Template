using NetDevPack.Messaging;

namespace Hench.Template.Domain.Core.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
