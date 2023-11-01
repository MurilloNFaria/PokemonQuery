using Pokemons.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Entities
{
    internal class ScreenPrint
    {
        public int Select()
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
                int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 6) 
            {
                throw new SelectException("The number entered must be among the options above");
            }
            return n;
        }
    }
}
