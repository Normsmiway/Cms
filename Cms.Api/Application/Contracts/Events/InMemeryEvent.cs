using MediatR;

namespace Cms.Api.Core.Bus
{
    public class InMemoryEventBus : IEventBus
    {
        private readonly IMediator _mediator;
        public InMemoryEventBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PublishAsync<TEvent>(params IEvent[] events) where TEvent : class, IEvent
        {
            foreach (IEvent @event in events)
            {
                await _mediator.Publish(@event);
            }
        }
    }
}
