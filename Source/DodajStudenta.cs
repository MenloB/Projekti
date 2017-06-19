using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source.Entiteti;
using NHibernate;

namespace Source
{
    public partial class DodajStudenta : Form
    {
        public DodajStudenta()
        {
            InitializeComponent();
        }

        private void DodajStudenta_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();

            foreach(Predmet predmet in predmeti)
            {
                comboBox1.Items.Add(predmet);
            }

            IList<Grupa> grupe = s.QueryOver<Grupa>().List<Grupa>();

            foreach(Grupa grupa in grupe)
            {
                comboBox2.Items.Add(grupa);
            }

            s.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Student student = new Student();

            student.Ime     = textBox1.Text;
            student.SIme    = textBox2.Text;
            student.Prezime = textBox3.Text;
            try
            {
                student.BrIndeksa = Int32.Parse(textBox4.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Broj indeksa ne moze biti realan broj." + ex.Message);
            }
            student.SlusaPredmet = (Predmet) comboBox1.SelectedItem;
            student.PripadaGrupi = (Grupa)comboBox2.SelectedItem;

            s.Save(student);
            s.Flush();
            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
