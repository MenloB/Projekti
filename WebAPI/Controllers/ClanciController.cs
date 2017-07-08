using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Source;
using Source.DTOs;
using Source.Entiteti;

namespace WebAPI.Controllers
{
    public class ClanciController : ApiController
    {
        public IList<ClanakView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetClanke();
        }

        public ClanakView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetClanakView(id);
        }

        public int Post([FromBody] Clanak c)
        {
            DataProvider provider = new DataProvider();
            return provider.AddClanak(c);
        }

        public int Put(int id, [FromBody]Clanak c)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateClanak(id, c);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveClanak(id);
        }
    }
}
