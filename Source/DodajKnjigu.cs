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
    public partial class DodajKnjigu : Form
    {
        public DodajKnjigu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Knjiga k = new Knjiga();

            k.ISBN = textBox1.Text;
            k.Naslov = textBox2.Text;
            k.Izdavac = textBox3.Text;
            try
            {
                k.Godina = Int32.Parse(textBox4.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Godina mora biti ceo broj" + ex.Message);
            }
            k.Tip = "KNJIGA";
            k.Pisao = (Autor)comboBox1.SelectedItem;

            s.Save(k);
            s.Flush();
            s.Close();
        }

        private void DodajKnjigu_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Autor> autori = s.QueryOver<Autor>().List<Autor>();

            foreach(Autor autor in autori)
            {
                comboBox1.Items.Add(autor);
            }

            s.Close();
        }
    }
}
