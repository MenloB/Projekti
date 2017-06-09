using Source.Entiteti;
using FluentNHibernate.Mapping;

namespace Source.Mapiranja
{
    class NastavnikMapiranja : ClassMap<Nastavnik>
    {
        public NastavnikMapiranja()
        {
            Table("NASTAVNIK");

            Id(x => x.Id, "ID_OSOBE").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.SIme, "S_IME");
            Map(x => x.Prezime, "PREZIME");

            HasManyToMany(x => x.Predmeti)
                .Table("PREDAJE")
                .ParentKeyColumn("OSOBA")
                .ChildKeyColumn("SIFRA")
                .Cascade.All();
        }
    }
}
