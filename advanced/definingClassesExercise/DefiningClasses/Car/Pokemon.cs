using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public string Element  { get; set; }

        public Pokemon(string name , int health,string element)
        {
            Name = name;
            Health = health;
            Element = element;
        }

    }
}
