using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ZnosokKurs.Database
{
    public class Route
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Long { get; set; }

        public List<Stop> Stops { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
