using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;
using FluentNHibernate.Mapping;

namespace Source.Mapiranja
{
    class PredajeMapiranja : ClassMap<Predaje>
    {
        public PredajeMapiranja()
        {
            Table("PREDAJE");

            Id(x => x.Id).Column("ID_PREDAJE").GeneratedBy.TriggerIdentity();

            References(x => x.Profesor).Column("OSOBA").LazyLoad();
            References(x => x.PredmetSifra).Column("SIFRA").LazyLoad();

            Map(x => x.Redovni).Column("REDOVNI_FLAG");
            Map(x => x.DatumPostavljanja).Column("DATUM_POSTAVLJANJA");
        }
    }
}
