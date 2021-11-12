using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAirSoft.Models
{
    [Table("Cadastrar")]
    public class Cadastrar
    {
        
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o nome.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o apelido.")]
        public string Apelido { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a idade.")]
        public int Idade { get; set; }

       
        [Required(ErrorMessage = "Obrigatório informar o endereço de e-mail.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a cidade.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o estado")]
        public string UF { get; set; }

        



    }
    public enum Sexo
    {
        masculino,
        feminino
    }

    public enum Tipo
    {
        usuario,
        admin
    }
}
