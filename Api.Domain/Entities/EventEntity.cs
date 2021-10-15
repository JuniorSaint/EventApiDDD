using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class EventEntity : BaseEntities
    {
        [Required]
        public string Local { get; set; }

        [Required]
        public DateTime EventDate { get; set; }


        [DefaultValue("00:00")]
        [Required]
        public TimeSpan EventTime { get; set; }

        [Required]
        public string Theme { get; set; }

        [Required]
        public int PeopleAmount { get; set; }

        [Required]
        public string EventImage { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IEnumerable<LotEntity> Lots { get; set; }
        public IEnumerable<SocialMediaEntity> socialMedias { get; set; }
        public IEnumerable<EventSpeakerEntity> EventSpeakers { get; set; }
    }
}

