using System;
using System.Collections.Generic;

namespace Source.Entiteti
{
    public class Grupa
    {
        public virtual int Id { get; protected set; }
        public virtual String Naziv { get; set; }

        public virtual IList<RadiNa> Radina { get; set; }

        public Grupa()
        {
            Radina = new List<RadiNa>();
        }
    }
}