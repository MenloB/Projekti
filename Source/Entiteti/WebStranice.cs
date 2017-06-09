using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class WebStranice
    {
        public virtual int Id { get; set; }
        public virtual String Link { get; set; }

        public virtual Projekat PripadaProjektu { get; set; }
    }
}
