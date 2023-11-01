using Pokemons.Entities.Enums;
using System;
using System.Text;

namespace Pokemons.Entities
{
    internal class Pokemon
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public PokeType Type1 { get; set; }
        public PokeType Type2 { get; set; }
        public int  Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAtk { get; set; }
        public int SpDef { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public bool Legendary { get; set; }

        public Pokemon(int number, string name, PokeType type1, PokeType type2, int total, int hP, int attack, int defense, int spAtk, int spDef, int speed, int generation, bool legendary)
        {
            Number = number;
            Name = name;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            HP = hP;
            Attack = attack;
            Defense = defense;
            SpAtk = spAtk;
            SpDef = spDef;
            Speed = speed;
            Generation = generation;
            Legendary = legendary;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
<<<<<<< HEAD

=======
>>>>>>> 5577be3af74483be2ba0e3a3bbfe5915eb353f45
            sb.Append("Number #");
            sb.Append(Number);
            sb.AppendLine();
            sb.Append("Name: ");
            sb.AppendLine(Name);
            sb.Append("Types: ");
            sb.Append(Type1);
            sb.Append(", ");
            sb.Append(Type2);
            sb.AppendLine();

            sb.Append("Total: ");
            sb.Append(Total);
            sb.Append(", Attack: ");
            sb.Append(Attack);
            sb.Append(", Defense: ");
            sb.Append(Defense);
            sb.AppendLine();

            sb.Append("Sp. Attack: ");
            sb.Append(SpAtk);
            sb.Append(", Sp. Defense: ");
            sb.Append(SpDef);
            sb.Append(", Speed: ");
            sb.Append(Speed);
            sb.AppendLine();

            sb.Append("Generation: ");
            sb.Append(Generation);
            if (Legendary)
                sb.Append(", Legendary");
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
