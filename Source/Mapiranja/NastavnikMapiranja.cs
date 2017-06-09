using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            HasMany(x => x.NaPredmetu).KeyColumn("OSOBA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
