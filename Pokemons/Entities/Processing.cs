using Pokemons.Entities.Enums;
using Pokemons.Services;

namespace Pokemons.Entities;

internal class Processing
{
    public DataManipulation Data { get; set; }
    public FilterService Filter { get; set; }

    public Processing(DataManipulation data)
    {
        Data = data;
    }

    public void SelectionProcess(int n)
    {
        switch (n)
        {
            case 1:
                ScreenPrint.SelectProcessInit(n);
                string[] types = Console.ReadLine().Split(',');

                Filter = new FilterService(new TypeFilterService(Data, types));

                ScreenPrint.SelectProcessFinal(n, Data, Filter._filterService);
                break;
            case 2:
                ScreenPrint.SelectProcessInit(n);
                string name = Console.ReadLine();

                Filter = new FilterService(new NameFilterService(Data, name));

                ScreenPrint.SelectProcessFinal(n, Data, Filter._filterService);
                break;
            case 3:
                ScreenPrint.SelectProcessInit(n);
                int number = int.Parse(Console.ReadLine());

                Filter = new FilterService(new NumberFilterService(Data, number));

                ScreenPrint.SelectProcessFinal(n, Data, Filter._filterService);
                break;
            case 4:
                ScreenPrint.SelectProcessInit(n);
                int generation = int.Parse(Console.ReadLine());

                Filter = new FilterService(new GenerationFilterService(Data, generation));

                ScreenPrint.SelectProcessFinal(n, Data, Filter._filterService);
                break;
            case 5:

                Console.Clear();
                Filter = new FilterService(new LegendaryFilterService(Data));

                ScreenPrint.SelectProcessFinal(n, Data, Filter._filterService);
                break;
            case 6:
                Data.Execution = false;
                Console.WriteLine();
                Console.WriteLine("Program ended, thanks!");
                Console.WriteLine("By: Murillo Faria");
                break;
            default:
                Console.WriteLine("Non-existent option");
                break;
        }
    }
}
