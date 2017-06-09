using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Referencira
    {
        public virtual int Id { get; set; }

        public virtual TeorijskiProjekat TProjekat { get; set; }
        public virtual Literatura KoriscenaLiteratura { get; set; }
    }
}
