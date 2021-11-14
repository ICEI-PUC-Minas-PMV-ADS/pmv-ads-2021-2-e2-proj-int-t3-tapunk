using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjetoAirSoft.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        public static ClaimsIdentity Nome { get; internal set; }
        [Key]
        [Required(ErrorMessage = "Obrigatório informar o e-mail!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha
        {
            get; set;

        }
    }
}
