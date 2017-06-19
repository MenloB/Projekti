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
    public partial class DodajNastavnika : Form
    {
        public DodajNastavnika()
        {
            InitializeComponent();
        }

        private void DodajNastavnika_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();

            foreach(Predmet predmet in predmeti)
            {
                comboBox1.Items.Add(predmet);
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
            Nastavnik n = new Nastavnik();

            n.Ime     = textBox1.Text;
            n.SIme    = textBox2.Text;
            n.Prezime = textBox3.Text;

            n.Predmeti.Add((Predmet) comboBox1.SelectedItem);

            s.Save(n);
            s.Flush();
            s.Close();
        }
    }
}
