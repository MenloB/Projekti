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
    public partial class EditNastavnika : Form
    {
        public DTNastavnik nastavnik;

        public EditNastavnika()
        {
            InitializeComponent();
        }

        public EditNastavnika(DTNastavnik nastavnik)
        {
            this.nastavnik = nastavnik;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = nastavnik.NastavnikId.ToString();
            textBox2.Text = nastavnik.NastavnikIme;
            textBox3.Text = nastavnik.NastavnikSIme;
            textBox4.Text = nastavnik.NastavnikPrezime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Nastavnik n = s.Load<Nastavnik>(nastavnik.NastavnikId);

            n.Ime = textBox2.Text;
            n.SIme = textBox3.Text;
            n.Prezime = textBox4.Text;

            s.Update(n);
            s.Flush();
            s.Close();
        }
    }
}
