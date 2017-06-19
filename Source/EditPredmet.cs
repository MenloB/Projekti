using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Source.Entiteti;

namespace Source
{
    public partial class EditPredmet : Form
    {
        public DTPredmet predmet;

        public EditPredmet()
        {
            InitializeComponent();
        }

        public EditPredmet(DTPredmet predmet)
        {
            this.predmet = predmet;
            InitializeComponent();
            LoadPredmetInfo();
        }

        private void LoadPredmetInfo()
        {
            textBox1.Text = predmet.SifraPredmeta.ToString();
            textBox2.Text = predmet.NazivPredmeta;
            textBox3.Text = predmet.KatedraPredmeta;
            textBox4.Text = predmet.SemestarPredmeta;

            ISession s = DataLayer.GetSession();
            IList<Nastavnik> nastavnici = s.QueryOver<Nastavnik>().List<Nastavnik>();

            foreach(Nastavnik nastavnik in nastavnici)
            {
                comboBox1.Items.Add(nastavnik);
            }

            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Predmet pred = s.Load<Predmet>(predmet.SifraPredmeta);

            pred.Naziv = textBox2.Text;
            pred.Katedra = textBox3.Text;
            pred.Semestar = textBox4.Text;
            //try - catch block
            pred.Profesor = (Nastavnik) comboBox1.SelectedItem;

            s.Update(pred);
            s.Flush();
            s.Close();
        }
    }
}
