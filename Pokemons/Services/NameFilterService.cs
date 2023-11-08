using Pokemons.Entities;

namespace Pokemons.Services
{
    internal class NameFilterService : IFilterService
    {
        public DataManipulation Data { get; set; }
        public string Name { get; set; }

        public NameFilterService(DataManipulation data, string name) {
            Data = data;
            Name = name;
        }

        public void Filter()
        {
            foreach (Pokemon p in Data.pokemonList)
            {
                if (p.Name == Name)
                    Console.WriteLine(p);
            }
        }
    }
}
