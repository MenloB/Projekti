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
    public partial class EditRad : Form
    {
        public DTRad rad;

        public EditRad()
        {
            InitializeComponent();
        }

        public EditRad(DTRad rad)
        {
            this.rad = rad;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = rad.LiteraturaId.ToString();
            textBox2.Text = rad.RadNaziv;

            if (rad.RadFormat.Equals("PDF"))
                radioButton1.Checked = true;
            else if (rad.RadFormat.Equals("WORD"))
                radioButton2.Checked = true;
            else if (rad.RadFormat.Equals("POST-SCRIPT"))
                radioButton3.Checked = true;

            textBox4.Text = rad.RadKonferencija;
            textBox5.Text = rad.RadAdresa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Rad r = s.Load<Rad>(rad.LiteraturaId);

            r.Naziv        = textBox2.Text;

            if (radioButton1.Checked)
                r.Format = "PDF";
            else if (radioButton2.Checked)
                r.Format = "WORD";
            else if (radioButton3.Checked)
                r.Format = "POST-SCRIPT";
            else
                MessageBox.Show("Odaberite format.");

            r.Konferencija = textBox4.Text;
            r.Adresa       = textBox5.Text;

            s.Update(r);
            s.Flush();
            s.Close();
        }
    }
}
