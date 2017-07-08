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
    public class WebStraniceController : ApiController
    {
        public IList<WebStraniceView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetWebStranice();
        }

        public WebStraniceView Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetWebStraniceView(id);
        }

        public int Post([FromBody]WebStranice k)
        {
            DataProvider provider = new DataProvider();
            return provider.AddWebStranice(k);
        }

        public int Put(int id, [FromBody]WebStranice k)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateWebStranice(id, k);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveWebStranice(id);
        }
    }
}
