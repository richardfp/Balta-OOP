using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBalta.ContentContext
{
    public abstract class Content // Classe pai 
        {
        // Global Unique Idenfiter = GUID
        public Guid Id { get; set; }
        public string Tittle { get; set; }
        public string Url { get; set; }

        
        public Content(string tittle, string url) // Construtor da classe criando um GUID para as filhas
        {
            Id = Guid.NewGuid();
            Tittle = tittle;
            Url = url;
        }
    }
}
