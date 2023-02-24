using PokeTournament.Models;

namespace PokeTournament.Services
{
    public interface ITournamentServices
    {
        double PokeAvg(PokemonModel pokemon);
        PokemonModel GetWinnerDuel(PokemonModel pokemon, PokemonModel pokemon2);
        List<PokemonModel> Fight(List<PokemonModel> pokemon);
        List<PokemonModel> OrderByRandom(List<PokemonModel> pokemonsRng);
        PokemonModel GetFinalWinner(List<PokemonModel> pokemons);
    }
}
