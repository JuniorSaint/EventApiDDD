using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.SocialMedia;

namespace Api.Domain.Dtos.Speaker
{
    public class SpeakerCreateDto
    {
        [Display(Name = "Nome do orador"),
         Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string SpeakerName { get; set; }

        public string MiniResume { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$",
             ErrorMessage = "Não é uma imagem válida. (gif, jpg, jpeg, bmp ou png)")]
        public string SpeakerImage { get; set; }

        [Phone]
        public string SpeakerPhone { get; set; }

        [Display(Name = "e-mail"),
         EmailAddress(ErrorMessage = "O {0} esta em formato errado")]
        public string SpeakerEmail { get; set; }
    }
}

