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
        foreach (Pokemon p in Data.pokemonList)
        {
            if (p.Legendary)
                Console.WriteLine(p);
        }
    }
}
