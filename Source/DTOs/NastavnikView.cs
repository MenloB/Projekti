using Source.Entiteti;
using System.Collections.Generic;

namespace Source.DTOs
{
    public class NastavnikView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string SIme { get; set; }
        public string Prezime { get; set; }
        public List<PredmetView> Predmeti { get; set; }

        public NastavnikView(Nastavnik n)
        {
            this.Id = n.Id;
            this.Ime = n.Ime;
            this.SIme = n.SIme;
            this.Prezime = n.Prezime;
            this.Predmeti = new List<PredmetView>();
        }

        public NastavnikView()
        {

        }
    }
}