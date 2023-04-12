using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatoliyRudik.Database
{
    public class Package
    {
        public int Id { get; set; }

        public string TrackNumber { get; set; }

        public double Size { get; set; }

        public double Weight { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
