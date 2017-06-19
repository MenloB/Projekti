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
    public partial class DodajIzvestaj : Form
    {
        public DodajIzvestaj()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Izvestaj i = new Izvestaj();

            i.Opis = textBox1.Text;
            i.DatumPodnosenja = dateTimePicker1.Value.Date;
            i.ZaProjekat = (PrakticniProjekat)comboBox1.SelectedItem;
            i.PodnelaGrupa = (Grupa)comboBox2.SelectedItem;

            s.Save(i);
            s.Flush();
            s.Close();
        }

        private void DodajIzvestaj_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            IList<PrakticniProjekat> projekti = s.QueryOver<PrakticniProjekat>().List<PrakticniProjekat>();

            foreach(PrakticniProjekat projekat in projekti)
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
    }
}
