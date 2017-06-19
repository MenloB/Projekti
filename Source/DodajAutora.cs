using System;
using System.Windows.Forms;
using NHibernate;
using Source.Entiteti;

namespace Source
{
    public partial class DodajAutora : Form
    {
        public DodajAutora()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s    = DataLayer.GetSession();
            Autor autor   = new Autor();
            autor.Ime     = textBox1.Text;
            autor.SIme    = textBox2.Text;
            autor.Prezime = textBox3.Text;

            s.Save(autor);
            s.Close();

            Close();
        }
    }
}
