using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class SocialMediaEntity : BaseEntities
    {

        [Required]
        public string SocialMedia { get; set; }

        public string URL { get; set; }

        public int? EventId { get; set; }
        public EventEntity Event { get; set; }

        public int? SpeakerId { get; set; }
        public SpeakerEntity Speaker { get; set; }
    }
}

