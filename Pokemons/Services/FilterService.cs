﻿using Pokemons.Entities;

namespace Pokemons.Services;

internal class FilterService
{
    public IFilterService _filterService { get; set; }

    public FilterService(IFilterService filterService)
    {
        _filterService = filterService;
    }
}
