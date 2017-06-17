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

            References(x => x.predmet).Column("PREDMET").LazyLoad();

            HasManyToMany(x => x.Grupe)
                .Table("RADI_NA")
                .ParentKeyColumn("PROJEKAT")
                .ChildKeyColumn("GRUPA")
                .Cascade.All()
                .Inverse();
        }
    }
}
