using System.Text.Json.Serialization;

namespace Cms.Api.Core.Bus
{
    public interface IEventBus
    {
        public Task PublishAsync<TEvent>(params IEvent[] @events) where TEvent : class, IEvent;
    }

    public interface IEvent
    {
        public string Id { get; }
        public string Type { get; }
        public DateTime OccurredOn { get; }
    }


    public class ConsentEventBase : IEvent
    {
        public ConsentEventBase(string id, string type)
        {
            Id = id;
            Type = type;
            OccurredOn = DateTime.Now;
        }

        [JsonIgnore]
        public string Id { get; }
        [JsonIgnore]
        public string Type { get; }
        public DateTime OccurredOn { get; }

    }

    public class BeforeConsent : ConsentEventBase
    {
        public BeforeConsent(string id, string type) : base(id, type)
        {
        }
    }
    public class OnConsenting : ConsentEventBase
    {
        public OnConsenting(string id, string type) : base(id, type)
        {
        }
    }
    public class AfterConsent : ConsentEventBase
    {
        public AfterConsent(string id, string type) : base(id, type)
        {
        }
    }

}
