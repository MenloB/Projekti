using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class LiteraturaMapiranja : ClassMap<Literatura>
    {
        public LiteraturaMapiranja()
        {
            Table("LITERATURA");

            Id(x => x.Id).Column("ID_LITERATURA").GeneratedBy.TriggerIdentity();

            Map(x => x.Tip, "TIP");

            References(x => x.Pisao).Column("AUTOR").Cascade.All().LazyLoad();

            HasMany(x => x.Koristi).KeyColumn("LITERATURA").Cascade.All().LazyLoad();
        }
    }
}
