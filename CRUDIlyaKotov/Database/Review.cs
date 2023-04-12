using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotovKurs.Database
{
    public class Review
    {
        public int Id { get; set; }

        public Author? Author { get; set; }
        public Article? Article { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
    }
}
