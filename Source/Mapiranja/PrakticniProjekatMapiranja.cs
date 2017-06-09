using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class PrakticniProjekatMapiranja : SubclassMap<PrakticniProjekat>
    {
        public PrakticniProjekatMapiranja()
        {
            Table("PRAKTICNI");

            KeyColumn("ID_PROJEKTA");

            Map(x => x.KratakOpis, "KRATAK_OPIS");
            Map(x => x.Jezik, "JEZIK");
        }
    }
}
