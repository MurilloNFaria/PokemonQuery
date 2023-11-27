using Pokemons.Exceptions;
using Pokemons.Services;

namespace Pokemons.Entities;

internal class ScreenPrint
{

    public static int Select()
    {
        Console.Clear();
        Console.WriteLine("How do you want to query the table?");
        Console.WriteLine("1 - By type (1 and 2);");
        Console.WriteLine("2 - By name;");
        Console.WriteLine("3 - By number;");
        Console.WriteLine("4 - By generation;");
        Console.WriteLine("5 - Show only legendaries;");
        Console.WriteLine("6 - End program");
        Console.Write("Choose one (1/2/3/4/5/6): ");
        int n = int.Parse(Console.ReadLine()!);
        if (n < 1 || n > 6)
        {
            throw new SelectException("The number entered must be among the options above");
        }
        return n;
    }

    public static void SelectProcessInit(int n)
    {
        string print = "";
        if (n == 1) print = "type";
        if (n == 2) print = "name";
        if (n == 3) print = "number";
        if (n == 4) print = "generation";

        Console.Clear();
        Console.Write($"Write the pokemon {print}: ");
    }

    public static void SelectProcessFinal(int n, DataManipulation data, IFilterService filter)
    {
        Console.Clear();

        Console.WriteLine("Search results:");
        Console.WriteLine();
        filter.Filter();

        Console.Write("Press (ENTER) to go back to the menu");
        Console.ReadKey();
    }
}
