using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class PrakticniProjekat : Projekat
    {
        public virtual String KratakOpis { get; set; }
        public virtual String Jezik { get; set; }
    }
}
