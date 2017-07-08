using Source.Entiteti;
using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Source.DTOs;

namespace WebAPI.Controllers
{
    public class PredmetiController : ApiController
    {
        //GET api/predmeti
        public IList<PredmetView> Get()
        {
            DataProvider provider = new DataProvider();

            IList<PredmetView> predmeti = provider.GetPredmeti();

            return predmeti;
        }

        //GET api/predmeti/1
        public PredmetView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetPredmetView(id);
        }

        public int Post([FromBody]Predmet p)
        {
            DataProvider provider = new DataProvider();
            return provider.AddPredmet(p);
        }

        public int Put(int id, [FromBody]Predmet p)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdatePredmet(id, p);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemovePredmet(id);
        }
    }
}
