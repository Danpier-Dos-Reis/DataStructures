using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample.Models
{
    public class SuperHero
    {
        public int Id { get; set; } public string? Name { get; set; } public string Powers { get; set; }

        public SuperHero(int id, string name, string powers)
        {
            Id = id;
            Name = name;
            Powers = powers;
        }
    }
}
