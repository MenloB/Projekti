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

        public static ListView lv;

        public Form1()
        {
            InitializeComponent();
            lv = listProjekti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listProjekti.SelectedItems.Count > 0)
            {
                switch (this.LastLoadedData)
                {
                    case 0:
                        MessageBox.Show(this.LastLoadedData.ToString());
                        //MessageBox.Show("Projekti Loaded");
                        int idProjekta = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                        this.PomocniId = idProjekta;
                        DTProjekat proj = DTOManager.GetProjekat(idProjekta);
                        EditProjekat ep = new EditProjekat(proj);
                        if(ep.ShowDialog() == DialogResult.OK)
                        {
                            DTOManager.UpdateProjekat(ep.proj);
                            IzmeniPodatke();
                        }
                        break;
                    case 1:
                        MessageBox.Show(this.LastLoadedData.ToString());
                        //MessageBox.Show("Predmeti Loaded");
                        int idPredmeta = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                        PomocniId = idPredmeta;
                        DTPredmet pred = DTOManager.GetPredmet(idPredmeta);
                        EditPredmet editPredmetForm = new EditPredmet(pred);
                        if(editPredmetForm.ShowDialog() == DialogResult.OK)
                        {
                            DTOManager.UpdatePredmet(editPredmetForm.predmet);
                            IzmeniPodatkePredmet();
                        }
                        break;
                    case 2:
                        MessageBox.Show("Profesori Loaded");
                        int idNastavnika = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                        PomocniId = idNastavnika;
                        DTNastavnik nastavnik = DTOManager.GetNastavnik(idNastavnika);
                        EditNastavnika editNastavnikaForm = new EditNastavnika(nastavnik);
                        if(editNastavnikaForm.ShowDialog() == DialogResult.OK)
                        {
                            DTOManager.UpdateNastavnik(editNastavnikaForm.nastavnik);
                            IzmeniPodatkeNastavnik();
                        }
                        break;
                    case 3:
                        MessageBox.Show("Clanci Loaded");
                        try
                        {
                            int idClanak = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                            PomocniId = idClanak;
                            DTClanak clanak = DTOManager.GetClanak(idClanak);
                            EditClanak editClanakForm = new EditClanak(clanak);
                            if(editClanakForm.ShowDialog() == DialogResult.OK)
                            {
                                DTOManager.UpdateClanak(editClanakForm.clanak);
                                IzmeniPodatkeClanak();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 4:
                        MessageBox.Show("Radovi Loaded");
                        try
                        {
                            int idRada = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                            PomocniId = idRada;
                            DTRad rad = DTOManager.GetRad(idRada);
                            EditRad editRadForm = new EditRad(rad);
                            if(editRadForm.ShowDialog() == DialogResult.OK)
                            {
                                DTOManager.UpdateRad(editRadForm.rad);
                                IzmeniPodatkeRad();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 5:
                        MessageBox.Show("Knjige Loaded");
                        try
                        {
                            int idKnjige = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                            PomocniId = idKnjige;
                            DTKnjiga knjiga = DTOManager.GetKnjiga(idKnjige);
                            EditKnjigu editKnjiguForm = new EditKnjigu(knjiga);
                            if(editKnjiguForm.ShowDialog() == DialogResult.OK)
                            {
                                DTOManager.UpdateKnjiga(editKnjiguForm.knjiga);
                                IzmeniPodatkeKnjiga();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 6:
                        MessageBox.Show("Autori Loaded");
                        try
                        {
                            int idAutora = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                            PomocniId = idAutora;
                            DTAutor autor = DTOManager.GetAutor(idAutora);
                            EditAutora editAutoraForm = new EditAutora(autor);
                            if(editAutoraForm.ShowDialog() == DialogResult.OK)
                            {
                                DTOManager.UpdateAutor(editAutoraForm.autor);
                                IzmeniPodatkeAutor();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 7:
                        MessageBox.Show("Studenti Loaded");
                        try
                        {
                            int idStudenta = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                            PomocniId = idStudenta;
                            DTStudent student = DTOManager.GetStudent(idStudenta);
                            EditStudenta editStudentaForm = new EditStudenta(student);
                            if(editStudentaForm.ShowDialog() == DialogResult.OK)
                            {
                                DTOManager.UpdateStudenta(editStudentaForm.student);
                                IzmeniPodatkeStudent();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 8:
                        //this is where I need to have some kind of local list
                        //so I can list every project that Group works on
                        MessageBox.Show("Grupe Loaded");
                        try
                        {
                            int idGrupa = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                            PomocniId = idGrupa;
                            DTGrupa grupa = DTOManager.GetGrupa(idGrupa);
                            EditGrupu editGrupaForm = new EditGrupu(grupa);
                            if(editGrupaForm.ShowDialog() == DialogResult.OK)
                            {
                                DTOManager.UpdateGrupa(editGrupaForm.grupa);
                                IzmeniPodatkeGrupa();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 9:
                        MessageBox.Show("Izvestaji Loaded");
                        try
                        {
                            int idIzvestaja = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                            DTIzvestaj izvestaj = DTOManager.GetIzvestaj(idIzvestaja);
                            EditIzvestaj editIzvestaj = new EditIzvestaj(izvestaj);
                            if (editIzvestaj.ShowDialog() == DialogResult.OK)
                            {
                                DTOManager.UpdateIzvestaj(editIzvestaj.izvestaj);
                                IzmeniPodatkeWebStranica();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 10:
                        MessageBox.Show("Web Stranice Loaded");
                        try
                        {
                            int idWebStranice = Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text);
                            DTWebStranice stranice = DTOManager.GetStranicu(idWebStranice);
                            EditWebStranicu editWebStranicuForm = new EditWebStranicu(stranice);
                            if (editWebStranicuForm.ShowDialog() == DialogResult.OK)
                            {
                                DTOManager.UpdateWebStranicu(editWebStranicuForm.stranice);
                                IzmeniPodatkeWebStranica();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                }
            }
            else if (listProjekti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molim Vas obelezite bar jedan item.");
                return;
            }

            //ListViewItem lvi = listProjekti.SelectedItems[0];
            //string id = lvi.SubItems[6].Text;
            //MessageBox.Show(id);
            //PrikaziPredmet prikaziPredmet = new PrikaziPredmet(Int32.Parse(id));
            //prikaziPredmet.Show();
        }

        private void IzmeniPodatkeWebStranica()
        {
            throw new NotImplementedException();
        }

        private void IzmeniPodatkeGrupa()
        {
            throw new NotImplementedException();
        }

        private void IzmeniPodatkeStudent()
        {
            throw new NotImplementedException();
        }

        private void IzmeniPodatkeAutor()
        {
            throw new NotImplementedException();
        }

        private void IzmeniPodatkeKnjiga()
        {
            throw new NotImplementedException();
        }

        private void IzmeniPodatkeRad()
        {
            throw new NotImplementedException();
        }

        private void IzmeniPodatkeClanak()
        {
            throw new NotImplementedException();
        }

        private void IzmeniPodatkeNastavnik()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Projects loaded
            this.LastLoadedData = 0;
            LoadProjekteInfos();
        }

        //Menu Strip buttons
        //Close button
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common.Methods.closeApplication();
        }

        //Ucitaj buttons
        //Ucitaj > predmete
        private void predmeteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Predmeti loaded
            this.LastLoadedData = 1;
            ISession s = DataLayer.GetSession();
            IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();
            
            //Pomocna funkcija da setuje listu za predmet
            Common.Methods.SetUpLvPredmet();

            ListViewItem lvi;

            foreach(Predmet predmet in predmeti)
            {
                lvi = new ListViewItem(predmet.Sifra.ToString());

                //Pomocna funkcija da setuje i doda novi listviewitem u listview
                Common.Methods.AddItemsToLvPredmet(lvi, predmet);
            }

            listProjekti = Form1.lv;
            s.Close();
        }

        //List projects again (I tried to avoid duplicating my code so I called Form1_Load)
        //not great thing to do if Form_Load method does more than just a loading but 
        // I'm pretty sure I will not have this Form doing something more than just load projects
        //Ucitaj > projekte
        private void projekteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LastLoadedData = 0;
            LoadProjekteInfos();
        }

        //Context Menu which fires with the right click
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.Methods.closeApplication();
        }

        //--------------------------------------------------
        private void nastavnikeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Professors loaded
            this.LastLoadedData = 2;
            ISession s = DataLayer.GetSession();
            IList<Nastavnik> nastavnici = s.QueryOver<Nastavnik>().List<Nastavnik>();

            Common.Methods.SetUpLvNastavnik();

            ListViewItem lvi;

            foreach(Nastavnik nastavnik in nastavnici)
            {
                lvi = new ListViewItem(nastavnik.Id.ToString());
                Common.Methods.AddItemsToLvNastavnik(lvi, nastavnik);
            }

            listProjekti = Form1.lv;
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

            Common.Methods.SetUpLvClanak();

            ListViewItem lvi;

            foreach (Clanak clanak in clanci)
            {
                lvi = new ListViewItem(clanak.Id.ToString());

                Common.Methods.AddItemsToLvClanak(lvi, clanak);
            }


            listProjekti = Form1.lv;
            s.Close();

        }

        private void radoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Radovi loaded 
            this.LastLoadedData = 4;
            ISession s = DataLayer.GetSession();
            IList<Rad> radovi = s.QueryOver<Rad>().List<Rad>();
            
            ListViewItem lvi;

            Common.Methods.SetUpLvRad();
            
            foreach (Rad rad in radovi)
            {
                lvi = new ListViewItem(rad.Id.ToString());

                Common.Methods.AddItemsToLvRad(lvi, rad);
            }

            listProjekti = Form1.lv;
            s.Close();
        }

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Books loaded
            this.LastLoadedData = 5;
            ISession s = DataLayer.GetSession();
            IList<Knjiga> knjige = s.QueryOver<Knjiga>().List<Knjiga>();
            ListViewItem lvi;

            Common.Methods.SetUpLvKnjiga();

            foreach (Knjiga knjiga in knjige)
            {
                lvi = new ListViewItem(knjiga.Id.ToString());

                Common.Methods.AddItemsToLvKnjiga(lvi, knjiga);
            }

            listProjekti = lv;
            s.Close();
        }

        private void autoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Authors loaded
            this.LastLoadedData = 6;
            ISession s = DataLayer.GetSession();
            IList<Autor> autori = s.QueryOver<Autor>().List<Autor>();
            ListViewItem lvi;

            Common.Methods.SetUpLvAutor();

            foreach (Autor autor in autori)
            {
                lvi = new ListViewItem(autor.Id.ToString());

                Common.Methods.AddItemsToLvAutor(lvi, autor);
            }
            
            s.Close();
        }

        private void studenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LastLoadedData = 7;
            ISession s = DataLayer.GetSession();
            IList<Student> studenti = s.QueryOver<Student>().List<Student>();
            ListViewItem lvi;

            Common.Methods.SetUpLvStudent();

            foreach(Student student in studenti)
            {
                lvi = new ListViewItem(student.Id.ToString());

                Common.Methods.AddItemsToStudent(lvi, student);
            }

            listProjekti = lv;
            s.Close();

        }

        private void grupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LastLoadedData = 8;
            ISession s = DataLayer.GetSession();
            IList<Grupa> grupe = s.QueryOver<Grupa>().List<Grupa>();
            ListViewItem lvi;

            Common.Methods.SetUpLvGrupa();
            
            foreach(Grupa grupa in grupe)
            {
                lvi = new ListViewItem(grupa.Id.ToString());

                Common.Methods.AddItemsToLvGrupa(lvi, grupa);
            }

            listProjekti = lv;
            s.Close();
        }

        private void izvestajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LastLoadedData = 9;
            ISession s = DataLayer.GetSession();
            IList<Izvestaj> izvestaji = s.QueryOver<Izvestaj>().List<Izvestaj>();
            ListViewItem lvi;

            Common.Methods.SetUpLvIzvestaj();

            foreach(Izvestaj izvestaj in izvestaji)
            {
                lvi = new ListViewItem(izvestaj.Id.ToString());
                Common.Methods.AddItemsToLvIzvestaj(lvi, izvestaj);
            }

            listProjekti = lv;
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

        /*-----------OD OVE LINIJE SU DUGMICI-----------*/
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Common.Methods.closeApplication();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            switch(this.LastLoadedData)
            {
                case 0:
                    DodajProjekat dp = new DodajProjekat();
                    dp.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 1:
                    DodajPredmet dodajPredmet = new DodajPredmet();
                    dodajPredmet.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 2:
                    DodajNastavnika dn = new DodajNastavnika();
                    dn.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 3:
                    DodajClanak dc = new DodajClanak();
                    dc.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 4:
                    DodajRad dr = new DodajRad();
                    dr.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 5:
                    DodajKnjigu dk = new DodajKnjigu();
                    dk.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 6:
                    DodajAutora da = new DodajAutora();
                    da.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 7:
                    DodajStudenta dodajStudenta = new DodajStudenta();
                    dodajStudenta.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 8:
                    DodajGrupu dodajGrupu = new DodajGrupu();
                    dodajGrupu.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 9:
                    DodajIzvestaj di = new DodajIzvestaj();
                    di.ShowDialog();
                    listProjekti.Refresh();
                    break;
                case 10:
                    DodajWebStranicu dodajWeb = new DodajWebStranicu();
                    dodajWeb.ShowDialog();
                    listProjekti.Refresh();
                    break;
            }
        }


        // To delete item which is selected in listView
        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            ISession _session;
            switch (this.LastLoadedData)
            {
                case 0: // Projekat
                    try
                    {
                        _session = DataLayer.GetSession();
                        Projekat projekat = _session.Load<Projekat>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                        MessageBox.Show(projekat.Naziv);
                        _session.Delete(projekat);
                        _session.Flush();
                        _session.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 1: // Predmet
                    try
                    {
                        _session = DataLayer.GetSession();
                        Predmet predmet = _session.Load<Predmet>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                        MessageBox.Show(predmet.Naziv);
                        _session.Delete(predmet);
                        _session.Flush();
                        _session.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 2: // Nastavnik
                    try
                    {
                        _session = DataLayer.GetSession();
                        Nastavnik n = _session.Load<Nastavnik>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                        MessageBox.Show(n.Ime);
                        _session.Delete(n);
                        _session.Flush();
                        _session.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 3: //Clanak
                    try
                    {
                        _session = DataLayer.GetSession();
                        Clanak c = _session.Load<Clanak>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                        MessageBox.Show(c.Naziv);
                        _session.Delete(c);
                        _session.Flush();
                        _session.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 4: // Rad
                    try
                    {
                        _session = DataLayer.GetSession();
                        Rad r = _session.Load<Rad>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                        MessageBox.Show(r.Id.ToString());
                        _session.Delete(r);
                        _session.Flush();
                        _session.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 5: // Knjiga
                    _session = DataLayer.GetSession();
                    Knjiga k = _session.Load<Knjiga>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show(k.Naslov);
                    _session.Delete(k);
                    _session.Flush();
                    _session.Close();
                    break;
                case 6: // Autor
                    _session = DataLayer.GetSession();
                    Autor a = _session.Load<Autor>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show(a.Ime + " " + a.Prezime);
                    _session.Delete(a);
                    _session.Flush();
                    _session.Close();
                    break;
                case 7: // Student
                    _session = DataLayer.GetSession();
                    Student s = _session.Load<Student>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show(s.Ime + " " + s.Prezime);
                    _session.Delete(s);
                    _session.Flush();
                    _session.Close();
                    break;
                case 8: // Grupe
                    _session = DataLayer.GetSession();
                    Grupa g = _session.Load<Grupa>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show(g.Naziv);
                    _session.Delete(g);
                    _session.Flush();
                    _session.Close();
                    break;
                case 9: // Izvestaji
                    _session = DataLayer.GetSession();
                    Izvestaj i = _session.Load<Izvestaj>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show(i.Opis);
                    _session.Delete(i);
                    _session.Flush();
                    _session.Close();
                    break;
                case 10: // Web Stranice
                    _session = DataLayer.GetSession();
                    WebStranice w = _session.Load<WebStranice>(Int32.Parse(listProjekti.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show(w.Link);
                    _session.Delete(w);
                    _session.Flush();
                    _session.Close();
                    break;
            }
        }

        // Izmeni functions        
        private void IzmeniPodatke()
        {
            listProjekti.Items.Clear();
            List<DTProjekat> projekatInformacije = DTOManager.GetProjekte();
            foreach(DTProjekat dp in projekatInformacije)
            {
                ListViewItem item = new ListViewItem(new string[] { dp.ProjekatId.ToString(), dp.ProjekatNaziv, dp.ProjekatGodina.ToString(), dp.ProjekatZavrsen, dp.ProjekatTip, dp.ProjekatGrupni});
                listProjekti.Items.Add(item);
            }

            listProjekti.Refresh();
        }

        private void IzmeniPodatkePredmet()
        {
            //listProjekti.Clear();
            Common.Methods.SetUpLvPredmet();

            List<DTPredmet> predmetInformacije = DTOManager.GetPredmete();
            foreach(DTPredmet predmet in predmetInformacije)
            {
                ListViewItem item = new ListViewItem(new string[] { predmet.SifraPredmeta.ToString(), predmet.NazivPredmeta, predmet.KatedraPredmeta, predmet.SemestarPredmeta });

                listProjekti.Items.Add(item);
            }
            listProjekti.Refresh();
        }

        //Other supporting functions
        private void LoadProjekteInfos()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Projekat> projekti = s.QueryOver<Projekat>().List<Projekat>();
                ListViewItem lvi;

                Common.Methods.SetUpLvProjekat();

                foreach(Projekat projekat in projekti)
                {
                    lvi = new ListViewItem(projekat.Id.ToString());

                    Common.Methods.AddItemsToLvProjekat(lvi, projekat);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}