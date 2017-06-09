using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Predmet
    {
        public virtual int Sifra { get; set; }
        public virtual String Naziv { get; set; }
        public virtual String Katedra { get; set; }
        public virtual String Semestar { get; set; }

        public virtual Nastavnik Profesor { get; set; }

        public virtual IList<Predaje> Nastavnici { get; set; }

        public Predmet()
        {
            Nastavnici = new List<Predaje>();
        }
    }
}
