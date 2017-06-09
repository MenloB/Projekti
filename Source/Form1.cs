using System;
using System.Windows.Forms;
using NHibernate;
using Source.Entiteti;
using System.Collections.Generic;

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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Projekat> projekti = s.QueryOver<Projekat>().List<Projekat>();
            ListViewItem listViewItem;
            
            foreach(Projekat projekat in projekti)
            {
                listViewItem = new ListViewItem(projekat.Id.ToString());
                listViewItem.SubItems.Add(projekat.Naziv);
                listViewItem.SubItems.Add(projekat.Godina.ToString());
                listViewItem.SubItems.Add(projekat.Zavrsen);
                listViewItem.SubItems.Add(projekat.Tip);
                listViewItem.SubItems.Add(projekat.Grupni);
                listViewItem.SubItems.Add(projekat.predmet.Naziv);
                listProjekti.Items.Add(listViewItem);
            }

            s.Close();
        }
    }
}
