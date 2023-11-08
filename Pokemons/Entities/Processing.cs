using Pokemons.Entities.Enums;
using Pokemons.Services;

namespace Pokemons.Entities
{
    internal class Processing
    {
        public DataManipulation Data { get; set; }
        public FilterService Filter { get; set; }
        public ScreenPrint Screen { get; set; }

        public Processing(DataManipulation data)
        {
            Data = data;
            Filter = new FilterService();
            Screen = new ScreenPrint();
        }

        public void SelectionProcess(int n)
        {
            if (n == 1)
            {
                Screen.SelectProcessInit(n);
                string[] types = Console.ReadLine().Split(',');

                Filter = new FilterService(new TypeFilterService(Data, types));

                Screen.SelectProcessFinal(n, Data, Filter._filterService);
            }
            else if (n == 2)
            {
                Screen.SelectProcessInit(n);
                string name = Console.ReadLine();

                Filter = new FilterService(new NameFilterService(Data, name));

                Screen.SelectProcessFinal(n, Data, Filter._filterService);
            }
            else if (n == 3)
            {
                Screen.SelectProcessInit(n);
                int number = int.Parse(Console.ReadLine());

                Filter = new FilterService(new NumberFilterService(Data, number));

                Screen.SelectProcessFinal(n, Data, Filter._filterService);
            }
            else if (n == 4)
            {
                Screen.SelectProcessInit(n);
                int generation = int.Parse(Console.ReadLine());

                Filter = new FilterService(new GenerationFilterService(Data, generation));

                Screen.SelectProcessFinal(n, Data, Filter._filterService);
            }
            else if (n == 5)
            {
                Console.Clear();
                Filter = new FilterService(new LegendaryFilterService(Data));

                Screen.SelectProcessFinal(n, Data, Filter._filterService);
            }
            else
            {
                Data.Execution = false;
                Console.WriteLine();
                Console.WriteLine("Program ended, thanks!");
                Console.WriteLine("By: Murillo Faria");
            }
        }
    }
}
