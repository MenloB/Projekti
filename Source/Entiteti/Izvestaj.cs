using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Izvestaj
    {
        public virtual int Id { get; set; }
        public virtual String Opis { get; set; }
        public virtual DateTime DatumPodnosenja { get; set; }

        public virtual PrakticniProjekat ZaProjekat { get; set; }
        public virtual Grupa PodnelaGrupa { get; set; }
    }
}