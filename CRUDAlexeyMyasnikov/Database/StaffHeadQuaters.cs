using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmKurs.Database
{
    public class StaffHeadQuaters
    {
        public int Id { get; set; }

        public List<Employeer> Employeers { get; set; }
        public Employeer ManagerEmployeer { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
