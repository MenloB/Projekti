using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class RadMapiranja : SubclassMap<Rad>
    {
        public RadMapiranja()
        {
            Table("RAD");

            KeyColumn("ID_LITERATURA");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Format, "FORMAT");
            Map(x => x.Konferencija, "KONFERENCIJA");
            Map(x => x.Adresa, "ADRESA");

        }
    }
}
