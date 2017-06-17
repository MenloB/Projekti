using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source.Entiteti;
using NHibernate;

namespace Source
{
    public partial class EditProjekat : Form
    {
        public DTProjekat proj;

        public EditProjekat()
        {
            InitializeComponent();
        }

        public EditProjekat(DTProjekat proj)
        {
            this.proj = proj;
            InitializeComponent();
            LoadInfos();
        }

        private void EditProjekat_Load(object sender, EventArgs e)
        {
            textBox1.Text = proj.ProjekatId.ToString();
            textBox2.Text = proj.ProjekatNaziv;

            if (proj.ProjekatTip.Equals("TEORIJSKI"))
                checkBox1.Checked = true;
            if (proj.ProjekatGrupni.Equals("Da"))
                checkBox2.Checked = true;
            if (proj.ProjekatZavrsen.Equals("Da"))
                checkBox3.Checked = true;

        }

        private void LoadInfos()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession _session = DataLayer.GetSession();
            Projekat p = _session.Load<Projekat>(proj.ProjekatId);

            p.Naziv = textBox2.Text;
            if (checkBox1.Checked)
                p.Tip = "TEORIJSKI";

            if (checkBox2.Checked)
                p.Grupni = "Da";

            if (checkBox3.Checked)
                p.Zavrsen = "Da";

            _session.Update(p);
            _session.Flush();
            _session.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            proj.ProjekatNaziv = textBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                proj.ProjekatTip = "TEORIJSKI";
            else
                proj.ProjekatTip = "PRAKTICNI";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                proj.ProjekatGrupni = "Da";
            else
                proj.ProjekatGrupni = "Ne";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                proj.ProjekatZavrsen = "Da";
            else
                proj.ProjekatZavrsen = "Ne";
        }
    }
}
