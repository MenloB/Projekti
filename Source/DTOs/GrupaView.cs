using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class GrupaView
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        //public IList<ProjekatView> Projekti { get; set; }
        
        public GrupaView()
        {

        }

        public GrupaView(Grupa g)
        {
            this.Id = g.Id;
            this.Naziv = g.Naziv;
            //this.Projekti = new List<ProjekatView>();

            //foreach(Projekat Projekat in g.Projekti)
            //{
            //    this.Projekti.Add(new ProjekatView(Projekat));
            //}
        }
    }
}
