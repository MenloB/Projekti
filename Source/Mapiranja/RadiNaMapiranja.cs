using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class RadiNaMapiranja : ClassMap<RadiNa>
    {
        public RadiNaMapiranja()
        {
            Table("RADI_NA");

            Id(x => x.Id).Column("ID_RADINA").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");
            Map(x => x.Rok, "ROK");
            Map(x => x.Jezik, "JEZIK");

            References(x => x.GrupaRadi).Column("GRUPA").Cascade.All().LazyLoad();
            References(x => x.NaProjektu).Column("PROJEKAT").Cascade.All().LazyLoad();
        }
    }
}
