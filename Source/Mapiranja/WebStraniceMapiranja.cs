using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Source.Entiteti;

namespace Source.Mapiranja
{
    class WebStraniceMapiranja : ClassMap<WebStranice>
    {
        public WebStraniceMapiranja()
        {
            Table("WEB_STRANICE");

            Id(x => x.Id, "ID_WEBSTRANICE").GeneratedBy.TriggerIdentity();

            Map(x => x.Link, "WEB_STRANICA");

            References(x => x.PripadaProjektu).Column("PROJEKAT").Cascade.All().LazyLoad();
        }
    }
}
