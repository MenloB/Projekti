using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;

namespace Source
{
    public class DTPredmet
    {
        public virtual int SifraPredmeta { get; set; }
        public virtual String NazivPredmeta { get; set; }
        public virtual String KatedraPredmeta { get; set; }
        public virtual String SemestarPredmeta { get; set; }

        public DTPredmet()
        {
        }

        public DTPredmet(int Sifra, String Naziv, String Katedra, String Semestar)
        {
            this.SifraPredmeta    = Sifra;
            this.NazivPredmeta    = Naziv;
            this.KatedraPredmeta  = Katedra;
            this.SemestarPredmeta = Semestar;
        }
    }

    public class DTProjekat
    {
        public virtual int ProjekatId { get; set; }
        public virtual String ProjekatNaziv { get; set; }
        public virtual String ProjekatTip { get; set; }
        public virtual int ProjekatGodina { get; set; }
        public virtual String ProjekatZavrsen { get; set; }
        public virtual String ProjekatGrupni { get; set; }

        public DTProjekat()
        {
        }

        public DTProjekat(int ProjekatId, String ProjekatNaziv, String ProjekatTip, 
            int ProjekatGodina, String ProjekatZavrsen, String ProjekatGrupni)
        {
            this.ProjekatId      = ProjekatId;
            this.ProjekatNaziv   = ProjekatNaziv;
            this.ProjekatTip     = ProjekatTip;
            this.ProjekatGodina  = ProjekatGodina;
            this.ProjekatZavrsen = ProjekatZavrsen;
            this.ProjekatGrupni  = ProjekatGrupni;
        }
    }

    public class DTLiteratura
    {
        public virtual int LiteraturaId { get; set; }
        public virtual String LiteraturaTip { get; set; }
    }

    public class DTRad : DTLiteratura
    {
        public virtual String RadNaziv { get; set; }
        public virtual String RadFormat { get; set; }
        public virtual String RadKonferencija { get; set; }
        public virtual String RadAdresa { get; set; }

        public DTRad()
        {
        }

        public DTRad(int RadInt, String RadNaziv, String RadFormat, String RadKonferencija, String RadAdresa)
        {
            LiteraturaId = RadInt;
            this.RadNaziv        = RadNaziv;
            this.RadFormat       = RadFormat;
            this.RadKonferencija = RadKonferencija;
            this.RadAdresa       = RadAdresa;
        }
    }
}
