using Microsoft.AspNetCore.Mvc;
using PokeTournament.Models;
using PokeTournament.Repository;
using System.Diagnostics;

namespace PokeTournament.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPokemonRepository _pokemonRepository;


        public HomeController(ILogger<HomeController> logger, IPokemonRepository pokemonRepository)
        {
            _logger = logger;
            _pokemonRepository = pokemonRepository;
        }

        public IActionResult Index()
        {
            //List<PokemonModel> pokeList1 = new List<PokemonModel> {
            //    new PokemonModel{ Id = 1, PokeAtk = 1, PokeAvg = 1, PokeDef = 1, PokeHp = 1, PokeName = "a", PokeSpd = 1, PokeType = "a" },
            //    new PokemonModel { Id = 2, PokeAtk = 1, PokeAvg = 1, PokeDef = 1, PokeHp = 1, PokeName = "a", PokeSpd = 1, PokeType = "a" }
            //    };

            List<PokemonModel> pokeList = _pokemonRepository.GetAll();

            return View(pokeList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}