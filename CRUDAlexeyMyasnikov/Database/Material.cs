using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmKurs.Database
{
    public class Material
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Volume { get; set; }
        public decimal Price { get; set; }
        public int ChemicalHazardIndex { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
