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
        IEnumerable<Pokemon> list = Data.pokemonList.Where(x => x.Legendary).OrderBy(x => x.Name);

        foreach (Pokemon p in list)
        {
            Console.WriteLine(p);
        }
    }
}
