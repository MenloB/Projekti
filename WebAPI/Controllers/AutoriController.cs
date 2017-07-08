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
    public class AutoriController : ApiController
    {
        public IList<AutorView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetAutore();
        }

        public AutorView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetAutorView(id);
        }

        public int Post([FromBody] Autor a)
        {
            DataProvider provider = new DataProvider();
            return provider.AddAutor(a);
        }

        public int Put(int id, [FromBody]Autor a)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateAutor(id, a);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveAutor(id);
        }
    }
}
