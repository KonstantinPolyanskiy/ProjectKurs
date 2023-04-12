using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmKurs.Database
{
    public class Employeer
    {
        public int Id { get; set; }

        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Surname[0]}. {Name[0]}. {LastName} ({Position})";
        }
    }
}
