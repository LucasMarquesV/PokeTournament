using Microsoft.EntityFrameworkCore;
using PokeTournament.Data;
using PokeTournament.Models;

namespace PokeTournament.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly BancoContext _bancoContext;

        public PokemonRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
            
        }
        public List<PokemonModel> GetAll()
        {
            return _bancoContext.ListPokemon.ToList();
        }
        //public List<PokemonTestModel> GetAllTeste()
        //{
        //    return _bancoContext.TestePokemon.ToList();
        //}
    }
}
