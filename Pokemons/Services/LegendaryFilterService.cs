using Pokemons.Entities;

namespace Pokemons.Services;

internal class LegendaryFilterService : IFilterService
{
    public DataManipulation Data { get; set; }

    public LegendaryFilterService(DataManipulation data)
    {
        Data = data;
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
