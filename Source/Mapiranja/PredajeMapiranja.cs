using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class PredajeMapiranja : ClassMap<Predaje>
    {
        public PredajeMapiranja()
        {
            Table("PREDAJE");

            Id(x => x.Id).Column("ID_PREDAJE").GeneratedBy.TriggerIdentity();

            Map(x => x.Redovni, "REDOVNI_FLAG");
            Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA");

            References(x => x.Osoba).Column("OSOBA").Cascade.All().LazyLoad();
            References(x => x.Sifra).Column("SIFRA").Cascade.All().LazyLoad();
        }
    }
}
