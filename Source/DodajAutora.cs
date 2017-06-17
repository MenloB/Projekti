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
using Source.Common;
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
            Methods.closeApplication();
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
        }
    }
}
