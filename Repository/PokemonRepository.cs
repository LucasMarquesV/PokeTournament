using Microsoft.EntityFrameworkCore;
using PokeTournament.Data;
using PokeTournament.Models;

namespace PokeTournament.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly BancoContext _bancoContext;
        private readonly DbSet<PokemonModel> _dbset;

        public PokemonRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
            _dbset = bancoContext.Set<PokemonModel>();
        }

        public List<PokemonModel> GetPokeById(IFormCollection ids)
        {
            List<PokemonModel> pokemons = new List<PokemonModel>();

            foreach (var id in ids)
            {
                pokemons.Add(_dbset.Find(Convert.ToInt32(id.Key)));
            }

            return pokemons;
        }
        public PokemonModel GetPokeById(int id)
        {
            return _dbset.Find(id);
        }


        public List<PokemonModel> GetAll()
        {
            return _bancoContext.ListPokemon.ToList();
        }
    }
}
