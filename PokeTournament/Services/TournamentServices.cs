using PokeTournament.Models;

namespace PokeTournament.Services
{
    public class TournamentServices : ITournamentServices
    {
        public double PokeAvg(PokemonModel pokemon)
        {
            var avg = (pokemon.PokeHp + pokemon.PokeDef + pokemon.PokeSpd + pokemon.PokeAtk) / 4;
            return avg;
        }

        public PokemonModel FinalMatch(List<PokemonModel> pokeList)
        {
            return GetWinnerDuel(pokeList[0], pokeList[1]);
        }
        public List<PokemonModel> Semifinals(List<PokemonModel> pokeList)
        {
            List<PokemonModel> result = new List<PokemonModel>();
            for (int i = 0; i < 2; i++)
            {
                PokemonModel pokemon = pokeList[i * 2];
                PokemonModel pokemon2 = pokeList[i * 2 + 1];
                PokemonModel winner = GetWinnerDuel(pokemon, pokemon2);
                result.Add(winner);
            }
            return result;
        }
        public List<PokemonModel> Quarterfinals(List<PokemonModel> pokeList)
        {
            List<PokemonModel> result = new List<PokemonModel>();
            for (int i = 0; i < 4; i++)
            {
                PokemonModel pokemon = pokeList[i * 2];
                PokemonModel pokemon2 = pokeList[i * 2 + 1];
                PokemonModel winner = GetWinnerDuel(pokemon, pokemon2);
                result.Add(winner);
            }
            return result;
        }
        public List<PokemonModel> RoundOf16(List<PokemonModel> pokeList)
        {
            List<PokemonModel> result = new List<PokemonModel>();
            for (int i = 0; i < 8; i++)
            {
                PokemonModel pokemon = pokeList[i * 2];
                PokemonModel pokemon2 = pokeList[i * 2 + 1];
                PokemonModel winner = GetWinnerDuel(pokemon, pokemon2);
                result.Add(winner);
            }
            return result;
        }

        public PokemonModel GetWinnerDuel(PokemonModel pokemon, PokemonModel pokemon2)
        {
            for (var i = 0; i < 2; i++)
            {

                if (pokemon.PokeType == "Normal" && pokemon2.PokeType == "Fighting" || pokemon2.PokeType == "Electric" || pokemon2.PokeType == "Ground")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Fire" && pokemon2.PokeType == "Water" || pokemon2.PokeType == "Ground" || pokemon2.PokeType == "Dragon")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Water" && pokemon2.PokeType == "Grass" || pokemon2.PokeType == "Electric" || pokemon2.PokeType == "Normal")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Grass" && pokemon2.PokeType == "Fire" || pokemon2.PokeType == "Ice" || pokemon2.PokeType == "Flying")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Electric" && pokemon2.PokeType == "Ground" || pokemon2.PokeType == "Rock" || pokemon2.PokeType == "Dragon")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Ice" && pokemon2.PokeType == "Fire" || pokemon2.PokeType == "Fighting" || pokemon2.PokeType == "Dark")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Fighting" && pokemon2.PokeType == "Flying" || pokemon2.PokeType == "Psychic" || pokemon2.PokeType == "Fairy")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Ground" && pokemon2.PokeType == "Ice" || pokemon2.PokeType == "Water" || pokemon2.PokeType == "Grass")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Flying" && pokemon2.PokeType == "Electric" || pokemon2.PokeType == "Psychic" || pokemon2.PokeType == "Rock")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Psychic" && pokemon2.PokeType == "Bug" || pokemon2.PokeType == "Ghost" || pokemon2.PokeType == "Dark")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Bug" && pokemon2.PokeType == "Fire" || pokemon2.PokeType == "Flying" || pokemon2.PokeType == "Rock")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Rock" && pokemon2.PokeType == "Water" || pokemon2.PokeType == "Grass" || pokemon2.PokeType == "Fighting")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Ghost" && pokemon2.PokeType == "Normal" || pokemon2.PokeType == "Dark" || pokemon2.PokeType == "Bug")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Dragon" && pokemon2.PokeType == "Fairy" || pokemon2.PokeType == "Ice" || pokemon2.PokeType == "Ghost")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Dark" && pokemon2.PokeType == "Dragon" || pokemon2.PokeType == "Bug" || pokemon2.PokeType == "Fairy")
                {
                    return pokemon2;
                }
                if (pokemon.PokeType == "Fairy" && pokemon2.PokeType == "Normal" || pokemon2.PokeType == "Psychic" || pokemon2.PokeType == "Ghost")
                {
                    return pokemon2;
                }

                var pokemon3 = pokemon;
                pokemon = pokemon2;
                pokemon2 = pokemon3;
            }


            if (PokeAvg(pokemon) < PokeAvg(pokemon2))
            {
                return pokemon2;
            }
            //Draw
            if (pokemon.PokeSpd < pokemon2.PokeSpd)
            {
                return pokemon2;
            }
            return pokemon;
        }

        public List<PokemonModel> OrderByRandom(List<PokemonModel> pokemonsRng)
        {
            var rng = new Random();
            pokemonsRng = pokemonsRng.OrderBy(p => rng.Next()).ToList();
            return pokemonsRng;
        }
       
    }
}
