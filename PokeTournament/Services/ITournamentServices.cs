using PokeTournament.Models;

namespace PokeTournament.Services
{
    public interface ITournamentServices
    {
        double PokeAvg(PokemonModel pokemon);
        PokemonModel GetWinnerDuel(PokemonModel pokemon, PokemonModel pokemon2);
        List<PokemonModel> OrderByRandom(List<PokemonModel> pokemonsRng);
        public List<PokemonModel> RoundOf16(List<PokemonModel> pokeList);
        public List<PokemonModel> Quarterfinals(List<PokemonModel> pokeList);
        public List<PokemonModel> Semifinals(List<PokemonModel> pokeList);
        public PokemonModel FinalMatch(List<PokemonModel> pokeList);
    }
}
