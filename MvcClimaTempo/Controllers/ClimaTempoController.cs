using MvcClimaTempo.Contexts;
using MvcClimaTempo.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MvcClimaTempo.Controllers
{
    public class ClimaTempoController : Controller
    {

        private MvcClimaTempoContext db = new MvcClimaTempoContext();

        // GET: ClimaTempo
        public ActionResult Index()
        {
            //Carga inicial se não existir nenhum registro na PrevisaoClima
            SeedData.Initialize();

            var listaCidade = db.Cidades.Include("Estado").ToList();

            var primeiraData = db.PrevisaoClimas.OrderBy(x => x.DataPrevisao).First().DataPrevisao;

            var listaClimaTempo = (from p in db.PrevisaoClimas.Include("Cidade").Include("Cidade.Estado")
                                   where p.DataPrevisao == primeiraData
                                   select p).ToList();

            var listaCidadeQuente = (from x in listaClimaTempo
                                     orderby x.TemperaturaMaxima descending
                                     select x).Take(3).ToList();

            var listaCidadeFria = (from x in listaClimaTempo
                                   orderby x.TemperaturaMinima
                                   select x).Take(3).ToList();

            var previsaoClimaVM = new ClimaTempoViewModel
            {
                ListaCidadeQuente = listaCidadeQuente,
                ListaCidadeFria = listaCidadeFria,

                ListaCidade = new SelectList(listaCidade, "Id", "NomeFormatado")
            };

            return View(previsaoClimaVM);
        }

        // GET: ClimaTempo/Details/1
        public ActionResult Details(int idCidade)
        {
            var cidade = db.Cidades.Include("Estado").Where(x => x.Id == idCidade).FirstOrDefault();

            var detalhes = (from x in db.PrevisaoClimas
                            where x.CidadeId == cidade.Id
                            orderby x.DataPrevisao
                            select new ClimaTempoDetailsViewModel
                            {
                                DataPrevisao = x.DataPrevisao,
                                Clima = x.Clima,
                                TemperaturaMinima = x.TemperaturaMinima,
                                TemperaturaMaxima = x.TemperaturaMaxima
                            }).Take(7).ToList();

            var detalheCidade = new ClimaTempoDetailsCidadeViewModel()
            {
                NomeCidade = cidade.Nome,
                Uf = cidade.Estado.UF,
                Detalhes = detalhes
            };

            return PartialView("Details", detalheCidade);
        }
    }
}