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

            //HasMany(x => x.Profesori).KeyColumn("OSOBA").Cascade.All().LazyLoad();

            HasManyToMany(x => x.Profesori)
                .Table("PREDAJE")
                .ParentKeyColumn("SIFRA")
                .ChildKeyColumn("OSOBA")
                .Cascade.All().Inverse();
        }
    }
}
