using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAirSoft.Models
{
    [Table("Equipes")]
    public class Equipes
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome da equipe.")]
        public string NomedaEquipe { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o País.")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Estado.")]
        public string Uf { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a Cidade.")]
        public string Cidade { get; set; }

        public string Membro01 { get; set; }

        public string Membro02 { get; set; }

        public string Membro03 { get; set; }

        public string Membro04 { get; set; }

        public string Membro05 { get; set; }

        public string Membro06 { get; set; }

        public string HistoriadaEquipe { get; set; }
    }
}
