using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class TeorijskiProjekatMapiranja : SubclassMap<TeorijskiProjekat>
    {
        public TeorijskiProjekatMapiranja()
        {
            Table("TEORIJSKI");

            KeyColumn("ID_PROJEKTA");

            Map(x => x.BrojStrana, "BROJ_STRANA");

            HasManyToMany(x => x.Literatura)
                .Table("REFERENCIRA")
                .ParentKeyColumn("TEORIJSKI")
                .ChildKeyColumn("LITERATURA")
                .Cascade.All().Inverse();
        }
    }
}
