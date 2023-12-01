using Pokemons.Entities;
using Pokemons.Entities.Enums;
using Pokemons.Exceptions;
using Pokemons.Services;

namespace Pokemons;

class Program
{
    static void Main(string[] args)
    {
        DataManipulation dataManipulation = new();

        while (dataManipulation.Execution)
        {
            try
            {
                if (dataManipulation.VerifyLenght()) 
                    dataManipulation.ReadArchive();
                dataManipulation.Processes.SelectionProcess(ScreenPrint.Select());
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press (ENTER) to continue");
                Console.ReadKey();
            }
        }
    }
}
