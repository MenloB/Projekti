using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Source;
using Source.Entiteti;
using Source.DTOs;

namespace WebAPI.Controllers
{
    public class KnjigeController : ApiController
    {
        public IList<KnjigaView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetKnjige();
        }

        public KnjigaView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetKnjigaView(id);
        }

        public int Post([FromBody]Knjiga k)
        {
            DataProvider provider = new DataProvider();
            return provider.AddKnjiga(k);
        }

        public int Put(int id, [FromBody]Knjiga k)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateKnjiga(id, k);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveKnjiga(id);
        }
    }
}
