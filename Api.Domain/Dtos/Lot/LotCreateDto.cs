using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Event;

namespace Api.Domain.Dtos.Lot
{
    public class LotCreateDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        public string LotName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        public DateTime InitialDate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigtório.")]
        public Guid EventiId { get; set; }
        public EventDto EventDto { get; set; }
    }
}

