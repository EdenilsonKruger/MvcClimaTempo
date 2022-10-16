using System;

namespace MvcClimaTempo.Models
{
    public class PrevisaoClima
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal? TemperaturaMinima { get; set; }
        public decimal? TemperaturaMaxima { get; set; }

        public string TemperaturaMinimaFormatado
        {
            get
            {
                return (TemperaturaMinima.HasValue ? TemperaturaMinima.Value.ToString("N0") : "");
            }
        }

        public string TemperaturaMaximaFormatado
        {
            get
            {
                return (TemperaturaMaxima.HasValue ? TemperaturaMaxima.Value.ToString("N0") : "");
            }
        }

        public Cidade Cidade { get; set; }
    }
}