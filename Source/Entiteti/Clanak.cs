using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Clanak : Literatura
    {
        public virtual String Naziv { get; set; }
        public virtual String ISSN { get; set; }
        public virtual int Godina { get; set; }
        public virtual String NazivCasopisa { get; set; }
        public virtual int BrojCasopisa { get; set; }
    }
}
