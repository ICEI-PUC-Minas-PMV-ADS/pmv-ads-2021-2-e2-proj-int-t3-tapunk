using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAirSoft.Models
{

    [Table("Equipes")]
    public class Equipes
    {
        [Key]
        public int Id { get; set; }

        public string NomedaEquipe { get; set; }

        public string Pais { get; set; }

        public string Uf { get; set; }

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
