using MiniBalta.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBalta.ContentContext
{
    public class Lecture
    {
        public int Ordem { get; set; }
        public string Tittle { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
