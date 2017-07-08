using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;
using NHibernate;
using NHibernate.Linq;

namespace Source
{
    public class DTOManager
    {

        //DTO Manager Methods for 'Projekti'
        public static DTProjekat GetProjekat(int idProjekta)
        {
            DTProjekat DtProjekat = new DTProjekat();
            try
            {
                ISession _session = DataLayer.GetSession();
                Projekat p = _session.Load<Projekat>(idProjekta);
                DtProjekat = new DTProjekat(p.Id, p.Naziv, p.Tip, p.Godina, p.Zavrsen, p.Grupni);
                _session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return DtProjekat;
            
        }

        public static DTProjekat UpdateProjekat(DTProjekat proj)
        {
            try
            {
                ISession _session = DataLayer.GetSession();
                Projekat p        = _session.Load<Projekat>(proj.ProjekatId);
                p.Naziv           = proj.ProjekatNaziv;
                p.Tip             = proj.ProjekatTip;
                p.Godina          = proj.ProjekatGodina;
                p.Zavrsen         = proj.ProjekatZavrsen;
                p.Grupni          = proj.ProjekatGrupni;

                _session.Update(p);
                _session.Flush();
                _session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return proj;
        }

        public static List<DTProjekat> GetProjekte()
        {
            List<DTProjekat> projekti = new List<DTProjekat>();
            try
            {
                ISession _session = DataLayer.GetSession();

                IEnumerable<Projekat> ucitaniProjekti = _session.QueryOver<Projekat>()
                                                                .List<Projekat>();

                foreach(Projekat pr in ucitaniProjekti)
                {
                    projekti.Add(new DTProjekat(pr.Id, pr.Naziv, pr.Tip, pr.Godina, pr.Zavrsen, pr.Grupni));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return projekti;
        }

        //DTO Manager Methods for 'Predmet'
        public static DTPredmet GetPredmet(int PredmetId)
        {
            DTPredmet dp = new DTPredmet();

            try
            {
                ISession _session = DataLayer.GetSession();
                Predmet p = _session.Load<Predmet>(PredmetId);

                dp = new DTPredmet(p.Sifra, p.Naziv, p.Katedra, p.Semestar);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dp;
        }

        public static DTPredmet UpdatePredmet(DTPredmet pred)
        {
            try
            {
                ISession _session = DataLayer.GetSession();
                Predmet predmet   = _session.Load<Predmet>(pred.SifraPredmeta);
                predmet.Sifra     = pred.SifraPredmeta;
                predmet.Naziv     = pred.NazivPredmeta;
                predmet.Semestar  = pred.SemestarPredmeta;
                predmet.Katedra   = pred.KatedraPredmeta;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return pred;
        }

        public static void UpdateClanak(DTClanak clanak)
        {
            throw new NotImplementedException();
        }

        public static DTClanak GetClanak(int idClanak)
        {
            DTClanak clanak = new DTClanak();

            try
            {
                ISession session = DataLayer.GetSession();
                Clanak c = session.Load<Clanak>(idClanak);

                clanak = new DTClanak(c.Id, c.Naziv, c.ISSN, c.Godina, c.NazivCasopisa, c.BrojCasopisa);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return clanak;
        }

        public static List<DTPredmet> GetPredmete()
        {
            List<DTPredmet> predmeti = new List<DTPredmet>();
            try
            {
                ISession _session = DataLayer.GetSession();
                IEnumerable<Predmet> ucitaniPredmeti = _session.QueryOver<Predmet>()
                                                               .List<Predmet>();
                foreach(Predmet pred in ucitaniPredmeti)
                {
                    DTPredmet predmet = new DTPredmet(pred.Sifra, pred.Naziv, pred.Katedra, pred.Katedra);
                    predmeti.Add(predmet);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return predmeti;
        }

        //DTO Manager Methods for 'Rad'
        public static DTRad GetRad(int IdRada)
        {
            DTRad DtRad = new DTRad();
            try
            {
                ISession session = DataLayer.GetSession();
                Rad r = session.Load<Rad>(IdRada);
                DTRad dr = new DTRad(r.Id, r.Naziv, r.Format, r.Konferencija, r.Adresa);
                session.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return DtRad;
        }

        public static DTKnjiga GetKnjiga(int idKnjige)
        {
            DTKnjiga knjiga = new DTKnjiga();

            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga k = s.Load<Knjiga>(idKnjige);

                knjiga = new DTKnjiga(k.Id, k.ISBN, k.Naslov, k.Izdavac, k.Godina);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return knjiga;
        }

        internal static void UpdateKnjiga(DTKnjiga knjiga)
        {
            throw new NotImplementedException();
        }

        public static DTRad UpdateRad(DTRad dr)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                Rad r            = session.Load<Rad>(dr.LiteraturaId);
                r.Naziv          = dr.RadNaziv;
                r.Format         = dr.RadFormat;
                r.Konferencija   = dr.RadKonferencija;
                r.Adresa         = dr.RadAdresa;

                session.Update(r);
                session.Flush();
                session.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dr;
        }

        public static DTAutor GetAutor(int idAutora)
        {
            DTAutor autor = new DTAutor();

            try
            {
                ISession s = DataLayer.GetSession();
                Autor a = s.Load<Autor>(idAutora);

                autor = new DTAutor(a.Id, a.Ime, a.SIme, a.Prezime);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return autor;
        }

        internal static void UpdateAutor(object autor)
        {
            throw new NotImplementedException();
        }

        public static List<DTRad> GetRadove()
        {
            List<DTRad> radovi = new List<DTRad>();

            try
            {
                ISession session = DataLayer.GetSession();
                IList<Rad> ucitaniRadovi = session.QueryOver<Rad>()
                    .List<Rad>();

                foreach(Rad rad in ucitaniRadovi)
                {
                    radovi.Add(new DTRad(rad.Id, rad.Naziv, rad.Format, rad.Konferencija, rad.Adresa));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return radovi;
        }

        public static DTStudent GetStudent(int idStudenta)
        {
            DTStudent student = new DTStudent();

            try
            {
                ISession s = DataLayer.GetSession();
                Student stud = s.Load<Student>(idStudenta);

                student = new DTStudent(stud.Id, stud.Ime, stud.SIme, stud.Prezime, stud.BrIndeksa, stud.Smer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return student;
        }

        internal static void UpdateStudenta(object student)
        {
            throw new NotImplementedException();
        }

        //DTOManager Methods for Nastavnik
        public static void UpdateNastavnik(DTNastavnik nastavnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Nastavnik n = s.Load<Nastavnik>(nastavnik.NastavnikId);
                n.Ime = nastavnik.NastavnikIme;
                n.SIme = nastavnik.NastavnikSIme;
                n.Prezime = nastavnik.NastavnikPrezime;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal static void UpdateIzvestaj(DTIzvestaj izvestaj)
        {
            throw new NotImplementedException();
        }

        internal static DTIzvestaj GetIzvestaj(int idIzvestaja)
        {
            DTIzvestaj izvestajDT = new DTIzvestaj();
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj izvestaj = s.Load<Izvestaj>(idIzvestaja);

                izvestajDT = new DTIzvestaj(izvestaj.Id, izvestaj.Opis, izvestaj.DatumPodnosenja);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return izvestajDT;
        }

        internal static void UpdateWebStranicu(DTWebStranice webStranicu)
        {
            throw new NotImplementedException();
        }

        internal static DTWebStranice GetStranicu(int idWebStranice)
        {
            DTWebStranice webStranica = new DTWebStranice();
            try
            {
                ISession s = DataLayer.GetSession();
                WebStranice stranica = s.Load<WebStranice>(idWebStranice);

                webStranica = new DTWebStranice(stranica.Id, stranica.Link);
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return webStranica;
        }

        public static DTNastavnik GetNastavnik(int idNastavnika)
        {
            DTNastavnik nastavnik = new DTNastavnik();
            try
            {
                ISession s = DataLayer.GetSession();
                Nastavnik n = s.Load<Nastavnik>(idNastavnika);

                nastavnik = new DTNastavnik(n.Id, n.Ime, n.SIme, n.Prezime);
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return nastavnik;
        }

        public static void UpdateGrupa(object grupa)
        {
            throw new NotImplementedException();
        }

        public static DTGrupa GetGrupa(int idGrupa)
        {
            DTGrupa grupa = new DTGrupa();

            try
            {
                ISession session = DataLayer.GetSession();
                Grupa g = session.Load<Grupa>(idGrupa);

                grupa = new DTGrupa(g.Id, g.Naziv);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return grupa;
        }

        public static List<DTNastavnik> GetNastavnike()
        {
            List<DTNastavnik> nastavnici = new List<DTNastavnik>();

            try
            {
                ISession session = DataLayer.GetSession();
                IList<Nastavnik> ucitaniNastavnici = session.QueryOver<Nastavnik>()
                                                            .List<Nastavnik>();

                foreach(Nastavnik nastavnik in ucitaniNastavnici)
                {
                    nastavnici.Add(new DTNastavnik(nastavnik.Id, nastavnik.Ime, nastavnik.SIme, nastavnik.Prezime));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return nastavnici;
        }
    }
}
