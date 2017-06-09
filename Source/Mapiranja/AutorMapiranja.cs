using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class AutorMapiranja : ClassMap<Autor>
    {
        public AutorMapiranja()
        {
            Table("AUTOR");

            Id(x => x.Id).Column("ID_OSOBE").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.SIme, "S_IME");
            Map(x => x.Prezime, "PREZIME");
        }
    }
}
