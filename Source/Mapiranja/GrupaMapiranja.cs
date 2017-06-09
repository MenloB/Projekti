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

            HasManyToMany(x => x.Projekti)
                .Table("RADI_NA")
                .ParentKeyColumn("GRUPA")
                .ChildKeyColumn("PROJEKAT")
                .Cascade.All();
        }
    }
}
