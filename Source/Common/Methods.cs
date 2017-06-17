using System.Windows.Forms;
using NHibernate;
using System.Collections.Generic;
using Source.Entiteti;
using System;

namespace Source.Common
{
    public class Methods
    {
        //Helping method for closing the application down
        //I realized that I needed this because I have several methods
        //That do the same thing so why not have just one that does what I need?
        public static bool closeApplication()
        {
            Application.Exit();
            return true;
        }

        public static IList<Projekat> LoadProjekti()
        {
            ISession s = DataLayer.GetSession();
            IList<Projekat> projekti = s.QueryOver<Projekat>().List<Projekat>();
            s.Close();
            return projekti;
        }

        public static void SetUpLvPredmet()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("Sifra");
            Form1.lv.Columns.Add("Naziv");
            Form1.lv.Columns.Add("Katedra");
            Form1.lv.Columns.Add("Semestar");
            Form1.lv.Columns.Add("Profesor");
        }

        public static void AddItemsToLvPredmet(ListViewItem lvi, Predmet predmet)
        {
            lvi.SubItems.Add(predmet.Naziv);
            lvi.SubItems.Add(predmet.Katedra);
            lvi.SubItems.Add(predmet.Semestar);
            lvi.SubItems.Add(predmet.Profesor.Ime + " " + predmet.Profesor.Prezime);
            Form1.lv.Items.Add(lvi);
        }

        public static void SetUpLvNastavnik()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("ID");
            Form1.lv.Columns.Add("Ime");
            Form1.lv.Columns.Add("S. Ime");
            Form1.lv.Columns.Add("Prezime");
        }

        public static void AddItemsToLvNastavnik(ListViewItem lvi, Nastavnik nastavnik)
        {
            lvi.SubItems.Add(nastavnik.Ime);
            lvi.SubItems.Add(nastavnik.SIme);
            lvi.SubItems.Add(nastavnik.Prezime);
            Form1.lv.Items.Add(lvi);
        }

        public static void SetUpLvClanak()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("ID");
            Form1.lv.Columns.Add("Naslov");
            Form1.lv.Columns.Add("Naziv Casopisa");
            Form1.lv.Columns.Add("ISSN");
        }

        public static void AddItemsToLvClanak(ListViewItem lvi, Clanak clanak)
        {
            lvi.SubItems.Add(clanak.Naziv);
            lvi.SubItems.Add(clanak.NazivCasopisa);
            lvi.SubItems.Add(clanak.ISSN);
            Form1.lv.Items.Add(lvi);
        }

        public static void SetUpLvRad()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("ID");
            Form1.lv.Columns.Add("Naslov");
            Form1.lv.Columns.Add("Format");
            Form1.lv.Columns.Add("Konferencija");
            Form1.lv.Columns.Add("Veb adresa");
        }

        public static void AddItemsToLvRad(ListViewItem item, Rad rad)
        {
            item.SubItems.Add(rad.Naziv);
            item.SubItems.Add(rad.Format);
            item.SubItems.Add(rad.Konferencija);
            item.SubItems.Add(rad.Adresa);
            Form1.lv.Items.Add(item);
        }

        public static void SetUpLvKnjiga()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("ID");
            Form1.lv.Columns.Add("Naslov");
            Form1.lv.Columns.Add("Izdavac");
            Form1.lv.Columns.Add("ISBN");
        }

        public static void AddItemsToLvKnjiga(ListViewItem lvi, Knjiga knjiga)
        {
            lvi.SubItems.Add(knjiga.Naslov);
            lvi.SubItems.Add(knjiga.Izdavac);
            lvi.SubItems.Add(knjiga.ISBN);
            Form1.lv.Items.Add(lvi);
        }

        public static void SetUpLvAutor()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("ID");
            Form1.lv.Columns.Add("Ime");
            Form1.lv.Columns.Add("Srednje Ime");
            Form1.lv.Columns.Add("Prezime");
        }

        public static void AddItemsToLvAutor(ListViewItem lvi, Autor autor)
        {
            lvi.SubItems.Add(autor.Ime);
            lvi.SubItems.Add(autor.SIme);
            lvi.SubItems.Add(autor.Prezime);
            Form1.lv.Items.Add(lvi);
        }

        public static void SetUpLvStudent()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("ID");
            Form1.lv.Columns.Add("Ime");
            Form1.lv.Columns.Add("Srednje Ime");
            Form1.lv.Columns.Add("Prezime");
            Form1.lv.Columns.Add("Broj Indeksa");
            Form1.lv.Columns.Add("Smer");
            Form1.lv.Columns.Add("Predmet");
            Form1.lv.Columns.Add("Grupa");
        }

        public static void AddItemsToStudent(ListViewItem lvi, Student student)
        {
            lvi.SubItems.Add(student.Ime);
            lvi.SubItems.Add(student.SIme);
            lvi.SubItems.Add(student.Prezime);
            lvi.SubItems.Add(student.BrIndeksa.ToString());
            lvi.SubItems.Add(student.Smer);
            lvi.SubItems.Add(student.SlusaPredmet.Sifra.ToString());
            lvi.SubItems.Add(student.PripadaGrupi.Id.ToString());
            Form1.lv.Items.Add(lvi);
        }

        public static void SetUpLvGrupa()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("ID");
            Form1.lv.Columns.Add("Naziv");
            Form1.lv.Columns.Add("Broj Projekata");
        }

        public static void AddItemsToLvGrupa(ListViewItem lvi, Grupa grupa)
        {
            lvi.SubItems.Add(grupa.Naziv);
            lvi.SubItems.Add(grupa.Projekti.Count.ToString());
            Form1.lv.Items.Add(lvi);
        }

        public static void SetUpLvProjekat()
        {
            Form1.lv.Clear();
            Form1.lv.Columns.Add("ID");
            Form1.lv.Columns.Add("Naziv");
            Form1.lv.Columns.Add("Godina");
            Form1.lv.Columns.Add("Zavrsen");
            Form1.lv.Columns.Add("Tip");
            Form1.lv.Columns.Add("Grupni");
            Form1.lv.Columns.Add("Predmet");
        }

        public static void AddItemsToLvProjekat(ListViewItem listViewItem, Projekat projekat)
        {
            listViewItem.SubItems.Add(projekat.Naziv);
            listViewItem.SubItems.Add(projekat.Godina.ToString());
            listViewItem.SubItems.Add(projekat.Zavrsen);
            listViewItem.SubItems.Add(projekat.Tip);
            listViewItem.SubItems.Add(projekat.Grupni);
            listViewItem.SubItems.Add(projekat.predmet.Sifra.ToString());
            Form1.lv.Items.Add(listViewItem);
        }
    }
}
