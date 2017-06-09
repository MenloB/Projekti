using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;
using FluentNHibernate.Mapping;

namespace Source.Mapiranja
{
    class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("PREDMET");

            Id(x => x.Sifra, "SIFRA").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Katedra, "KATEDRA");
            Map(x => x.Semestar, "SEMESTAR");

            References(x => x.Profesor).Column("NASTAVNIK").Cascade.All().LazyLoad();

            HasMany(x => x.Nastavnici).KeyColumn("SIFRA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
