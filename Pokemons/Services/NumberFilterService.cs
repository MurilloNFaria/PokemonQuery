using Pokemons.Entities;

namespace Pokemons.Services;

internal class NumberFilterService : IFilterService
{
    public DataManipulation Data { get; set; }
    public int Number { get; set; }

    public NumberFilterService(DataManipulation data, int number)
    {
        Data = data;
        Number = number;
    }

    public void Filter()
    {
        foreach (Pokemon p in Data.pokemonList)
        {
            if (p.Number == Number)
                Console.WriteLine(p);
        }
    }
}
