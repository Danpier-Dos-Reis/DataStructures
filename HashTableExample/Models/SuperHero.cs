using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample.Models
{
    //public class SuperHero
    //{
    //    public int Id { get; set; } public string? Name { get; set; } public string Powers { get; set; }

    //    public SuperHero(int id, string name, string powers)
    //    {
    //        Id = id;
    //        Name = name;
    //        Powers = powers;
    //    }
    //}

    public class SuperHero
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Powers { get; set; }

        public SuperHero(int id, string name, string powers)
        {
            Id = id;
            Name = name;
            Powers = powers;
        }
        public override bool Equals(object obj)
        {
            if (obj is SuperHero otherHero)
            {
                return Id == otherHero.Id && Name == otherHero.Name && Powers == otherHero.Powers;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode() ^ Powers.GetHashCode();
        }
    }
}
