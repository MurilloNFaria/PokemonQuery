using Pokemons.Entities;

namespace Pokemons.Services;

internal class FilterService
{
    public static IFilterService _filterService { get; set; }

    public FilterService(IFilterService filterService)
    {
        _filterService = filterService;
    }
}
