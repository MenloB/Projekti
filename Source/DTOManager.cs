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
    }
}
