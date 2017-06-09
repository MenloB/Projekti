using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Literatura
    {
        public virtual int Id { get; set; }
        public virtual String Tip { get; set; }

        public virtual Autor Pisao { get; set; }

        public virtual IList<Projekat> Projekti { get; set; }

        public Literatura()
        {
            Projekti = new List<Projekat>();
        }
    }
}
