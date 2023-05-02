using Microsoft.AspNetCore.Mvc;
using PokeTournament.Models;
using PokeTournament.Repository;
using PokeTournament.Services;
using System.Collections.Generic;

namespace PokeTournament.Controllers
{
    public class TournamentController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly ITournamentServices _tournamentServices;

        public TournamentController(IPokemonRepository pokemonRepository, ITournamentServices tournamentServices)
        {
            _pokemonRepository = pokemonRepository;
            _tournamentServices = tournamentServices;

        }
                
        public IActionResult Index()
        {
            //var pokeRepo = _pokemonRepository.GetAll();

            return View();
        }
        [HttpPost]
        public IActionResult Winner(IFormCollection pokemons)
        {
            List<PokemonModel> pokeList = _pokemonRepository.GetPokeById(pokemons);
            pokeList = _tournamentServices.OrderByRandom(pokeList);
            pokeList = _tournamentServices.RoundOf16(pokeList);
            pokeList = _tournamentServices.Quarterfinals(pokeList);
            pokeList = _tournamentServices.Semifinals(pokeList);
            PokemonModel pokeWinner = _tournamentServices.FinalMatch(pokeList);
            return View(pokeWinner);
        }
    }
}
