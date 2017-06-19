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
    public partial class EditAutora : Form
    {
        public DTAutor autor;

        public EditAutora()
        {
            InitializeComponent();
        }

        public EditAutora(DTAutor autor)
        {
            this.autor = autor;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = autor.AutorId.ToString();
            textBox2.Text = autor.AutorIme;
            textBox3.Text = autor.AutorSIme;
            textBox4.Text = autor.AutorPrezime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Autor aut = s.Load<Autor>(autor.AutorId);

            aut.Ime = textBox2.Text;
            aut.SIme = textBox3.Text;
            aut.Prezime = textBox4.Text;

            s.Update(aut);
            s.Flush();
            s.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
