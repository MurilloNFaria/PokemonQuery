using System;
using System.Linq.Expressions;
using Pokemons.Entities;
using Pokemons.Entities.Enums;
using Pokemons.Exceptions;

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