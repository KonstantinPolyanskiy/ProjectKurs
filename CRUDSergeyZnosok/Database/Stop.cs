using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnosokKurs.Database
{
    public class Stop
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Street { get; set; }

        public List<Route> Routes { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
