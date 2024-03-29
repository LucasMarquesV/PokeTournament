﻿using Microsoft.AspNetCore.Mvc;
using PokeTournament.Models;
using PokeTournament.Repository;

namespace PokeTournament.Controllers
{
    public class SelectionController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public SelectionController(IPokemonRepository ipokerepo)
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
