using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class ReferenciraMapiranja : ClassMap<Referencira>
    {
        public ReferenciraMapiranja()
        {
            Table("REFERENCIRA");

            Id(x => x.Id).Column("ID_REFERENCIRA").GeneratedBy.TriggerIdentity();

            References(x => x.TProjekat).Column("TEORIJSKI").Cascade.All().LazyLoad();
            References(x => x.KoriscenaLiteratura).Column("LITERATURA").Cascade.All().LazyLoad();
        }
    }
}
