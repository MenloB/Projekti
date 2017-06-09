using System.Collections.Generic;

namespace Source.Entiteti
{
    public class TeorijskiProjekat : Projekat
    {
        public virtual int BrojStrana { get; set; }

        public virtual IList<Literatura> Literatura { get; set; }

        public TeorijskiProjekat()
        {
            Literatura = new List<Literatura>();
        }
    }
}
