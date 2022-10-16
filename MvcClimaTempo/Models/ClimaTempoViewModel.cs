using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcClimaTempo.Models
{
    public class ClimaTempoViewModel
    {
        public List<PrevisaoClima> ListaCidadeQuente { get; set; }
        public List<PrevisaoClima> ListaCidadeFria { get; set; }

        public SelectList ListaCidade { get; set; }
        public List<PrevisaoClima> ListaClimaCidade { get; set; }
    }
}