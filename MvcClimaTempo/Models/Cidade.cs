using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcClimaTempo.Models
{
    public class Cidade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }

        public Estado Estado { get; set; }

        public ICollection<PrevisaoClima> PrevisaoClimas { get; set; }


        public string NomeFormatado
        {
            get
            {
                return Nome + (Estado != null ? "/" + Estado.UF : "");
            }
        }

    }
}