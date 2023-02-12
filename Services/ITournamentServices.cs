using PokeTournament.Models;

namespace PokeTournament.Services
{
    public interface ITournamentServices
    {
        double PokeAvg(PokemonModel pokemon);

        PokemonModel GetWinner(PokemonModel pokemon, PokemonModel pokemon2);
        PokemonModel Fight(PokemonModel pokemon, PokemonModel pokemon2);
    }
}
