using Microsoft.AspNetCore.Mvc;
using PokeTournament.Models;
using PokeTournament.Repository;

namespace PokeTournament.Controllers
{
    public class Pokedex2Controller : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public Pokedex2Controller(IPokemonRepository ipokerepo)
        {
            _pokemonRepository = ipokerepo;
        }
        public IActionResult index()
        {
            //List<PokemonModel> pokeList1 = new List<PokemonModel> {
            //    new PokemonModel{ Id = 1, PokeAtk = 1, PokeAvg = 1, PokeDef = 1, PokeHp = 1, PokeName = "a", PokeSpd = 1, PokeType = "a" },
            //    new PokemonModel { Id = 2, PokeAtk = 1, PokeAvg = 1, PokeDef = 1, PokeHp = 1, PokeName = "a", PokeSpd = 1, PokeType = "a" }
            //    };

            List<PokemonModel> pokeList = _pokemonRepository.GetAll();

            return View(pokeList);
        }

        public IActionResult index2()
        {
            

            List<PokemonModel> pokeList = _pokemonRepository.GetAll();

            return View(pokeList);
        }
    }
}
