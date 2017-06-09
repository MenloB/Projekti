using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Predaje
    {
        public virtual int Id { get; set; }
        public virtual String Redovni { get; set; }
        public virtual DateTime DatumPostavljanja { get; set; }

        public virtual Nastavnik Osoba { get; set; }
        public virtual Predmet Sifra { get; set; }
    }
}
