using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBalta.ContentContext
{
    public class Module
    {
        public int Order { get; set; }
        public string Tittle { get; set; }
        public IList<Lecture> Lectures { get; set; }

        public Module()
        {
            Lectures = new List<Lecture>();
        }
    }
}
