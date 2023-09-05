using TaskManagment.Domain.Core.Events;

namespace TaskManagment.Domain.Core.Data
{
    public interface IEventStore
    {
        void Save<T>(T eventData) where T : StoredEvent;
    }
}
