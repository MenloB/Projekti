using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class ClanakView
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string ISSN { get; set; }
        public int Godine { get; set; }
        public string NazivCasopisa { get; set; }
        public int BrojCasopisa { get; set; }

        public ClanakView()
        {

        }

        public ClanakView(Clanak c)
        {
            this.Id = c.Id;
            this.Naziv = c.Naziv;
            this.ISSN = c.ISSN;
            this.Godine = c.Godina;
            this.NazivCasopisa = c.NazivCasopisa;
            this.BrojCasopisa = c.BrojCasopisa;
        }
    }
}
