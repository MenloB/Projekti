using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
