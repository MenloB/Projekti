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
    public partial class EditClanak : Form
    {
        public DTClanak clanak;

        public EditClanak()
        {
            InitializeComponent();
        }

        public EditClanak(DTClanak clanak)
        {
            this.clanak = clanak;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = clanak.LiteraturaId.ToString();
            textBox2.Text = clanak.CasopisNaziv;
            textBox3.Text = clanak.ClanakISSN;
            textBox4.Text = clanak.ClanakGodina.ToString();
            textBox5.Text = clanak.CasopisNaziv;
            textBox6.Text = clanak.CasopisBroj.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Clanak c = s.Load<Clanak>(clanak.LiteraturaId);

            c.Naziv = textBox2.Text;
            c.ISSN = textBox3.Text;
            try
            {
                c.Godina = Int32.Parse(textBox4.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            c.NazivCasopisa = textBox5.Text;
            try
            {
                c.BrojCasopisa = Int32.Parse(textBox6.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            s.Update(c);
            s.Flush();
            s.Close();
        }
    }
}
