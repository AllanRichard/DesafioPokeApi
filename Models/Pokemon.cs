using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPokeApi.Models
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public string[] Types { get; set; }
        public string[] Abilities { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string[] Sprites { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Types: {Types}, Abilities: {Abilities}, Weight: {Weight}, Height: {Height}, Sprites: {Sprites}";
        }
    }

    internal class PokemonList
    {
        public Pokemon[]? Pokemons { get; set; }
    }
}
