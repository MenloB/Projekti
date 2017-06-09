using System;
using System.Collections.Generic;

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

        public virtual IList<Grupa> Grupe { get; set; }

        public Projekat()
        {
            Grupe = new List<Grupa>();
        }
    }
}
