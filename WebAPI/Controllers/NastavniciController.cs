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
    public class NastavniciController : ApiController
    {
        public IList<NastavnikView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetNastavnici();
        }

        public NastavnikView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetNastavnikView(id);
        }

        public int Post([FromBody]Nastavnik n)
        {
            DataProvider provider = new DataProvider();
            return provider.AddNastavnik(n);
        }

        public int Put(int id, [FromBody]Nastavnik n)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateNastavnik(id, n);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveNastavnik(id);
        }
    }
}
