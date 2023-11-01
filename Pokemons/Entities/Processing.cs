using Pokemons.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Entities
{
    internal class Processing
    {
        public DataManipulation Data { get; set; }

        public Processing(DataManipulation data)
        {
            Data = data;
        }

        public void SelectionProcess(int n)
        {
            if (n == 1)
            {
                Console.Clear();
                Console.Write("Write the pokemon type: ");
                string[] types = Console.ReadLine().Split(',');
                Console.Clear();

                Console.WriteLine("Search results:");
                Console.WriteLine();
                foreach (Pokemon p in Data.pokemonList)
                {
                    TypeProcess(p, types);
                }

                Console.Write("Press (ENTER) to go back to the menu");
                Console.ReadLine();
            }

            if (n == 2)
            {
                Console.Clear();
                Console.Write("Write the pokemon name: ");
                string name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Search results:");
                Console.WriteLine();
                foreach (Pokemon p in Data.pokemonList)
                {
                    if (p.Name == name)
                        Console.WriteLine(p);
                }

                Console.Write("Press (ENTER) to go back to the menu");
                Console.ReadLine();
            }
            if (n == 3)
            {
                Console.Clear();
                Console.Write("Write the pokemon number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Search results:");
                Console.WriteLine();
                foreach (Pokemon p in Data.pokemonList)
                {
                    if (p.Number == number)
                        Console.WriteLine(p);
                }

                Console.Write("Press (ENTER) to go back to the menu");
                Console.ReadLine();
            }
            if (n == 4)
            {
                Console.Clear();
                Console.Write("Write the pokemon number: ");
                int generation = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Search results:");
                Console.WriteLine();
                foreach (Pokemon p in Data.pokemonList)
                {
                    if (p.Generation == generation)
                        Console.WriteLine(p);
                }

                Console.Write("Press (ENTER) to go back to the menu");
                Console.ReadLine();
            }
            if (n == 5)
            {
                Console.Clear();

                Console.WriteLine("Search results:");
                Console.WriteLine();
                foreach (Pokemon p in Data.pokemonList)
                {
                    if (p.Legendary)
                        Console.WriteLine(p);
                }

                Console.Write("Press (ENTER) to go back to the menu");
                Console.ReadLine();
            }
            if (n == 6)
            {
                Data.Execution = false;
                Console.WriteLine();
                Console.WriteLine("Program ended, thanks!");
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
