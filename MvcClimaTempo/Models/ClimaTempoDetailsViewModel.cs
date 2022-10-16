using System;
using System.Collections.Generic;
using System.Globalization;

namespace MvcClimaTempo.Models
{
    public class ClimaTempoDetailsCidadeViewModel
    {
        public string NomeCidade { get; set; }
        public string Uf { get; set; }

        public List<ClimaTempoDetailsViewModel> Detalhes { get; set; }

        public string CidadeFormatado
        {
            get
            {
                return NomeCidade + "/" + Uf;
            }
        }
    }

    public class ClimaTempoDetailsViewModel
    {
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal? TemperaturaMinima { get; set; }
        public decimal? TemperaturaMaxima { get; set; }

        public string DiaSemana
        {
            get
            {
                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                string data = dtfi.GetDayName(DataPrevisao.DayOfWeek);
                return data.Substring(0, 1).ToUpper() + data.Substring(1);
            }
        }
        public string IconeClima
        {
            get
            {
                var icone = "<i class='fa fa-cloud-sun' style='font-size: 22px;'></i>";
                switch (Clima.ToUpper())
                {
                    case "CHUVOSO":
                        icone = "<i class='fa fa-cloud-showers-heavy' style='font-size: 22px;'></i>";
                        break;
                    case "ENSOLARADO":
                        icone = "<i class='fa fa-sun' style='font-size: 22px;'></i>";
                        break;
                    case "INSTAVEL":
                        icone = "<i class='fa fa-cloud-sun' style='font-size: 22px;'></i>";
                        break;
                    case "NUBLADO":
                        icone = "<i class='fa fa-cloud' style='font-size: 22px;'></i>";
                        break;
                    case "TEMPESTUOSO":
                        icone = "<i class='fa fa-poo-storm' style='font-size: 22px;'></i>";
                        break;
                }

                return icone;
            }
        }
        public string TemperaturaMinimaFormatado
        {
            get
            {
                return (TemperaturaMinima.HasValue ? string.Format("Mínima {0}°C", TemperaturaMinima.Value.ToString("N0")) : "");
            }
        }
        public string TemperaturaMaximaFormatado
        {
            get
            {
                return (TemperaturaMaxima.HasValue ? string.Format("Máxima {0}°C", TemperaturaMaxima.Value.ToString("N0")) : "");
            }
        }
    }
}