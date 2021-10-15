using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class PasswordEntity : BaseEntities
    {
        [Required]
        public string Password { get; set; }
    }
}

