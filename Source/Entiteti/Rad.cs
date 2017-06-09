using System;

namespace Source.Entiteti
{
    public class Rad : Literatura
    {
        public virtual String Naziv { get; set; }
        public virtual String Format { get; set; }
        public virtual String Konferencija { get; set; }
        public virtual String Adresa { get; set; }
    }
}
