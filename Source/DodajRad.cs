using System;
using System.Windows.Forms;
using NHibernate;
using Source.Entiteti;
using System.Collections.Generic;

namespace Source
{
    public partial class DodajRad : Form
    {
        public int predmet;

        public DodajRad()
        {
            InitializeComponent();
        }

        public DodajRad(int Id)
        {
            this.predmet = Id;
            InitializeComponent();
        }

        private void PrikaziPredmete_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Autor> autori = s.QueryOver<Autor>().List<Autor>();

            foreach(Autor autor in autori)
            {
                comboBox1.Items.Add(autor);
            }

            s.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Rad rad = new Rad();

            rad.Naziv = txtNaziv.Text;
            rad.Konferencija = txtKonferencija.Text;
            rad.Adresa = txtAdresa.Text;
            rad.Tip = "RAD";
            rad.Pisao = (Autor) comboBox1.SelectedItem;
            MessageBox.Show(rad.Pisao.Ime);
            if (radioButton1.Checked == true)
                rad.Format = "PDF";
            else if (radioButton2.Checked == true)
                rad.Format = "WORD";
            else
                rad.Format = "POST-SCRIPT";

            s.SaveOrUpdate(rad);
            s.Flush();
            s.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Autor autor = comboBox1.SelectedItem as Autor;
            comboBox1.Text = autor.Ime + " " + autor.Prezime;
        }
    }
}
