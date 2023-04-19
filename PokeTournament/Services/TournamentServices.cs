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

        public PokemonModel GetFinalWinner(List<PokemonModel> pokemon)
        {
            List<PokemonModel> winnersFromFight = pokemon;

            for(int i =0; i < (pokemon.Count/2/2); i++)
            {
                winnersFromFight = Fight(winnersFromFight);
            }

            var theWinner = winnersFromFight.FirstOrDefault();

            return theWinner;
        }

        public List<PokemonModel> Fight(List<PokemonModel> pokemon)
        {
            var winners = new List<PokemonModel>();
            int index = 0;

            while(index < pokemon.Count)
            {
                var winner = GetWinnerDuel(pokemon[index], pokemon[index+1]);
                winners.Add(winner);
                index+= 2;
            }
            return winners;
        }

        public PokemonModel GetWinnerDuel(PokemonModel pokemon, PokemonModel pokemon2)
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
            
            else if (PokeAvg(pokemon) > PokeAvg(pokemon2))
            {
                return pokemon;
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
