using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }

}
