using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int numberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
                Name = name;
                numberOfBadges = 0;
                Pokemons = new List<Pokemon>();
        }
    }
}
