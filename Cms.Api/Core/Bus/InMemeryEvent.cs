namespace Cms.Api.Core.Bus
{
    public class InMemeryEventBus : IEventBus
    {
        public InMemeryEventBus()
        {

        }
        Task IEventBus.PublishAsync<TEvent>(params IEvent[] events)
        {
            throw new NotImplementedException();
        }
    }
}
