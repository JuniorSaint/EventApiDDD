using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Lot;
using Api.Domain.Dtos.SocialMedia;
using Api.Domain.Dtos.Speaker;

namespace Api.Domain.Dtos.Event
{
    public class EventCreateDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        public string Local { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        public DateTime EventDate { get; set; }
        private DateTime _eventDate
        {
            get { return _eventDate; }
            set
            {
                if (value > DateTime.UtcNow)
                {
                    _eventDate = value;
                }
            }
        }

        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        [Range(3, 50, ErrorMessage = "Quantidade mínima de caracteres {1} quantidade máxima de caracteres {2}")]
        public string Thema { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        [Range(1, 120000, ErrorMessage = "{0} não pode ser menor que 1 e maior que 120.000")]
        public int PeopleAmount { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$",
                           ErrorMessage = "Não é uma imagem válida. (gif, jpg, jpeg, bmp ou png)")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Phone(ErrorMessage = "O campo {0} está com número inválido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "e-mail")]
        [EmailAddress(ErrorMessage = "É necessário ser um {0} válido")]
        public string Email { get; set; }

        public IEnumerable<LotDto> Lots { get; set; }
        public IEnumerable<SocialMediaDto> socialMedias { get; set; }
        public IEnumerable<SpeakerDto> Speakers { get; set; }
    }
}

