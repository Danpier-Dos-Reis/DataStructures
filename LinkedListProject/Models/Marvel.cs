using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject.Models
{
    public class Marvel
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Marvel(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
