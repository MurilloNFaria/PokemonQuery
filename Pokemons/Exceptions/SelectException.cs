using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Exceptions
{
    internal class SelectException : ApplicationException
    {
        public SelectException(string message) : base(message) { }
    }
}
