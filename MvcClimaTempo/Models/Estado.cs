using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcClimaTempo.Models
{
    public class Estado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }

        public ICollection<Cidade> Cidades { get; set; }
    }
}