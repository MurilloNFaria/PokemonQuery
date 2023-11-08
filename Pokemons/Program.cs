using System;
using Pokemons.Entities;
using Pokemons.Entities.Enums;
using Pokemons.Exceptions;
using Pokemons.Services;

namespace Pokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManipulation dataManipulation = new DataManipulation();

            while (dataManipulation.Execution)
            {
                try
                {
                    if (dataManipulation.pokemonList.Count <= 0)
                        dataManipulation.ReadArchive();
                    dataManipulation.Processes.SelectionProcess(dataManipulation.Screen.Select());
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press (ENTER) to continue");
                    Console.ReadLine();
                }
            }
        }
    }
}
