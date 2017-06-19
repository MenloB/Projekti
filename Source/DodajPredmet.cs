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
    public partial class DodajPredmet : Form
    {
        public DodajPredmet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Predmet p = new Predmet();

            p.Naziv = textBox1.Text;
            p.Katedra = textBox2.Text;
            p.Semestar = textBox3.Text;

            p.Profesori.Add((Nastavnik)comboBox1.SelectedItem);

            s.Save(p);
            s.Flush();
            s.Close();
            Close();
        }

        private void DodajPredmet_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Nastavnik> nastavnici = s.QueryOver<Nastavnik>().List<Nastavnik>();

            foreach(Nastavnik nastavnik in nastavnici)
            {
                comboBox1.Items.Add(nastavnik);
            }

            s.Close();
        }
    }
}
