﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmKurs.Database
{
    public class TypeProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}