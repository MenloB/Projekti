using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Knjiga : Literatura
    {
        public virtual String ISBN { get; set; }
        public virtual String Naslov { get; set; }
        public virtual String Izdavac { get; set; }
        public virtual int Godina { get; set; }
    }
}
