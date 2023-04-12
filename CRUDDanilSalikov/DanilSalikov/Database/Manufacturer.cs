using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanilSalikov.Database
{
    public class Manufacturer
    {
        public int Id;

        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
