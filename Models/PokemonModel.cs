using System.Runtime.CompilerServices;

namespace PokeTournament.Models
{
    public class PokemonModel
    {
        public int Id { get; set; }
        public string PokeName { get; set; }
        public string PokeType { get; set; }
        public int PokeAtk { get; set; }
        public int PokeHp { get; set; }
        public int PokeDef { get; set; }
        public int PokeSpd { get; set; }

      
    }
}
