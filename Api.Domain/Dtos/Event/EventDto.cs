using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Lot;
using Api.Domain.Dtos.SocialMedia;
using Api.Domain.Dtos.Speaker;

namespace Api.Domain.Dtos.Event
{
    public class EventDto
    {
        public Guid? Id { get; set; }

        public string Local { get; set; }

        public DateTime EventDate { get; set; }

        public string Theme { get; set; }

        public int PeopleAmount { get; set; }

        public string ImagePath { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        //public IEnumerable<LotDto> Lots { get; set; }
        //public IEnumerable<SocialMediaDto> socialMedias { get; set; }
        //public IEnumerable<SpeakerDto> Speakers { get; set; }

        public DateTime? CreatedAt { get; }

        public DateTime? UpdatedAt { get; }
    }
}

