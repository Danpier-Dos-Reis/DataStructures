using LinkedListProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    internal static class Engine
    {
        public static List<Pokemon> GetPokemons()
        {
            List<Pokemon> pokemons = new List<Pokemon>() {
                new Pokemon("Pikachu","Eléctrico"), new Pokemon("Pichu","Eléctrico"),
                new Pokemon("Raichu","Eléctrico"), new Pokemon("Charizard","Fuego"),
                new Pokemon("Squirtle","Agua"), new Pokemon("Charmander","Fuego")
            };

            return pokemons;
        }

        public static List<Marvel> GetMarvelHeroes()
        {
            List<Marvel> heros = new List<Marvel>() {
                new Marvel("Spider Man","MetaHumano"), new Marvel("Wolverine","Mutante"),
                new Marvel("Capitana Marvel","Extraterrestre"), new Marvel("Capitan América","Super Humano"),
                new Marvel("Iron Man","Humano"), new Marvel("FireBoy","Mutante")
            };

            return heros;
        }
    }
}