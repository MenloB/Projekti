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
using NHibernate.Linq;

namespace Source
{
    public partial class DodajClanak : Form
    {
        public DodajClanak()
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
            Clanak c = new Clanak();

            c.Naziv = textBox1.Text;
            c.ISSN = textBox2.Text;
            try
            {
                c.Godina = Int32.Parse(textBox3.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Godina mora biti ceo broj." + ex.Message);
            }

            c.NazivCasopisa = textBox4.Text;
            try
            {
                c.BrojCasopisa = Int32.Parse(textBox5.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Broj casopisa mora biti ceo broj." + ex.Message);
            }

            c.Tip = "CLANAK";
            c.Pisao = (Autor) comboBox1.SelectedItem;
            c.Projekti.Add((Projekat)comboBox2.SelectedItem);

            s.Save(c);
            s.Flush();
            s.Close();
            Close();
        }

        private void DodajClanak_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Autor> autori = s.QueryOver<Autor>().List<Autor>();
            IEnumerable<Projekat> projekti = from p in s.Query<Projekat>()
                                             where p.Tip == "TEORIJSKI"
                                             select p;

            foreach (Autor autor in autori)
            {
                comboBox1.Items.Add(autor);
            }

            foreach (Projekat projekat in projekti)
            {
                comboBox2.Items.Add(projekat);
            }

            s.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox) sender;
            Autor a = (Autor)comboBox1.SelectedItem;
            MessageBox.Show(a.Ime + " " + a.Prezime);
        }
    }
}
