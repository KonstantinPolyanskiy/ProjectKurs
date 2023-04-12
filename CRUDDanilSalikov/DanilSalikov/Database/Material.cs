using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanilSalikov.Database
{
    public class Material
    {
        public int Id;
        public string Name { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
