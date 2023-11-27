using Pokemons.Entities;

namespace Pokemons.Services;

internal class GenerationFilterService : IFilterService
{
    public DataManipulation Data { get; set; }
    public int Gen { get; set; }

    public GenerationFilterService(DataManipulation data, int gen)
    {
        Data = data;
        Gen = gen;
    }

    public void Filter()
    {
        foreach (Pokemon p in Data.pokemonList)
        {
            if (p.Generation == Gen)
                Console.WriteLine(p);
        }
    }
}
