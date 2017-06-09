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
using Source.Mapiranja;

namespace Source
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Grupa g = s.Load<Grupa>(3);

            MessageBox.Show(g.Naziv);
            

            s.Close();
        }
    }
}
