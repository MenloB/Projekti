using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class ProjekatMapiranja : ClassMap<Projekat>
    {
        public ProjekatMapiranja()
        {
            Table("PROJEKAT");

            Id(x => x.Id).Column("ID_PROJEKTA").GeneratedBy.TriggerIdentity();

            Map(x => x.Tip, "TIP");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Godina, "GODINA");
            Map(x => x.Zavrsen, "ZAVRSEN");
            Map(x => x.Grupni, "GRUPNI");

            References(x => x.predmet).Column("PREDMET").Cascade.All().LazyLoad();

            HasMany(x => x.Projektu).KeyColumn("PROJEKAT").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Ref).KeyColumn("TEORIJSKI").LazyLoad().Cascade.All().Inverse();
        }
    }
}
