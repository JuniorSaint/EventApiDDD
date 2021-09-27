using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.SocialMedia;

namespace Api.Domain.Dtos.Speaker
{
    public class SpeakerCreateDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string SpeakerName { get; set; }

        public string MiniResume { get; set; }
        public string ImagePath { get; set; }
        public string SpeakerPhone { get; set; }

        [EmailAddress(ErrorMessage = "O {0} esta em formato errado")]
        public string SpeakerEmail { get; set; }
    }
}

