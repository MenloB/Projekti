using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source.DTOs
{
    public class StudentView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string SIme { get; set; }
        public string Prezime { get; set; }
        public int BrInd { get; set; }
        public string Smer { get; set; }
        public PredmetView SlusaPredmet { get; set; }
        public GrupaView PripadaGrupa { get; set; }

        public StudentView(Student s)
        {
            this.Id = s.Id;
            this.Ime = s.Ime;
            this.SIme = s.SIme;
            this.Prezime = s.Prezime;
            this.BrInd = s.BrIndeksa;
            this.Smer = s.Smer;
            this.SlusaPredmet = new PredmetView(s.SlusaPredmet);
            this.PripadaGrupa = new GrupaView(s.PripadaGrupi);
        }

        public StudentView()
        {

        }
    }
}
