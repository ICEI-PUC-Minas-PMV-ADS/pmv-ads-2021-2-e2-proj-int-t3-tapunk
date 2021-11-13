using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAirSoft.Models
{

    [Table("Eventos")]
    public class Eventos
    {
        [Key]
        public int Id { get; set; }

        public string NomedoEvento { get; set; }

        public string Endereço { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Data { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public string Pais { get; set; }

        public string TipodeEvento { get; set; }

        public string Descricao { get; set; }



    }
}
