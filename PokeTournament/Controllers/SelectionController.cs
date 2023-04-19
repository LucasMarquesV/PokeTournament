using Microsoft.AspNetCore.Mvc;
using PokeTournament.Models;
using PokeTournament.Repository;

namespace PokeTournament.Controllers
{
    public class PokedexController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokedexController(IPokemonRepository ipokerepo)
        {
            _pokemonRepository = ipokerepo;
        }
        public IActionResult index()
        {            

            List<PokemonModel> pokeList = _pokemonRepository.GetAll();

            return View(pokeList);
        }

       
    }
}
