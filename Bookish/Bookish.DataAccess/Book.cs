﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{ISBN}\t{Title}\t{Name}";
        }
    }
}
