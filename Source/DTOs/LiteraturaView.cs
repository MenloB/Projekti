using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source;
using Source.Entiteti;

namespace Source.DTOs
{
    public class LiteraturaView
    {
        public int Id { get; set; }
        public string Tip { get; set; }

        public AutorView Autor { get; set; }
        public IList<ProjekatView> Projekti { get; set; }

        public LiteraturaView()
        {

        }
        
        public LiteraturaView(Literatura l)
        {
            this.Id = l.Id;
            this.Tip = l.Tip;
            this.Autor = new AutorView(l.Pisao);

            this.Projekti = new List<ProjekatView>();

            foreach(Projekat projekat in l.Projekti)
            {
                this.Projekti.Add(new ProjekatView(projekat));
            }
        }
    }
}
