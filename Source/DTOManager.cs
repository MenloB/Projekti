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
        public static PredmetDTO GetPredmetDTO(int predmetId)
        {
            PredmetDTO predmet = new PredmetDTO();
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(predmetId);
                predmet = new PredmetDTO(p.Sifra, 
                    p.Naziv, 
                    p.Katedra, 
                    p.Semestar, 
                    p.Profesor.Ime + p.Profesor.Prezime);
                s.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return predmet;
        }
    }
}
