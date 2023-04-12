using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotovKurs.Database
{
    public class Author
    {
        public int Id { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }
        public string Country { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Surname[0]}.{Name[0]} {LastName} ({Organization})";
        }
    }
}
