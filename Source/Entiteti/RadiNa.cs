using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class RadiNa
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual int Rok { get; set; }
        public virtual String Jezik { get; set; }

        public virtual Grupa GrupaRadi { get; set; }
        public virtual Projekat NaProjektu { get; set; }
    }
}
