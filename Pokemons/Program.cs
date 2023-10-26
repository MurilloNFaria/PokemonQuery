using System;
using Pokemons.Entities;
using Pokemons.Entities.Enums;

namespace Pokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> list = new List<Pokemon>();

            string sourcePath = @"c:\users\nasci\Documents\pokemons";
            string savingPath = sourcePath + @"out\register.csv";
            string filePath = sourcePath + @"\pokemon.csv";

            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {

                    while (!sr.EndOfStream)
                    {
                        string[] pkmns = sr.ReadLine().Split(',');
                        int number = int.Parse(pkmns[0]);
                        string name = pkmns[1];
                        PokeType type1 = Enum.Parse<PokeType>(pkmns[2]);
                        string verify = pkmns[3];
                        PokeType type2;
                        if (verify == "")
                            type2 = Enum.Parse<PokeType>("None");
                        else
                            type2 = Enum.Parse<PokeType>(verify);
                        int total = int.Parse(pkmns[4]);
                        int hp = int.Parse(pkmns[5]);
                        int attack = int.Parse(pkmns[6]);
                        int defense = int.Parse(pkmns[7]);
                        int spatk = int.Parse(pkmns[8]);
                        int spdef = int.Parse(pkmns[9]);
                        int speed = int.Parse(pkmns[10]);
                        int gen = int.Parse(pkmns[11]);
                        bool legendary = bool.Parse(pkmns[12]);

                        list.Add(new Pokemon(number, name, type1, type2, total, hp, attack, defense, spatk, spdef, speed, gen, legendary));
                    }

                    foreach (Pokemon p in list)
                    {
                        if (p.Type1 == PokeType.Poison) {
                            Console.WriteLine(p);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.Write("Error: ");
                Console.Write(e.Message);
            }
            catch (Exception e) 
            {
                Console.Write("Error: ");
                Console.Write(e.Message);
            }
        }
    }
}
