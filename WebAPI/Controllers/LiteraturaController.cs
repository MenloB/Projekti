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
    public class LiteraturaController : ApiController
    {
        public IList<LiteraturaView> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetLiteraturu();
        }

    }
}
