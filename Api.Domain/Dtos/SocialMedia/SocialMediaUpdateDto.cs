using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Event;
using Api.Domain.Dtos.Speaker;

namespace Api.Domain.Dtos.SocialMedia
{
    public class SocialMediaUpdateDto
    {
        [Required(ErrorMessage = "{0} é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string SocialMedia { get; set; }

        public string URL { get; set; }

        public int? EventId { get; set; }
        public EventDto Event { get; set; }

        public int? SpeakerId { get; set; }
        public SpeakerDto Speaker { get; set; }
    }
}

