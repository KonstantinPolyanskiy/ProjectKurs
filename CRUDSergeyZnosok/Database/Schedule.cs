using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnosokKurs.Database
{
    public class Schedule
    {
        public int Id { get; set; }

        public Transport Transport { get; set; }

        public TimeSpan TimeFromStart { get; set; }
        public TimeSpan TimeFromEnd { get; set; }
    }
}
