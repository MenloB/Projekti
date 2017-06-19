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
    public partial class EditWebStranicu : Form
    {
        public DTWebStranice stranice;

        public EditWebStranicu()
        {
            InitializeComponent();
        }

        public EditWebStranicu(DTWebStranice stranice)
        {
            this.stranice = stranice;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = stranice.WebStraniceId.ToString();
            textBox2.Text = stranice.WebLink;

            ISession s = DataLayer.GetSession();
            IList<Projekat> projekti = s.QueryOver<Projekat>().List<Projekat>();

            foreach(Projekat projekat in projekti)
            {
                comboBox1.Items.Add(projekat);
            }

            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            WebStranice stranica = s.Load<WebStranice>(stranice.WebStraniceId);

            stranica.Link = textBox2.Text;
            stranica.PripadaProjektu = (Projekat)comboBox1.SelectedItem;

            s.Update(stranica);
            s.Flush();
            s.Close();
        }
    }
}
