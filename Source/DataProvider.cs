using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Entiteti;
using NHibernate;
using NHibernate.Linq;
using Source.DTOs;

namespace Source
{
    public class DataProvider
    {
        public IList<PredmetView> GetPredmeti()
        {
            IEnumerable<Predmet> predmeti = null;
            IList<PredmetView> preds = new List<PredmetView>();
            try
            {
                ISession s = DataLayer.GetSession();
                predmeti = s.Query<Predmet>().Select(p => p);
                
                foreach(Predmet predmet in predmeti)
                {
                    preds.Add(new PredmetView(predmet));
                }
                return preds;
            }
            catch(Exception)
            {
                return preds;
            }
        }

        public int AddPredmet(Predmet p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(p);

                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemovePredmet(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet p = s.Get<Predmet>(id);

                s.Delete(p);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdatePredmet(int id, Predmet p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet predmet = s.Get<Predmet>(id);

                predmet.Naziv = p.Naziv;
                predmet.Katedra = p.Katedra;
                predmet.Semestar = p.Semestar;

                s.Update(predmet);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public PredmetView GetPredmetView(int id)
        {
            ISession s = DataLayer.GetSession();

            Predmet pred = s.Query<Predmet>().Where(v => v.Sifra == id).Select(p => p).FirstOrDefault();
            s.Close();

            if (pred == null)
                return new PredmetView();

            return new PredmetView(pred);
        }

        public IList<NastavnikView> GetNastavnici()
        {
            IEnumerable<Nastavnik> nastavnici = null;
            IList<NastavnikView> Nastavnici = new List<NastavnikView>();
            try
            {
                ISession s = DataLayer.GetSession();
                nastavnici = s.Query<Nastavnik>().Select(n => n);

                foreach(Nastavnik nastavnik in nastavnici)
                {
                    Nastavnici.Add(new NastavnikView(nastavnik));
                }

                return Nastavnici;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public NastavnikView GetNastavnikView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nastavnik nastavnik = s.Query<Nastavnik>().Where(n => n.Id == id).Select(x => x).FirstOrDefault();
                s.Close();
                if (nastavnik == null)
                    return new NastavnikView();

                return new NastavnikView(nastavnik);
            }
            catch(Exception)
            {
                return new NastavnikView();
            }
        }

        public int AddNastavnik(Nastavnik n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(n);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateNastavnik(int id, Nastavnik n)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Nastavnik nastavnik = s.Get<Nastavnik>(id);

                nastavnik.Ime = n.Ime;
                nastavnik.SIme = n.SIme;
                nastavnik.Prezime = n.Prezime;

                s.Update(nastavnik);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveNastavnik(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Nastavnik nastavnik = s.Get<Nastavnik>(id);

                s.Delete(nastavnik);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public IList<StudentView> GetStudenti()
        {
            IList<StudentView> Studenti = new List<StudentView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Student> studenti = from stud in s.Query<Student>()
                                                select stud;

                foreach (Student student in studenti)
                    Studenti.Add(new StudentView(student));

                s.Close();

                return Studenti;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public StudentView GetStudentView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Student student = s.Query<Student>().Where(stud => stud.Id == id).Select(st => st).FirstOrDefault();
                s.Close();
                if (student == null)
                    return new StudentView();

                return new StudentView(student);
            }
            catch(Exception)
            {
                return new StudentView();
            }
        }

        public int AddStudent(Student student)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(student);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateStudent(int id, Student stud)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Student student = s.Get<Student>(id);

                student.Ime = stud.Ime;
                student.SIme = stud.SIme;
                student.Prezime = stud.Prezime;
                student.Smer = stud.Smer;
                student.BrIndeksa = stud.BrIndeksa;

                s.Update(student);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveStudent(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Student student = s.Get<Student>(id);

                s.Delete(student);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public IList<AutorView> GetAutore()
        {
            IList<AutorView> Autori = new List<AutorView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Autor> autori = from a in s.Query<Autor>()
                                            select a;

                foreach(Autor autor in autori)
                {
                    Autori.Add(new AutorView(autor));
                }

                return Autori;
            }
            catch(Exception)
            {
                return Autori;
            }
        }

        public AutorView GetAutorView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Autor a = s.Load<Autor>(id);

                if (a == null)
                    return new AutorView();

                return new AutorView(a);
            }
            catch(Exception)
            {
                return new AutorView();
            }
        }

        public int AddAutor(Autor a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(a);

                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateAutor(int id, Autor a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Autor autor = s.Load<Autor>(id);

                System.Windows.Forms.MessageBox.Show(a.Ime);
                System.Windows.Forms.MessageBox.Show(a.Id.ToString());
                autor.Ime = a.Ime;
                autor.SIme = a.SIme;
                autor.Prezime = a.Prezime;
                
                s.Update(autor);
                s.Flush();
                s.Close();
                return 1;

            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveAutor(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Autor a = s.Load<Autor>(id);

                s.Delete(a);

                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public IList<ClanakView> GetClanke()
        {
            IList<ClanakView> Clanci = new List<ClanakView>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Clanak> clanci = from c in s.Query<Clanak>()
                                             select c;

                foreach(Clanak clanak in clanci)
                {
                    Clanci.Add(new ClanakView(clanak));
                }

                return Clanci;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public ClanakView GetClanakView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Clanak c = s.Load<Clanak>(id);

                if (c == null)
                    return new ClanakView();

                return new ClanakView(c);
            }
            catch(Exception)
            {
                return new ClanakView();
            }
        }
        
        public int AddClanak(Clanak c)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                c.Tip = "CLANAK";

                s.Save(c);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateClanak(int id, Clanak c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Clanak clanak = s.Load<Clanak>(id);

                clanak.ISSN = c.ISSN;
                clanak.Naziv = c.Naziv;
                clanak.NazivCasopisa = c.NazivCasopisa;
                clanak.Godina = c.Godina;

                s.Update(clanak);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveClanak(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Clanak c = s.Load<Clanak>(id);

                s.Delete(c);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public IList<ProjekatView> GetProjekte()
        {
            IList<ProjekatView> Projekti = new List<ProjekatView>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Projekat> projekti = from p in s.Query <Projekat>()
                                                 select p;

                foreach(Projekat projekat in projekti)
                {
                    Projekti.Add(new ProjekatView(projekat));
                }

                return Projekti;
            }
            catch(Exception)
            {
                return Projekti;
            }
        }

        public ProjekatView GetProjekatView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Projekat p = s.Load<Projekat>(id);

                if (p == null)
                    return new ProjekatView();

                return new ProjekatView(p);
            }
            catch(Exception)
            {
                return new ProjekatView();
            }
        }

        public int AddProjekat(Projekat k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(k);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateProjekat(int id, Projekat p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Projekat projekat = s.Get<Projekat>(id);

                projekat.Naziv = p.Naziv;
                projekat.Godina = p.Godina;
                projekat.Grupni = p.Grupni;
                projekat.Tip = p.Tip;

                s.Update(projekat);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveProjekat(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Projekat proj = s.Get<Projekat>(id);

                s.Delete(proj);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public IList<GrupaView> GetGrupe()
        {
            IList<GrupaView> Grupe = new List<GrupaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Grupa> grupe = from g in s.Query<Grupa>()
                                           select g;

                foreach(Grupa grupa in grupe)
                {
                    Grupe.Add(new GrupaView(grupa));
                }
                return Grupe;
            }
            catch(Exception)
            {
                return Grupe;
            }
        }

        public GrupaView GetGrupaView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Grupa g = s.Load<Grupa>(id);

                if (g == null)
                    return new GrupaView();

                return new GrupaView(g);

            }
            catch(Exception)
            {
                return new GrupaView();
            }
        }

        public int AddGrupa(Grupa g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateGrupa(int id, Grupa g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Grupa grupa = s.Load<Grupa>(id);

                grupa.Naziv = g.Naziv;

                s.Update(grupa);
                s.Flush();
                s.Close();
                return 1;
            }

            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveGrupa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Grupa g = s.Load<Grupa>(id);

                s.Delete(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public IList<IzvestajView> GetIzvestaji()
        {
            IList<IzvestajView> Izvestaji = new List<IzvestajView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Izvestaj> izvestaji = from i in s.Query<Izvestaj>()
                                                  select i;

                foreach(Izvestaj izvestaj in izvestaji)
                {
                    Izvestaji.Add(new IzvestajView(izvestaj));
                }

                return Izvestaji;
            }
            catch(Exception)
            {
                return Izvestaji;
            }
        }

        public IzvestajView GetIzvestajView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj i = s.Get<Izvestaj>(id);

                return new IzvestajView(i);
            }
            catch(Exception)
            {
                return new IzvestajView();
            }
        }

        public int AddIzvestaj(Izvestaj i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Prakticni projekat i grupa ucitani su SAMO da bi proslo snimanje
                PrakticniProjekat p = s.Get<PrakticniProjekat>(1);
                Grupa g = s.Get<Grupa>(3);
                i.PodnelaGrupa = g;
                i.ZaProjekat = p;

                s.Save(i);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateIzvestaj(int id, Izvestaj i)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj izvestaj = s.Get<Izvestaj>(id);

                izvestaj.Opis = i.Opis;
                izvestaj.DatumPodnosenja = i.DatumPodnosenja;

                s.Update(izvestaj);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveIzvestaj(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj izvestaj = s.Get<Izvestaj>(id);

                s.Delete(izvestaj);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public IList<KnjigaView> GetKnjige()
        {
            IList<KnjigaView> Knjige = new List<KnjigaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Knjiga> knjige = from k in s.Query<Knjiga>()
                                             select k;

                foreach(Knjiga knjiga in knjige)
                {
                    Knjige.Add(new KnjigaView(knjiga));
                }

                return Knjige;
            }
            catch(Exception)
            {
                return Knjige;
            }
        }

        public KnjigaView GetKnjigaView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga k = s.Get<Knjiga>(id);

                if (k == null)
                    return new KnjigaView();

                return new KnjigaView(k);
            }
            catch(Exception)
            {
                return new KnjigaView();
            }
        }

        public int AddKnjiga(Knjiga k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                k.Tip = "KNJIGA";

                s.Save(k);

                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateKnjiga(int id, Knjiga k)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga knjiga = s.Get<Knjiga>(id);

                knjiga.Naslov = k.Naslov;
                knjiga.Izdavac = k.Izdavac;
                knjiga.Godina = k.Godina;
                knjiga.ISBN = k.ISBN;

                s.Update(knjiga);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveKnjiga(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga k = s.Get<Knjiga>(id);
                s.Delete(k);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public IList<RadView> GetRadove()
        {
            IList<RadView> Radovi = new List<RadView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Rad> radovi = from r in s.Query<Rad>()
                                          select r;

                foreach(Rad rad in radovi)
                {
                    Radovi.Add(new RadView(rad));
                }

                return Radovi;
            }
            catch(Exception)
            {
                return Radovi;
            }
        }

        public RadView GetRadView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Rad rad = s.Get<Rad>(id);

                if (rad == null)
                    return new RadView();

                return new RadView(rad);
            }
            catch(Exception)
            {
                return new RadView();
            }
        }

        public int AddRad(Rad r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateRad(int id, Rad r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Rad rad = s.Get<Rad>(id);
                Autor a = s.Get<Autor>(19);

                rad.Pisao = a;
                rad.Naziv = r.Naziv;
                rad.Tip = "RAD";
                rad.Konferencija = r.Konferencija;
                rad.Format = r.Format;
                rad.Adresa = r.Adresa;

                s.Update(rad);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveRad(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Rad rad = s.Get<Rad>(id);

                s.Delete(rad);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }
        
        public IList<WebStraniceView> GetWebStranice()
        {
            IList<WebStraniceView> WebStranice = new List<WebStraniceView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<WebStranice> webStranice = from w in s.Query<WebStranice>()
                                                       select w;

                foreach(WebStranice webstranica in webStranice)
                {
                    WebStranice.Add(new WebStraniceView(webstranica));
                }

                return WebStranice;
            }
            catch(Exception)
            {
                return WebStranice;
            }
        }

        public int AddWebStranice(WebStranice k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(k);
                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateWebStranice(int id, WebStranice k)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                WebStranice ws = s.Get<WebStranice>(id);

                ws.Link = k.Link;

                s.Update(ws);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int RemoveWebStranice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                WebStranice ws = s.Get<WebStranice>(id);

                s.Delete(ws);
                s.Flush();
                s.Close();
                return 1;                
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public WebStraniceView GetWebStraniceView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                WebStranice ws = s.Get<WebStranice>(id);

                if (ws == null)
                    return new WebStraniceView();

                return new WebStraniceView(ws);
            }
            catch(Exception)
            {
                return new WebStraniceView();
            }
        }

        public IList<LiteraturaView> GetLiteraturu()
        {
            IList<LiteraturaView> Literatura = new List<LiteraturaView>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Literatura> literature = from l in s.Query<Literatura>()
                                                     select l;

                foreach(Literatura literatura in literature)
                {
                    Literatura.Add(new LiteraturaView(literatura));
                }

                return Literatura;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
