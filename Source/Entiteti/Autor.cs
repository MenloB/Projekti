﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Entiteti
{
    public class Autor
    {
        public virtual int Id { get; protected set; }
        public virtual String Ime { get; set; }
        public virtual String SIme { get; set; }
        public virtual String Prezime { get; set; }
    }
}
