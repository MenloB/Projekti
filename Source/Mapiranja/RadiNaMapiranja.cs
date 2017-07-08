using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;
using FluentNHibernate.Mapping;

namespace Source.Mapiranja
{
    public class RadiNaMapiranja : ClassMap<RadiNa>
    {
        public RadiNaMapiranja()
        {
            Table("RADI_NA");

            Id(x => x.RadiNaId).Column("ID_RADINA").GeneratedBy.TriggerIdentity();

            References(x => x.GrupaRadi).Column("GRUPA").Cascade.All().LazyLoad();
            References(x => x.NaProjektu).Column("PROJEKAT").Cascade.All().LazyLoad();

            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.DatumDo).Column("DATUM_DO");
            Map(x => x.Rok).Column("ROK");
            Map(x => x.Jezik).Column("JEZIK");
        }
    }
}
