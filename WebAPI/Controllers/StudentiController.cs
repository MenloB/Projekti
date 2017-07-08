using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Source.DTOs;
using Source;
using Source.Entiteti;

namespace WebAPI.Controllers
{
    public class StudentiController : ApiController
    {
        public IList<StudentView> GetStudenti()
        {
            DataProvider provider = new DataProvider();
            return provider.GetStudenti();
        }

        public StudentView GetStudentView(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetStudentView(id);
        }

        public int Post([FromBody]Student k)
        {
            DataProvider provider = new DataProvider();
            return provider.AddStudent(k);
        }

        public int Put(int id, [FromBody]Student k)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateStudent(id, k);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveStudent(id);
        }
    }
}
