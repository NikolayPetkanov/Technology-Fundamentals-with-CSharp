namespace P09_PokemonDon_tGo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var pokemons = Console.ReadLine().Split().Select(long.Parse).ToList();
            var collectedPokemons = new List<long>();

            while (pokemons.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                long removedPokemon = 0;

                if (index < 0)
                {
                    removedPokemon = pokemons[0];
                    collectedPokemons.Add(pokemons[0]);
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                }

                else if (index >= pokemons.Count)
                {
                    removedPokemon = pokemons[pokemons.Count - 1];
                    collectedPokemons.Add(pokemons[pokemons.Count - 1]);
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);
                }

                else
                {
                    removedPokemon = pokemons[index];
                    collectedPokemons.Add(pokemons[index]);
                    pokemons.RemoveAt(index);
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= removedPokemon)
                    {
                        pokemons[i] += removedPokemon;
                    }

                    else if (pokemons[i] > removedPokemon)
                    {
                        pokemons[i] -= removedPokemon;
                    }
                }
            }

            Console.WriteLine(collectedPokemons.Sum());
        }
    }
}
