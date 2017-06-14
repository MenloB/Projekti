using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class PredmetDTO
    {
        public int PredmetId { get; set; }
        public string PredmetNaziv { get; set; }
        public string Katedra { get; set; }
        public string Semestar { get; set; }
        public string Nastavik { get; set; }


        public PredmetDTO()
        {

        }

        public PredmetDTO(int PredmetId, 
            string PredmetNaziv, 
            string Katedra, 
            string Semestar, 
            string Nastavnik)
        {
            this.PredmetId    = PredmetId;
            this.PredmetNaziv = PredmetNaziv;
            this.Katedra      = Katedra;
            this.Semestar     = Semestar;
            this.Nastavik     = Nastavik;
        }
    }
}
