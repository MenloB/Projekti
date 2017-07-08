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
    public class ProjektiController : ApiController
    {
        public IList<ProjekatView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetProjekte();
        }

        public ProjekatView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetProjekatView(id);
        }

        public int Post([FromBody]Projekat k)
        {
            DataProvider provider = new DataProvider();
            return provider.AddProjekat(k);
        }

        public int Put(int id, [FromBody]Projekat k)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateProjekat(id, k);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveProjekat(id);
        }
    }
}
