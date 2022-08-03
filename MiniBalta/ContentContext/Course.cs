using MiniBalta.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBalta.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

        public Course(string tittle, string url) : base(tittle, url) // Inicializar a lista Module se não ele vem nulo
        {
            Modules = new List<Module>();
        }
    }

   
}
