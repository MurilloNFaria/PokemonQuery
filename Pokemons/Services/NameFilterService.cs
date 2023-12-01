using Pokemons.Entities;

namespace Pokemons.Services;

internal class NameFilterService : IFilterService
{
    public DataManipulation Data { get; set; }
    public string Name { get; set; }

    public NameFilterService(DataManipulation data, string name)
    {
        Data = data;
        Name = name;
    }

    public void Filter()
    {
        IEnumerable<Pokemon> list = Data.pokemonList.Where(x => x.Name.Contains(Name)).OrderBy(x => x.Name);

        foreach (Pokemon p in list)
        {
            Console.WriteLine(p);
        }
    }
}
