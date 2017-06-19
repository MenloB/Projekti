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
    public partial class EditStudenta : Form
    {
        public DTStudent student;

        public EditStudenta()
        {
            InitializeComponent();
        }

        public EditStudenta(DTStudent student)
        {
            this.student = student;
            InitializeComponent();
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            textBox1.Text = student.StudentId.ToString();
            textBox2.Text = student.StudentIme;
            textBox3.Text = student.StudentSIme;
            textBox4.Text = student.StudentPrezime;
            textBox5.Text = student.StudentBrInd.ToString();
            textBox6.Text = student.StudentSmer;

            ISession s = DataLayer.GetSession();
            IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();

            foreach(Predmet predmet in predmeti)
            {
                comboBox1.Items.Add(predmet);
            }

            IList<Grupa> grupe = s.QueryOver<Grupa>().List<Grupa>();
            
            foreach(Grupa grupa in grupe)
            {
                comboBox2.Items.Add(grupa);
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
            Student stud = s.Load<Student>(student.StudentId);

            stud.Ime = textBox2.Text;
            stud.SIme = textBox3.Text;
            stud.Prezime = textBox4.Text;
            try
            {
                stud.BrIndeksa = Int32.Parse(textBox5.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            stud.Smer = textBox6.Text;

            stud.SlusaPredmet = (Predmet) comboBox1.SelectedItem;
            stud.PripadaGrupi = (Grupa)comboBox2.SelectedItem;

            s.Update(stud);
            s.Flush();
            s.Close();
        }
    }
}
