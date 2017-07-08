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
    public class GrupeController : ApiController
    {
        public IList<GrupaView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetGrupe();
        }

        public GrupaView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetGrupaView(id);
        }

        public int Post([FromBody] Grupa g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddGrupa(g);
        }

        public int Put(int id, [FromBody] Grupa g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateGrupa(id, g);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveGrupa(id);
        }
    }
}
