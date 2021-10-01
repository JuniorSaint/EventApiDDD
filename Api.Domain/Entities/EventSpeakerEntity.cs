using System;
namespace Api.Domain.Entities
{
    public class EventSpeakerEntity
    {
        public Guid SpeakerId { get; set; }
        public SpeakerEntity Speaker { get; set; }

        public Guid EventId { get; set; }
        public EventEntity Event { get; set; }
    }
}

