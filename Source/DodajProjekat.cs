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
    public partial class DodajProjekat : Form
    {
        public DodajProjekat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Projekat p = new Projekat();
            p.Naziv = textBox1.Text;
            p.Tip = "TEORIJSKI";
            Predmet pred = s.Load<Predmet>(37);

            p.predmet = pred;

            s.Save(p);
            s.Close();
        }
    }
}
