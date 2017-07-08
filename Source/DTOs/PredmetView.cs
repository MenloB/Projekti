using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class PredmetView
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Katedra { get; set; }
        public string Semestar { get; set; }
        public List<NastavnikView> Nastavnici { get; set; }

        public PredmetView(Predmet p)
        {
            this.Id = p.Sifra;
            this.Naziv = p.Naziv;
            this.Katedra = p.Katedra;
            this.Semestar = p.Semestar;
            this.Nastavnici = new List<NastavnikView>();
        }

        public PredmetView()
        {

        }
    }
}
