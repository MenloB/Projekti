using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class IzvestajMapiranja : ClassMap<Izvestaj>
    {
        public IzvestajMapiranja()
        {
            Table("IZVESTAJ");

            Id(x => x.Id, "ID_IZVESTAJA").GeneratedBy.TriggerIdentity();

            Map(x => x.Opis, "OPIS");
            Map(x => x.DatumPodnosenja, "DATUM_PODNOSENJA");

            References(x => x.ZaProjekat).Column("PROJEKAT").LazyLoad();
            References(x => x.PodnelaGrupa).Column("GRUPA").LazyLoad();
        }
    }
}