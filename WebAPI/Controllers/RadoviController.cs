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
    public class RadoviController : ApiController
    {
        public IList<RadView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetRadove();
        }

        public RadView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetRadView(id);
        }

        public int Post([FromBody]Rad k)
        {
            DataProvider provider = new DataProvider();
            return provider.AddRad(k);
        }

        public int Put(int id, [FromBody]Rad k)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateRad(id, k);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveRad(id);
        }
    }
}
