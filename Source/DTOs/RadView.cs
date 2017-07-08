using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class RadView
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Format { get; set; }
        public string Konferencija { get; set; }
        public string Adresa { get; set; }

        public RadView()
        {

        }

        public RadView(Rad r)
        {
            this.Id = r.Id;
            this.Naziv = r.Naziv;
            this.Format = r.Format;
            this.Konferencija = r.Konferencija;
            this.Adresa = r.Adresa;
        }
    }
}
