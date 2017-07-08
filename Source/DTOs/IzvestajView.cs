using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class IzvestajView
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPodnosenja { get; set; }
        //public ProjekatView ZaProjekat { get; set; }
        //public GrupaView PodnelaGrupa { get; set; }

        public IzvestajView()
        {

        }

        public IzvestajView(Izvestaj i)
        {
            this.Id = i.Id;
            this.Opis = i.Opis;
            this.DatumPodnosenja = i.DatumPodnosenja;
            //this.ZaProjekat = new ProjekatView(i.ZaProjekat);
            //this.PodnelaGrupa = new GrupaView(i.PodnelaGrupa);
        }
    }
}
