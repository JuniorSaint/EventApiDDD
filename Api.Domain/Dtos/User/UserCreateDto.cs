using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "Nome do usuário é campo obrigatório")]
        [MaxLength(90, ErrorMessage = "Número máximo de caractes {1} ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email é campo obrigatório")]
        [EmailAddress(ErrorMessage = "email em formato inválido")]
        [MaxLength(100, ErrorMessage = "Número máximo de caractes {1} ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha do usuário é campo obrigatório")]
        [MinLength(6, ErrorMessage = "Quantidade mínima de  caracteres {1}")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Usuário ativo é campo obrigatório")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Tipo de usuário é campo obrigatório")]
        public string UserType { get; set; }
    }
}

