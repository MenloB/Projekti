using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class WebStraniceView
    {
        public int Id { get; set; }
        public string Link { get; set; }

        public ProjekatView PripadaProjektu { get; set; }

        public WebStraniceView()
        {

        }

        public WebStraniceView(WebStranice w)
        {
            this.Id = w.Id;
            this.Link = w.Link;
            this.PripadaProjektu = new ProjekatView(w.PripadaProjektu);
        }
    }
}
