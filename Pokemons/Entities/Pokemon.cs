using Pokemons.Entities.Enums;
using System;
using System.Text;

namespace Pokemons.Entities;

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

        sb.AppendLine($"Number #{Number}");
        sb.AppendLine($"Name: {Name}");
        sb.AppendLine($"Types: {Type1}, {Type2}");

        sb.AppendLine($"Total: {Total}, Attack: {Attack}, Defense: {Defense}");

        sb.AppendLine($"Sp. Attack: {SpAtk}, Sp. Defense: {SpDef}, Speed: {Speed}");

        sb.Append($"Generation: {Generation}");
        if (Legendary) sb.AppendLine(", Legendary\n");

        return sb.ToString();
    }
}
