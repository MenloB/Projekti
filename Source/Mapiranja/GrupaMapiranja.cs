using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;
using FluentNHibernate.Mapping;

namespace Source.Mapiranja
{
    class GrupaMapiranja : ClassMap<Grupa>
    {
        public GrupaMapiranja()
        {
            Table("GRUPA");

            Id(x => x.Id, "ID_GRUPE").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");

            HasMany(x => x.Radina).KeyColumn("GRUPA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
