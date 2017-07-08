using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class ProjekatView
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public int Godina { get; set; }
        public string Zavrsen { get; set; }
        public string Grupni { get; set; }
        public PredmetView Predmet { get; set; }
        public IList<GrupaView> Grupe { get; set; }

        public ProjekatView()
        {

        }

        public ProjekatView(Projekat p)
        {
            this.Id = p.Id;
            this.Naziv = p.Naziv;
            this.Tip = p.Tip;
            this.Godina = p.Godina;
            this.Zavrsen = p.Zavrsen;
            this.Grupni = p.Grupni;
            this.Predmet = new PredmetView(p.predmet);
            this.Grupe = new List<GrupaView>();
        }
    }
}
