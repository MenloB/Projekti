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
    public partial class EditKnjigu : Form
    {
        public DTKnjiga knjiga;

        public EditKnjigu()
        {
            InitializeComponent();
        }

        public EditKnjigu(DTKnjiga knjiga)
        {
            this.knjiga = knjiga;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = knjiga.LiteraturaId.ToString();
            textBox2.Text = knjiga.KnjigaISBN;
            textBox3.Text = knjiga.KnjigaNaslov;
            textBox4.Text = knjiga.KnjigaIzdavac;
            textBox5.Text = knjiga.KnjigaGodina.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Knjiga k = s.Load<Knjiga>(knjiga.LiteraturaId);

            k.ISBN = textBox2.Text;
            k.Naslov = textBox3.Text;
            k.Izdavac = textBox4.Text;
            try
            {
                k.Godina = Int32.Parse(textBox5.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            s.Update(k);
            s.Flush();
            s.Close();
        }
    }
}
