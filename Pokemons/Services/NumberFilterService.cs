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
        IEnumerable<Pokemon> list = Data.pokemonList.Where(x => x.Number == Number).OrderBy(x => x.Name);

        foreach (Pokemon p in list)
        {
                Console.WriteLine(p);
        }
    }
}
