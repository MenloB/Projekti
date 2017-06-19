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
    public partial class EditGrupu : Form
    {
        public DTGrupa grupa;

        public EditGrupu()
        {
            InitializeComponent();
        }

        public EditGrupu(DTGrupa grupa)
        {
            this.grupa = grupa;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = grupa.GrupaID.ToString();
            textBox2.Text = grupa.GrupaNaziv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Grupa g = s.Load<Grupa>(grupa.GrupaID);

            g.Naziv = textBox2.Text;

            s.Update(g);
            s.Flush();
            s.Close();
        }
    }
}
