using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Speaker
{
    public class SpeakerUpdateDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string SpeakerName { get; set; }

        public string MiniResume { get; set; }
        public string ImagePath { get; set; }
        public string SpeakerPhone { get; set; }

        [EmailAddress(ErrorMessage = "O {0} esta em formato errado")]
        public string SpeakerEmail { get; set; }
    }
}

