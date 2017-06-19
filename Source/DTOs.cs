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

    public class DTTeorijskiProjekat : DTProjekat
    {
        public virtual int BrojStranaProjekta { get; set; }
        
        //public virtual IList<DTLiteratura> ProjekatLiteratura { get; set; }

        public DTTeorijskiProjekat()
        {
        }

        public DTTeorijskiProjekat(int ProjekatId, int BrojStranaProjekta)
        {
            this.ProjekatId = ProjekatId;
            this.BrojStranaProjekta = BrojStranaProjekta;
        }
    }

    public class DTPrakticniProjekat : DTProjekat
    {
        public virtual String KratakOpisProjekta { get; set; }
        public virtual String JezikProjekta { get; set; }

        public DTPrakticniProjekat()
        {
        }

        public DTPrakticniProjekat(int ProjekatId, String KratakOpisProjekta, String JezikProjekta)
        {
            this.ProjekatId = ProjekatId;
            this.KratakOpisProjekta = KratakOpisProjekta;
            this.JezikProjekta = JezikProjekta;
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

    public class DTClanak : DTLiteratura
    {
        public virtual String ClanakNaziv { get; set; }
        public virtual String ClanakISSN { get; set; }
        public virtual int ClanakGodina { get; set; }
        public virtual String CasopisNaziv { get; set; }
        public virtual int CasopisBroj { get; set; }

        public DTClanak()
        {
        }

        public DTClanak(int ClanakId, String ClanakNaziv, String ClanakISSN, int ClanakGodina, String CasopisNaziv, int CasopisBroj)
        {
            this.LiteraturaId = ClanakId;
            this.ClanakNaziv = ClanakNaziv;
            this.ClanakISSN = ClanakISSN;
            this.ClanakGodina = ClanakGodina;
            this.CasopisNaziv = CasopisNaziv;
            this.CasopisBroj = CasopisBroj;
        }
    }

    public class DTKnjiga : DTLiteratura
    {
        public virtual String KnjigaISBN { get; set; }
        public virtual String KnjigaNaslov { get; set; }
        public virtual String KnjigaIzdavac { get; set; }
        public virtual int KnjigaGodina { get; set; }

        public DTKnjiga()
        {
        }

        public DTKnjiga(int KnjigaId, String KnjigaISBN, String KnjigaNaslov, String KnjigaIzdavac, int KnjigaGodina)
        {
            this.LiteraturaId = KnjigaId;
            this.KnjigaISBN = KnjigaISBN;
            this.KnjigaNaslov = KnjigaNaslov;
            this.KnjigaIzdavac = KnjigaIzdavac;
            this.KnjigaGodina = KnjigaGodina;
        }
    }

    public class DTAutor
    {
        public virtual int AutorId { get; set; }
        public virtual String AutorIme { get; set; }
        public virtual String AutorSIme { get; set; }
        public virtual String AutorPrezime { get; set; }

        public DTAutor()
        {
        }

        public DTAutor(int AutorId, String AutorIme, String AutorSIme, String AutorPrezime)
        {
            this.AutorId = AutorId;
            this.AutorIme = AutorIme;
            this.AutorSIme = AutorSIme;
            this.AutorPrezime = AutorPrezime;
        }
    }

    public class DTNastavnik
    {
        public virtual int NastavnikId { get; set; }
        public virtual String NastavnikIme { get; set; }
        public virtual String NastavnikSIme { get; set; }
        public virtual String NastavnikPrezime { get; set; }

        public DTNastavnik()
        {
        }

        public DTNastavnik(int NastavnikId, String NastavnikIme, String NastavnikSIme, String NastavnikPrezime)
        {
            this.NastavnikId = NastavnikId;
            this.NastavnikIme = NastavnikIme;
            this.NastavnikSIme = NastavnikSIme;
            this.NastavnikPrezime = NastavnikPrezime;
        }

    }

    public class DTStudent
    {
        public virtual int StudentId { get; set; }
        public virtual String StudentIme { get; set; }
        public virtual String StudentSIme { get; set; }
        public virtual String StudentPrezime { get; set; }
        public virtual int StudentBrInd { get; set; }
        public virtual String StudentSmer { get; set; }
        
        public DTStudent()
        {
        }

        public DTStudent(int StudentId, String StudentIme, String StudentSIme, String StudentPrezime,
            int StudentBrInd, String StudentSmer)
        {
            this.StudentId = StudentId;
            this.StudentIme = StudentIme;
            this.StudentSIme = StudentSIme;
            this.StudentPrezime = StudentPrezime;
            this.StudentBrInd = StudentBrInd;
            this.StudentSmer = StudentSmer;
        }
    }

    public class DTGrupa
    {
        public virtual int GrupaID { get; set; }
        public virtual String GrupaNaziv { get; set; }
        
        public DTGrupa()
        {
        }

        public DTGrupa(int GrupaID, String GrupaNaziv)
        {
            this.GrupaID = GrupaID;
            this.GrupaNaziv = GrupaNaziv;
        }
    }

    public class DTIzvestaj
    {
        public virtual int IzvestajId { get; set; }
        public virtual String IzvestajOpis { get; set; }
        public virtual DateTime IzvestajDatum { get; set; }
        
        public DTIzvestaj()
        {
        }

        public DTIzvestaj(int IzvestajId, String IzvestajOpis, DateTime IzvestajDatum)
        {
            this.IzvestajId = IzvestajId;
            this.IzvestajOpis = IzvestajOpis;
            this.IzvestajDatum = IzvestajDatum;
        }
    }

    public class DTWebStranice
    {
        public virtual int WebStraniceId { get; set; }
        public virtual String WebLink { get; set; }
        
        //public virtual DTProjekat WebStranicaPripadaProjektu { get; set; }

        public DTWebStranice()
        {
        }

        public DTWebStranice(int WebStraniceId, String WebLink)
        {
            this.WebStraniceId = WebStraniceId;
            this.WebLink = WebLink;
        }
    }
}
