using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class ClanakMapiranja : SubclassMap<Clanak>
    {
        public ClanakMapiranja()
        {
            Table("CLANAK");

            KeyColumn("ID_LITERATURA");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.ISSN, "ISSN");
            Map(x => x.Godina, "GODINA");
            Map(x => x.NazivCasopisa, "NAZIV_CASOPISA");
            Map(x => x.BrojCasopisa, "BROJ_CASOPISA");
        }
    }
}
