using System;
using System.Windows.Forms;
using NHibernate;
using Source.Entiteti;
using System.Collections.Generic;

namespace Source
{
    public partial class Form1 : Form
    {
        //For switch case structure to tell forms which object it is and
        //what table needs to be accessed
        private int LastLoadedData { get; set; }
        private int PomocniId { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        //Helping method for closing the application down
        //I realized that I needed this because I have several methods
        //That do the same thing so why not have just one that does what I need?
        private bool closeApplication()
        {
            Application.Exit();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(this.LastLoadedData)
            {
                case 0:
                    MessageBox.Show("Projekti Loaded");
                    break;
                case 1:
                    MessageBox.Show("Predmeti Loaded");
                    break;
                case 2:
                    MessageBox.Show("Profesori Loaded");
                    break;
                case 3:
                    MessageBox.Show("Clanci Loaded");
                    break;
                case 4:
                    MessageBox.Show("Radovi Loaded");
                    break;
                case 5:
                    MessageBox.Show("Knjige Loaded");
                    break;
                case 6:
                    MessageBox.Show("Autori Loaded");
                    break;
                case 7:
                    MessageBox.Show("Studenti Loaded");
                    break;
                case 8:
                    //this is where I need to have some kind of local list
                    //so I can list every project that Group works on
                    MessageBox.Show("Grupe Loaded");
                    break;
                case 9:
                    MessageBox.Show("Izvestaji Loaded");
                    break;
                case 10:
                    MessageBox.Show("Web Stranice Loaded");
                    break;
            }

            //ListViewItem lvi = listProjekti.SelectedItems[0];
            //string id = lvi.SubItems[6].Text;
            //MessageBox.Show(id);
            //PrikaziPredmet prikaziPredmet = new PrikaziPredmet(Int32.Parse(id));
            //prikaziPredmet.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Projects loaded
            this.LastLoadedData = 0;
            ISession s = DataLayer.GetSession();
            IList<Projekat> projekti = s.QueryOver<Projekat>().List<Projekat>();
            ListViewItem listViewItem;
            listProjekti.Clear();
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Naziv");
            listProjekti.Columns.Add("Godina");
            listProjekti.Columns.Add("Zavrsen");
            listProjekti.Columns.Add("Tip");
            listProjekti.Columns.Add("Grupni");
            listProjekti.Columns.Add("Predmet");

            foreach (Projekat projekat in projekti)
            {
                listViewItem = new ListViewItem(projekat.Id.ToString());
                listViewItem.SubItems.Add(projekat.Naziv);
                listViewItem.SubItems.Add(projekat.Godina.ToString());
                listViewItem.SubItems.Add(projekat.Zavrsen);
                listViewItem.SubItems.Add(projekat.Tip);
                listViewItem.SubItems.Add(projekat.Grupni);
                listViewItem.SubItems.Add(projekat.predmet.Sifra.ToString());
                listProjekti.Items.Add(listViewItem);
            }

            s.Close();
        }

        //Menu Strip buttons
        //Close button
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeApplication();
        }

        //Ucitaj buttons
        //Ucitaj > predmete
        private void predmeteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Predmeti loaded
            this.LastLoadedData = 1;
            ISession s = DataLayer.GetSession();
            IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();
            listProjekti.Clear();
            listProjekti.Columns.Add("Sifra");
            listProjekti.Columns.Add("Naziv");
            listProjekti.Columns.Add("Katedra");
            listProjekti.Columns.Add("Semestar");
            listProjekti.Columns.Add("Profesor");
            ListViewItem lvi;

            foreach(Predmet predmet in predmeti)
            {
                lvi = new ListViewItem(predmet.Sifra.ToString());
                lvi.SubItems.Add(predmet.Naziv);
                lvi.SubItems.Add(predmet.Katedra);
                lvi.SubItems.Add(predmet.Semestar);
                lvi.SubItems.Add(predmet.Profesor.Ime + " " + predmet.Profesor.Prezime);
                listProjekti.Items.Add(lvi);
            }
            s.Close();
        }

        //List projects again (I tried to avoid duplicating my code so I called Form1_Load)
        //not great thing to do if Form_Load method does more than just a loading but 
        // I'm pretty sure I will not have this Form doing something more than just load projects
        //Ucitaj > projekte
        private void projekteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listProjekti.Items.Clear();
            Form1_Load(sender, e);
        }

        //Context Menu which fires with the right click
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeApplication();
        }

        //--------------------------------------------------
        private void nastavnikeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Professors loaded
            this.LastLoadedData = 2;
            ISession s = DataLayer.GetSession();
            IList<Nastavnik> nastavnici = s.QueryOver<Nastavnik>()
                                            .List<Nastavnik>();
            listProjekti.Clear();
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Ime");
            listProjekti.Columns.Add("S. Ime");
            listProjekti.Columns.Add("Prezime");
            ListViewItem lvi;

            foreach(Nastavnik nastavnik in nastavnici)
            {
                lvi = new ListViewItem(nastavnik.Id.ToString());
                lvi.SubItems.Add(nastavnik.Ime);
                lvi.SubItems.Add(nastavnik.SIme);
                lvi.SubItems.Add(nastavnik.Prezime);
                listProjekti.Items.Add(lvi);
            }

            s.Close();
        }

        private void literaturuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        //nista bez bar jedne gramaticke greske, just to spice things up ...
        private void clankoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clanak loaded
            this.LastLoadedData = 3;
            ISession s = DataLayer.GetSession();
            IList<Clanak> clanci = s.QueryOver<Clanak>().List<Clanak>();
            listProjekti.Clear();
            ListViewItem lvi;
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Naslov");
            listProjekti.Columns.Add("Naziv Casopisa");
            listProjekti.Columns.Add("ISSN");

            foreach (Clanak clanak in clanci)
            {
                lvi = new ListViewItem(clanak.Id.ToString());
                lvi.SubItems.Add(clanak.Naziv);
                lvi.SubItems.Add(clanak.NazivCasopisa);
                lvi.SubItems.Add(clanak.ISSN);
                listProjekti.Items.Add(lvi);
            }

            s.Close();

        }

        private void radoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Radovi loaded 
            this.LastLoadedData = 4;
            ISession s = DataLayer.GetSession();
            IList<Rad> radovi = s.QueryOver<Rad>().List<Rad>();
            listProjekti.Clear();
            ListViewItem lvi;
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Naslov");
            listProjekti.Columns.Add("Format");
            listProjekti.Columns.Add("Konferencija");
            listProjekti.Columns.Add("Veb adresa");

            foreach (Rad rad in radovi)
            {
                lvi = new ListViewItem(rad.Id.ToString());
                lvi.SubItems.Add(rad.Naziv);
                lvi.SubItems.Add(rad.Format);
                lvi.SubItems.Add(rad.Konferencija);
                lvi.SubItems.Add(rad.Adresa);
                listProjekti.Items.Add(lvi);
            }

            s.Close();
        }

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Books loaded
            this.LastLoadedData = 5;
            ISession s = DataLayer.GetSession();
            IList<Knjiga> knjige = s.QueryOver<Knjiga>().List<Knjiga>();
            ListViewItem lvi;
            listProjekti.Clear();
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Naslov");
            listProjekti.Columns.Add("Izdavac");
            listProjekti.Columns.Add("ISBN");

            foreach (Knjiga knjiga in knjige)
            {
                lvi = new ListViewItem(knjiga.Id.ToString());
                lvi.SubItems.Add(knjiga.Naslov);
                lvi.SubItems.Add(knjiga.Izdavac);
                lvi.SubItems.Add(knjiga.ISBN);
                listProjekti.Items.Add(lvi);
            }

            s.Close();
        }

        private void autoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Authors loaded
            this.LastLoadedData = 6;
            ISession s = DataLayer.GetSession();
            IList<Autor> autori = s.QueryOver<Autor>().List<Autor>();
            ListViewItem lvi;
            listProjekti.Clear();
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Ime");
            listProjekti.Columns.Add("Srednje Ime");
            listProjekti.Columns.Add("Prezime");

            foreach (Autor autor in autori)
            {
                lvi = new ListViewItem(autor.Id.ToString());
                lvi.SubItems.Add(autor.Ime);
                lvi.SubItems.Add(autor.SIme);
                lvi.SubItems.Add(autor.Prezime);
                listProjekti.Items.Add(lvi);
            }
            s.Close();
        }

        private void studenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LastLoadedData = 7;
            ISession s = DataLayer.GetSession();
            IList<Student> studenti = s.QueryOver<Student>().List<Student>();
            ListViewItem lvi;
            listProjekti.Clear();
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Ime");
            listProjekti.Columns.Add("Srednje Ime");
            listProjekti.Columns.Add("Prezime");
            listProjekti.Columns.Add("Broj Indeksa");
            listProjekti.Columns.Add("Smer");
            listProjekti.Columns.Add("Predmet");
            listProjekti.Columns.Add("Grupa");

            foreach(Student student in studenti)
            {
                lvi = new ListViewItem(student.Id.ToString());
                lvi.SubItems.Add(student.Ime);
                lvi.SubItems.Add(student.SIme);
                lvi.SubItems.Add(student.Prezime);
                lvi.SubItems.Add(student.BrIndeksa.ToString());
                lvi.SubItems.Add(student.Smer);
                lvi.SubItems.Add(student.SlusaPredmet.Sifra.ToString());
                lvi.SubItems.Add(student.PripadaGrupi.Id.ToString());
                listProjekti.Items.Add(lvi);
            }

            s.Close();

        }

        private void grupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LastLoadedData = 8;
            ISession s = DataLayer.GetSession();
            IList<Grupa> grupe = s.QueryOver<Grupa>().List<Grupa>();
            ListViewItem lvi;
            listProjekti.Clear();
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Naziv");
            listProjekti.Columns.Add("Broj Projekata");
            
            foreach(Grupa grupa in grupe)
            {
                lvi = new ListViewItem(grupa.Id.ToString());
                lvi.SubItems.Add(grupa.Naziv);
                lvi.SubItems.Add(grupa.Projekti.Count.ToString());
                listProjekti.Items.Add(lvi);
            }

            s.Close();
        }

        private void izvestajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LastLoadedData = 9;
            ISession s = DataLayer.GetSession();
            IList<Izvestaj> izvestaji = s.QueryOver<Izvestaj>().List<Izvestaj>();

            if(izvestaji.Count == 0)
            {
                MessageBox.Show("Nema izvestaja");
            } else
            {
                MessageBox.Show("Ima izvestaja");
            }

            foreach(Izvestaj izvestaj in izvestaji)
            {
                MessageBox.Show(izvestaj.Opis);
            }

            s.Close();
        }

        private void webStraniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LastLoadedData = 10;
            ISession s = DataLayer.GetSession();
            IList<WebStranice> stranice = s.QueryOver<WebStranice>().List<WebStranice>();
            ListViewItem lvi;
            listProjekti.Clear();
            listProjekti.Columns.Add("ID");
            listProjekti.Columns.Add("Link");
            listProjekti.Columns.Add("Projekat");

            foreach(WebStranice webstranica in stranice)
            {
                lvi = new ListViewItem(webstranica.Id.ToString());
                lvi.SubItems.Add(webstranica.Link);
                lvi.SubItems.Add(webstranica.PripadaProjektu.Naziv);
                listProjekti.Items.Add(lvi);
            }

            s.IsDirty();
            s.Flush();
            s.Close();
        }
    }
}
