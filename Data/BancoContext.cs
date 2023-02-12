using Microsoft.EntityFrameworkCore;
using PokeTournament.Models;

namespace PokeTournament.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<PokemonModel> ListPokemon { get; set; }
    }
}
