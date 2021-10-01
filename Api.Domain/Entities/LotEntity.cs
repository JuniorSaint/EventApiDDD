using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class LotEntity : BaseEntities
    {
        [Required]
        public string LotName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime InitialDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Amount { get; set; }

        public Guid EventiId { get; set; }
        public EventEntity Event { get; set; }
    }
}

