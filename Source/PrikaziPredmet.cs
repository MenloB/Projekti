using NHibernate;
using Source.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source
{
    public partial class PrikaziPredmet : Form
    {
        public int predmet;

        public PrikaziPredmet()
        {
            InitializeComponent();
        }

        public PrikaziPredmet(int Id)
        {
            this.predmet = Id;
            InitializeComponent();
        }

        private void PrikaziPredmete_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Predmet pred = s.Load<Predmet>(this.predmet);
            
            txtSifra.Text = pred.Sifra.ToString();
            txtNaziv.Text = pred.Naziv;
            txtKatedra.Text = pred.Katedra;
            txtSemestar.Text = pred.Semestar;
            txtNastavnik.Text = pred.Profesor.Ime + pred.Profesor.Prezime;

            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Predmet p = s.Load<Predmet>(Int32.Parse(txtSifra.Text));

            p.Naziv = txtNaziv.Text;
            p.Katedra = txtKatedra.Text;
            p.Semestar = txtSemestar.Text;

            s.Update(p);
            s.Flush();
            s.Close();
        }
    }
}
