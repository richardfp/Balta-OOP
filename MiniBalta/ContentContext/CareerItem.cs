﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBalta.ContentContext
{
    public class CareerItem
    {
            public int Ordem { get; set; }
            public string Tittle { get; set; }
            public string Description { get; set; }
            public Course Course { get; set; }
    }

}
