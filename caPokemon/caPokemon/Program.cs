using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon[] pokemons = new Pokemon[10];

            for(int i = 0, j = 9; i < 5 && j >= 5; i++, j--)
            {
                pokemons[i] = new Pikachu();
                pokemons[j] = new Bubassauro();
            }

            foreach(Pokemon pokemon in pokemons)
            {
                pokemon.emiteSom();
            }

            Console.ReadLine();
        }
    }
}
