using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class StudentMapiranja : ClassMap<Student>
    {
        public StudentMapiranja()
        {
            Table("STUDENT");

            Id(x => x.Id).Column("ID_OSOBE").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.SIme, "S_IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.BrIndeksa, "BROJ_INDEKSA");
            Map(x => x.Smer, "SMER");

            References(x => x.SlusaPredmet).Column("PREDMET").Cascade.All().LazyLoad();
            References(x => x.PripadaGrupi).Column("GRUPA").Cascade.All().LazyLoad();
        }
    }
}
