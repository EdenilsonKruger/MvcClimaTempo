using MvcClimaTempo.Contexts;
using System;
using System.Linq;

namespace MvcClimaTempo.Models
{
    public static class SeedData
    {
        private static int proximoIdEstado = 0;
        private static int proximoIdCidade = 0;

        public static void Initialize()
        {
            using (var context = new MvcClimaTempoContext())
            {
                // Procure qualquer PrevisaoClima.
                if (context.PrevisaoClimas.Any())
                {
                    return;   // DB Encontrado
                }

                InserirSaoPaulo(context);
                InserirParana(context);
                InserirSantaCatarina(context);

                context.SaveChanges();
            }
        }

        private static void InserirSaoPaulo(MvcClimaTempoContext context)
        {
            //Estado
            proximoIdEstado += 1;
            SetEstado(context, proximoIdEstado, "São Paulo", "SP");

            //Cidade Apiaí
            proximoIdCidade += 1;
            SetCidade(context, proximoIdCidade, "Apiaí", proximoIdEstado);
            //PrevisaoClima Apiaí
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 17), "Instavel", 15, 25);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 18), "Tempestuoso", 14, 23);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 19), "Chuvoso", 13, 26);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 20), "Nublado", 15, 17);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 21), "Ensolarado", 15, 21);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 22), "Tempestuoso", 13, 19);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 23), "Nublado", 12, 21);

            //Cidade Avanhandava
            proximoIdCidade += 1;
            SetCidade(context, proximoIdCidade, "Avanhandava", proximoIdEstado);
            //PrevisaoClima Avanhandava
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 17), "Ensolarado", 19, 33);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 18), "Nublado", 19, 31);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 19), "Chuvoso", 18, 29);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 20), "Tempestuoso", 18, 33);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 21), "Instavel", 17, 33);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 22), "Chuvoso", 17, 28);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 23), "Nublado", 20, 34);

            //Cidade Catiguá
            proximoIdCidade += 1;
            SetCidade(context, proximoIdCidade, "Catiguá", proximoIdEstado);
            //PrevisaoClima Catiguá
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 17), "Tempestuoso", 20, 34);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 18), "Chuvoso", 19, 34);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 19), "Nublado", 19, 34);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 20), "Instavel", 21, 33);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 21), "Ensolarado", 20, 34);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 22), "Tempestuoso", 18, 31);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 23), "Instavel", 19, 35);
        }

        private static void InserirParana(MvcClimaTempoContext context)
        {
            //Estado
            proximoIdEstado += 1;
            SetEstado(context, proximoIdEstado, "Paraná", "PR");

            //Cidade Faxinal
            proximoIdCidade += 1;
            SetCidade(context, proximoIdCidade, "Faxinal", proximoIdEstado);
            //PrevisaoClima Faxinal
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 17), "Nublado", 19, 23);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 18), "Ensolarado", 13, 24);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 19), "Tempestuoso", 13, 23);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 20), "Instavel", 14, 26);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 21), "Tempestuoso", 15, 23);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 22), "Nublado", 13, 25);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 23), "Chuvoso", 15, 28);

            //Cidade Ibiporã
            proximoIdCidade += 1;
            SetCidade(context, proximoIdCidade, "Ibiporã", proximoIdEstado);
            //PrevisaoClima Ibiporã
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 17), "Tempestuoso", 18, 25);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 18), "Instavel", 17, 26);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 19), "Nublado", 15, 28);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 20), "Chuvoso", 17, 29);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 21), "Chuvoso", 16, 27);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 22), "Nublado", 16, 29);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 23), "Ensolarado", 15, 28);
        }

        private static void InserirSantaCatarina(MvcClimaTempoContext context)
        {
            //Estado
            proximoIdEstado += 1;
            SetEstado(context, proximoIdEstado, "Santa Catarina", "SC");

            //Cidade Bombinhas
            proximoIdCidade += 1;
            SetCidade(context, proximoIdCidade, "Bombinhas", proximoIdEstado);
            //PrevisaoClima Bombinhas
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 17), "Chuvoso", 17, 19);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 18), "Nublado", 16, 19);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 19), "Tempestuoso", 18, 23);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 20), "Instavel", 18, 24);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 21), "Nublado", 17, 21);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 22), "Ensolarado", 14, 24);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 23), "Tempestuoso", 16, 22);

            //Cidade Criciúma
            proximoIdCidade += 1;
            SetCidade(context, proximoIdCidade, "Criciúma", proximoIdEstado);
            //PrevisaoClima Criciúma
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 17), "Nublado", 14, 21);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 18), "Instavel", 13, 21);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 19), "Ensolarado", 15, 25);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 20), "Tempestuoso", 15, 26);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 21), "Tempestuoso", 14, 23);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 22), "Nublado", 13, 19);
            SetPrevisaoClima(context, proximoIdCidade, new DateTime(2022, 10, 23), "Chuvoso", 12, 19);
        }


        private static void SetEstado(MvcClimaTempoContext context, int id, string nome, string uf)
        {
            context.Estados.Add(
                new Estado
                {
                    Id = id,
                    Nome = nome,
                    UF = uf
                }
            );
        }

        private static void SetCidade(MvcClimaTempoContext context, int id, string nome, int estadoId)
        {
            context.Cidades.Add(
                new Cidade
                {
                    Id = id,
                    Nome = nome,
                    EstadoId = estadoId
                }
            );
        }

        private static void SetPrevisaoClima(MvcClimaTempoContext context, int cidadeId, DateTime dataPrevisao, string clima, decimal temperaturaMinima, decimal temperaturaMaxima)
        {
            context.PrevisaoClimas.Add(
                new PrevisaoClima
                {
                    CidadeId = cidadeId,
                    DataPrevisao = dataPrevisao,
                    Clima = clima,
                    TemperaturaMinima = temperaturaMinima,
                    TemperaturaMaxima = temperaturaMaxima
                }
            );
        }

    }
}