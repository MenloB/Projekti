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
    public class IzvestajiController : ApiController
    {
        public IList<IzvestajView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetIzvestaji();
        }

        public IzvestajView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetIzvestajView(id);
        }

        public int Post([FromBody]Izvestaj i)
        {
            DataProvider provider = new DataProvider();
            return provider.AddIzvestaj(i);
        }

        public int Put(int id, [FromBody]Izvestaj i)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateIzvestaj(id, i);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveIzvestaj(id);
        }
    }
}
