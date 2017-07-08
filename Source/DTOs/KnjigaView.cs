using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class KnjigaView
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Naslov { get; set; }
        public string Izdavac { get; set; }
        public int Godina { get; set; }

        public KnjigaView()
        {

        }

        public KnjigaView(Knjiga k)
        {
            this.Id = k.Id;
            this.ISBN = k.ISBN;
            this.Naslov = k.Naslov;
            this.Izdavac = k.Izdavac;
            this.Godina = k.Godina;
        }
    }
}
