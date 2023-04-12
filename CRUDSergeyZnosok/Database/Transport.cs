using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnosokKurs.Database
{
    public class Transport
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Route Route { get; set; }
        public TypeOfTransport Type { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
