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
    public partial class EditIzvestaj : Form
    {
        public DTIzvestaj izvestaj;

        public EditIzvestaj()
        {
            InitializeComponent();
        }

        public EditIzvestaj(DTIzvestaj izvestaj)
        {
            this.izvestaj = izvestaj;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = izvestaj.IzvestajId.ToString();
            richTextBox1.Text = izvestaj.IzvestajOpis;
            dateTimePicker1.Value = (DateTime)izvestaj.IzvestajDatum;

            ISession s = DataLayer.GetSession();
            IList<Projekat> projekti = s.QueryOver<Projekat>().List<Projekat>();

            foreach(Projekat projekat in projekti)
            {
                comboBox1.Items.Add(projekat);
            }

            IList<Grupa> grupe = s.QueryOver<Grupa>().List<Grupa>();

            foreach(Grupa grupa in grupe)
            {
                comboBox2.Items.Add(grupa);
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
            Izvestaj i = s.Load<Izvestaj>(izvestaj.IzvestajId);

            i.Opis = richTextBox1.Text;
            i.DatumPodnosenja = dateTimePicker1.Value;
            i.ZaProjekat = (PrakticniProjekat) comboBox1.SelectedItem;
            i.PodnelaGrupa = (Grupa)comboBox2.SelectedItem;

            s.Update(i);
            s.Flush();
            s.Close();
        }
    }
}
