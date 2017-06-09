using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Literatura
    {
        public virtual int Id { get; set; }
        public virtual String Tip { get; set; }

        public virtual Autor Pisao { get; set; }

        public virtual IList<Referencira> Koristi { get; set; }

        public Literatura()
        {
            Koristi = new List<Referencira>();
        }
    }
}
