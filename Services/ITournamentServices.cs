using PokeTournament.Models;

namespace PokeTournament.Services
{
    public interface ITournamentServices
    {
        double PokeAvg(PokemonModel pokemon);

        PokemonModel GetWinnerFight(PokemonModel pokemon, PokemonModel pokemon2);
        PokemonModel Fight(List<PokemonModel> pokemon);

        List<PokemonModel> OrderByAge(List<PokemonModel> pokemonsRng);
    }
}
