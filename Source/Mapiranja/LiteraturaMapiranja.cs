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

            HasManyToMany(x => x.Projekti)
                .Table("REFERENCIRA")
                .ParentKeyColumn("LITERATURA")
                .ChildKeyColumn("PROJEKAT")
                .Cascade.All();
        }
    }
}
