using System.Collections.Generic;
using System.IO;
using Pokemons.Entities.Enums;

namespace Pokemons.Entities;

internal class DataManipulation
{
    public DataManipulation()
    {
        SourcePath = @"c:\users\nasci\Documents\pokemons";
        SavingPath = SourcePath + @"out\register.csv";
        FilePath = SourcePath + @"\pokemon.csv";
        Execution = true;
        Processes = new(this);
    }

    private string SourcePath { get; }
    private string SavingPath { get; }
    private string FilePath { get; }
    public bool Execution { get; private set; }
    public Processing Processes { get; }

    private List<Pokemon> PokemonList = new();

    public IEnumerable<Pokemon> pokemonList { get; private set; }

    public void EndExecution()
    {
        Execution = false;
    }

    public bool VerifyLenght()
    {
        return PokemonList.Count == 0;
    }

    public void ReadArchive()
    {
        try
        {
            using StreamReader sr = File.OpenText(FilePath);

            while (!sr.EndOfStream)
            {
                string[] pkmns = sr.ReadLine()!.Split(',');
                int number = int.Parse(pkmns[0]);
                string name = pkmns[1];
                PokeType type1 = Enum.Parse<PokeType>(pkmns[2]);

                string verify = pkmns[3];
                PokeType type2;
                type2 = (verify == "") ? Enum.Parse<PokeType>("None") : Enum.Parse<PokeType>(verify);

                int total = int.Parse(pkmns[4]);
                int hp = int.Parse(pkmns[5]);
                int attack = int.Parse(pkmns[6]);
                int defense = int.Parse(pkmns[7]);
                int spatk = int.Parse(pkmns[8]);
                int spdef = int.Parse(pkmns[9]);
                int speed = int.Parse(pkmns[10]);
                int gen = int.Parse(pkmns[11]);
                bool legendary = bool.Parse(pkmns[12]);

                PokemonList.Add(new Pokemon(number, name, type1, type2, total, hp, attack, defense, spatk, spdef, speed, gen, legendary));
            }
            pokemonList = PokemonList;
        }
        catch (Exception e)
        {
            Console.Write("Error: ");
            Console.Write(e.Message);
        }
    }
}
