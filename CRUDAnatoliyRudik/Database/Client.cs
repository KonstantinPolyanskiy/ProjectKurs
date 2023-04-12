using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatoliyRudik.Database
{
    public class Client
    {
        public int Id { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Surname} {Name} {LastName}";
        }
    }
}
