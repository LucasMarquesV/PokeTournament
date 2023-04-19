using PokeTournament.Models;

namespace PokeTournament.Repository
{
    public interface IPokemonRepository
    {
        //List<PokemonTestModel> GetAllTeste();
        List<PokemonModel> GetAll();
        List<PokemonModel> GetPokeById(IFormCollection ids);
        PokemonModel GetPokeById(int id);
    }
}
