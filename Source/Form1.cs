using System;
using System.Windows.Forms;
using NHibernate;
using Source.Entiteti;



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
            Nastavnik n = s.Load<Nastavnik>(3);

            MessageBox.Show(n.Ime);

            foreach(Predmet p in n.Predmeti)
            {
                MessageBox.Show(p.Naziv);
            }
            

            s.Close();
        }
    }
}
