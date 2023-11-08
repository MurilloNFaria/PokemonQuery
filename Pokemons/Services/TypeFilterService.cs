using Pokemons.Entities;
using Pokemons.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Services
{
    internal class TypeFilterService : IFilterService
    {
        public DataManipulation Data { get; set; }
        public string[] Types { get; set; }

        public TypeFilterService(DataManipulation data, string[] types)
        {
            Data = data;
            Types = types;
        }

        public void Filter()
        {
            foreach (Pokemon p in Data.pokemonList)
            {
                TypeProcess(p, Types);
            }
        }

        private void TypeProcess(Pokemon p, string[] types)
        {
            if (types.Length > 1)
            {
                if (p.Type1 == Enum.Parse<PokeType>(types[0]) && p.Type2 == Enum.Parse<PokeType>(types[1]))
                    Console.WriteLine(p);
                if (p.Type1 == Enum.Parse<PokeType>(types[1]) && p.Type2 == Enum.Parse<PokeType>(types[0]))
                    Console.WriteLine(p);
            }
            else
            {
                if (p.Type1 == Enum.Parse<PokeType>(types[0]) || p.Type2 == Enum.Parse<PokeType>(types[0]))
                    Console.WriteLine(p);
            }
        }
    }
}
