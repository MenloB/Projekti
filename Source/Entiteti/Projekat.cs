using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Projekat
    {
        public virtual int Id { get; protected set; }
        public virtual String Tip { get; set; }
        public virtual String Naziv { get; set; }
        public virtual int Godina { get; set; }
        public virtual String Zavrsen { get; set; }
        public virtual String Grupni { get; set; }

        public virtual Predmet predmet { get; set; }

        public virtual IList<Referencira> Ref { get; set; }

        public virtual IList<RadiNa> Projektu { get; set; }

        public Projekat()
        {
            Ref = new List<Referencira>();
            Projektu = new List<RadiNa>();
        }
    }
}
