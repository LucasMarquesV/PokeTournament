namespace PokeTournament.Models
{
    public class TournamentModel
    {
        public int Id { get; set; }
        private PokemonModel PokeWinner;
        public TournamentModel(PokemonModel winner)
        {
        PokeWinner = winner;
        }
    }
}
