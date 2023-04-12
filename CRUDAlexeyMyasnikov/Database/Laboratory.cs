using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmKurs.Database
{
    public class Laboratory
    {
        public int Id { get; set; }

        public Material UseMaterial { get; set; }
        public StaffHeadQuaters StaffHeadQuaters { get; set; }

        public int Perfomance { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
