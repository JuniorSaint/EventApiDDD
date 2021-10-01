using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Api.Domain.Entities
{
    public class SpeakerEntity : BaseEntities
    {
        [Required]
        public string SpeakerName { get; set; }
        public string MiniResume { get; set; }
        public string ImagePath { get; set; }
        public string SpeakerPhone { get; set; }
        public string SpeakerEmail { get; set; }
        public IEnumerable<SocialMediaEntity> SocialMedias { get; set; }
        public IEnumerable<EventSpeakerEntity> EventSpeakers { get; set; }
    }
}

