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
    public partial class DodajWebStranicu : Form
    {
        public DodajWebStranicu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajWebStranicu_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Projekat> projekti = s.QueryOver<Projekat>().List<Projekat>();

            foreach(Projekat projekat in projekti)
            {
                comboBox1.Items.Add(projekat);
            }

            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            WebStranice stranica = new WebStranice();

            stranica.Link = textBox1.Text;
            stranica.PripadaProjektu = (Projekat)comboBox1.SelectedItem;

            s.Save(stranica);
            s.Flush();
            s.Close();
        }
    }
}
