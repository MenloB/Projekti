using System;
using System.Collections.Generic;

namespace Source.Entiteti
{
    public class Grupa
    {
        public virtual int Id { get; protected set; }
        public virtual String Naziv { get; set; }

        public virtual IList<Projekat> Projekti { get; set; }

        public Grupa()
        {
            Projekti = new List<Projekat>();   
        }
    }
}