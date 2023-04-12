using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanilSalikov.Database
{
    public class Door
    {
        public int Id;

        public string Name { get; set; }
        public Category Category { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Material Material { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
