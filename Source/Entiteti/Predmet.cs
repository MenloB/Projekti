using System;
using System.Collections.Generic;

namespace Source.Entiteti
{
    public class Predmet
    {
        public virtual int Sifra { get; set; }
        public virtual String Naziv { get; set; }
        public virtual String Katedra { get; set; }
        public virtual String Semestar { get; set; }

        public virtual Nastavnik Profesor { get; set; }

        public virtual IList<Predaje> Profesori { get; set; }

        //public virtual IList<Nastavnik> Profesori { get; set; }

        public Predmet()
        {
            Profesori = new List<Predaje>();
        }
    }
}
