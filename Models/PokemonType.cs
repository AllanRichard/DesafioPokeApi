using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPokeApi.Models
{
    internal class PokemonType
    {
        public int Slot { get; set; }
        public Type Type { get; set; }
        public override string ToString()
        {
            return $"{ Type.Name }";
        }
    }
}
