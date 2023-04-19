using Microsoft.AspNetCore.Mvc;
using PokeTournament.Repository;

namespace PokeTournament.Controllers
{
    public class TournamentController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public TournamentController(IPokemonRepository ipokerepo)
        {
            _pokemonRepository = ipokerepo;
        }
        public IActionResult Index()
        {
            //var pokeRepo = _pokemonRepository.GetAll();

            return View();
        }
    }
}
