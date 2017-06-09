using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class KnjigaMapiranja : SubclassMap<Knjiga>
    {
        public KnjigaMapiranja()
        {
            Table("KNJIGA");

            KeyColumn("ID_LITERATURA");

            Map(x => x.ISBN, "ISBN");
            Map(x => x.Naslov, "NASLOV");
            Map(x => x.Izdavac, "IZDAVAC");
            Map(x => x.Godina, "GODINA");

        }
    }
}
