using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPokeApi.Models
{
    internal class PokemonAbility
    {
        public bool Is_Hidden { get; set; }
        public int Slot { get; set; }
        public Ability Ability { get; set; }
        public override string ToString()
        {
            return $"{ Ability.Name }";
        }

    }
}
