using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KotovKurs.Database
{
    public class DatabaseFactory
    {
        private readonly DbContextOptionsBuilder optionsBuilder;

        public DatabaseFactory(Action<DbContextOptionsBuilder> setup)
        {
            optionsBuilder = new DbContextOptionsBuilder();

            setup(optionsBuilder);
        }

        public DatabaseContext CreateContext() => new DatabaseContext(optionsBuilder.Options);
    }
}
