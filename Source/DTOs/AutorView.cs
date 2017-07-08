using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class AutorView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string SIme { get; set; }
        public string Prezime { get; set; }

        public AutorView()
        {

        }

        public AutorView(Autor a)
        {
            this.Id = a.Id;
            this.Ime = a.Ime;
            this.SIme = a.SIme;
            this.Prezime = a.Prezime;
        }
    }
}
