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
    public partial class DodajProjekat : Form
    {
        public DodajProjekat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Projekat p = new Projekat();
            p.Naziv = textBox1.Text;
            try
            {
                p.Godina = Int32.Parse(textBox2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Godina treba biti ceo, nenegativan broj." + ex.Message);
            }

            if (checkBox1.Checked)
                p.Tip = "TEORIJSKI";
            else
                p.Tip = "PRAKTICAN";

            if (checkBox2.Checked)
                p.Grupni = "Da";
            else
                p.Grupni = "Ne";

            if (checkBox3.Checked)
                p.Zavrsen = "Da";
            else
                p.Zavrsen = "Ne";

            p.predmet = (Predmet) comboBox1.SelectedItem;
            s.Save(p);
            s.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajProjekat_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();

            comboBox1.DataSource = predmeti;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = null;

            if(comboBox1.SelectedValue != null)
            {
                Predmet testPredmet = (Predmet)comboBox1.SelectedValue;
                MessageBox.Show(testPredmet.Naziv);
            }

            //foreach (Predmet predmet in predmeti)
            //{
            //    comboBox1.DisplayMember = predmet.Naziv;
            //    comboBox1.ValueMember = predmet.Naziv;
            //}

            IList<Grupa> grupe = s.QueryOver<Grupa>().List<Grupa>();

            comboBox2.DataSource = grupe;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = null;

            if(comboBox2.SelectedValue != null)
            {
                Grupa obelezenaGrupa = (Grupa)comboBox2.SelectedValue;
                MessageBox.Show(obelezenaGrupa.Naziv);
            }

            //foreach(Grupa grupa in grupe)
            //{
            //    comboBox2.Items.Add(grupa);
            //}

            s.Close();
        }
    }
}
