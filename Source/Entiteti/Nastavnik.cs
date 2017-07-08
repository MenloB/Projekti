using System;
using System.Collections.Generic;

namespace Source.Entiteti
{
    public class Nastavnik
    {
        public virtual int Id { get; set; }
        public virtual String Ime { get; set; }
        public virtual String SIme { get; set; }
        public virtual String Prezime { get; set; }

        public virtual IList<Predaje> Predmeti { get; set; }

        //public virtual IList<Predmet> Predmeti { get; set; }

        public Nastavnik()
        {
            Predmeti = new List<Predaje>();
        }
    }
}