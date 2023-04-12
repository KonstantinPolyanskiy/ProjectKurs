using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmKurs.Database
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public Laboratory FromLaboratory { get; set; }

        public TypeProduct Type { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
