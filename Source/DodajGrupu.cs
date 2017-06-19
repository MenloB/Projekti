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
    public partial class DodajGrupu : Form
    {
        public DodajGrupu()
        {
            InitializeComponent();
        }

        private void DodajGrupu_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Projekat> projekti = s.QueryOver<Projekat>().List<Projekat>();

            foreach (Projekat projekat in projekti)
            {
                comboBox1.Items.Add(projekat);
            }

            s.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Grupa g = new Grupa();
            g.Naziv = textBox1.Text;
            g.Projekti.Add((Projekat) comboBox1.SelectedItem);

            s.SaveOrUpdate(g);
            s.Flush();
            s.Close();
            Close();
        }
    }
}
