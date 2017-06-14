namespace Source
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listProjekti = new System.Windows.Forms.ListView();
            this.projekatID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatGodina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatZavrsen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatGrupni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatPredmet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ucitajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastavnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.literaturuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucitajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.predmeteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projekteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.literaturuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clankoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastavnikeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webStraniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Predmeti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listProjekti
            // 
            this.listProjekti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProjekti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projekatID,
            this.projekatNaziv,
            this.projekatGodina,
            this.projekatTip,
            this.projekatZavrsen,
            this.projekatGrupni,
            this.projekatPredmet});
            this.listProjekti.FullRowSelect = true;
            this.listProjekti.GridLines = true;
            this.listProjekti.Location = new System.Drawing.Point(93, 36);
            this.listProjekti.Name = "listProjekti";
            this.listProjekti.Size = new System.Drawing.Size(620, 299);
            this.listProjekti.TabIndex = 1;
            this.listProjekti.UseCompatibleStateImageBehavior = false;
            this.listProjekti.View = System.Windows.Forms.View.Details;
            // 
            // projekatID
            // 
            this.projekatID.Text = "ID";
            // 
            // projekatNaziv
            // 
            this.projekatNaziv.Text = "Naziv";
            this.projekatNaziv.Width = 117;
            // 
            // projekatGodina
            // 
            this.projekatGodina.Text = "Godina";
            // 
            // projekatTip
            // 
            this.projekatTip.DisplayIndex = 4;
            this.projekatTip.Text = "Tip";
            // 
            // projekatZavrsen
            // 
            this.projekatZavrsen.DisplayIndex = 3;
            this.projekatZavrsen.Text = "Zavrsen";
            // 
            // projekatGrupni
            // 
            this.projekatGrupni.Text = "Grupni";
            // 
            // projekatPredmet
            // 
            this.projekatPredmet.Text = "Predmet";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ucitajToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 54);
            // 
            // ucitajToolStripMenuItem
            // 
            this.ucitajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predmeteToolStripMenuItem,
            this.nastavnikeToolStripMenuItem,
            this.autoreToolStripMenuItem,
            this.literaturuToolStripMenuItem,
            this.projekteToolStripMenuItem});
            this.ucitajToolStripMenuItem.Name = "ucitajToolStripMenuItem";
            this.ucitajToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.ucitajToolStripMenuItem.Text = "Ucitaj";
            // 
            // predmeteToolStripMenuItem
            // 
            this.predmeteToolStripMenuItem.Name = "predmeteToolStripMenuItem";
            this.predmeteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.predmeteToolStripMenuItem.Text = "Predmete";
            // 
            // nastavnikeToolStripMenuItem
            // 
            this.nastavnikeToolStripMenuItem.Name = "nastavnikeToolStripMenuItem";
            this.nastavnikeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nastavnikeToolStripMenuItem.Text = "Nastavnike";
            // 
            // autoreToolStripMenuItem
            // 
            this.autoreToolStripMenuItem.Name = "autoreToolStripMenuItem";
            this.autoreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.autoreToolStripMenuItem.Text = "Autore";
            // 
            // literaturuToolStripMenuItem
            // 
            this.literaturuToolStripMenuItem.Name = "literaturuToolStripMenuItem";
            this.literaturuToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.literaturuToolStripMenuItem.Text = "Literaturu";
            // 
            // projekteToolStripMenuItem
            // 
            this.projekteToolStripMenuItem.Name = "projekteToolStripMenuItem";
            this.projekteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.projekteToolStripMenuItem.Text = "Projekte";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(101, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ucitajToolStripMenuItem1,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ucitajToolStripMenuItem1
            // 
            this.ucitajToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predmeteToolStripMenuItem1,
            this.projekteToolStripMenuItem1,
            this.literaturuToolStripMenuItem1,
            this.nastavnikeToolStripMenuItem1,
            this.autoreToolStripMenuItem1,
            this.studenteToolStripMenuItem,
            this.grupeToolStripMenuItem,
            this.izvestajiToolStripMenuItem,
            this.webStraniceToolStripMenuItem});
            this.ucitajToolStripMenuItem1.Name = "ucitajToolStripMenuItem1";
            this.ucitajToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ucitajToolStripMenuItem1.Text = "Ucitaj";
            // 
            // predmeteToolStripMenuItem1
            // 
            this.predmeteToolStripMenuItem1.Name = "predmeteToolStripMenuItem1";
            this.predmeteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.predmeteToolStripMenuItem1.Text = "Predmete";
            this.predmeteToolStripMenuItem1.Click += new System.EventHandler(this.predmeteToolStripMenuItem1_Click);
            // 
            // projekteToolStripMenuItem1
            // 
            this.projekteToolStripMenuItem1.Name = "projekteToolStripMenuItem1";
            this.projekteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.projekteToolStripMenuItem1.Text = "Projekte";
            this.projekteToolStripMenuItem1.Click += new System.EventHandler(this.projekteToolStripMenuItem1_Click);
            // 
            // literaturuToolStripMenuItem1
            // 
            this.literaturuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radoviToolStripMenuItem,
            this.clankoviToolStripMenuItem,
            this.knjigeToolStripMenuItem});
            this.literaturuToolStripMenuItem1.Name = "literaturuToolStripMenuItem1";
            this.literaturuToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.literaturuToolStripMenuItem1.Text = "Literaturu";
            this.literaturuToolStripMenuItem1.Click += new System.EventHandler(this.literaturuToolStripMenuItem1_Click);
            // 
            // radoviToolStripMenuItem
            // 
            this.radoviToolStripMenuItem.Name = "radoviToolStripMenuItem";
            this.radoviToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.radoviToolStripMenuItem.Text = "Radovi";
            this.radoviToolStripMenuItem.Click += new System.EventHandler(this.radoviToolStripMenuItem_Click);
            // 
            // clankoviToolStripMenuItem
            // 
            this.clankoviToolStripMenuItem.Name = "clankoviToolStripMenuItem";
            this.clankoviToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.clankoviToolStripMenuItem.Text = "Clanci";
            this.clankoviToolStripMenuItem.Click += new System.EventHandler(this.clankoviToolStripMenuItem_Click);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click);
            // 
            // nastavnikeToolStripMenuItem1
            // 
            this.nastavnikeToolStripMenuItem1.Name = "nastavnikeToolStripMenuItem1";
            this.nastavnikeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.nastavnikeToolStripMenuItem1.Text = "Nastavnike";
            this.nastavnikeToolStripMenuItem1.Click += new System.EventHandler(this.nastavnikeToolStripMenuItem1_Click);
            // 
            // autoreToolStripMenuItem1
            // 
            this.autoreToolStripMenuItem1.Name = "autoreToolStripMenuItem1";
            this.autoreToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.autoreToolStripMenuItem1.Text = "Autore";
            this.autoreToolStripMenuItem1.Click += new System.EventHandler(this.autoreToolStripMenuItem1_Click);
            // 
            // studenteToolStripMenuItem
            // 
            this.studenteToolStripMenuItem.Name = "studenteToolStripMenuItem";
            this.studenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studenteToolStripMenuItem.Text = "Studente";
            this.studenteToolStripMenuItem.Click += new System.EventHandler(this.studenteToolStripMenuItem_Click);
            // 
            // grupeToolStripMenuItem
            // 
            this.grupeToolStripMenuItem.Name = "grupeToolStripMenuItem";
            this.grupeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grupeToolStripMenuItem.Text = "Grupe";
            this.grupeToolStripMenuItem.Click += new System.EventHandler(this.grupeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem1.Text = "&Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            this.izvestajiToolStripMenuItem.Click += new System.EventHandler(this.izvestajiToolStripMenuItem_Click);
            // 
            // webStraniceToolStripMenuItem
            // 
            this.webStraniceToolStripMenuItem.Name = "webStraniceToolStripMenuItem";
            this.webStraniceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.webStraniceToolStripMenuItem.Text = "WebStranice";
            this.webStraniceToolStripMenuItem.Click += new System.EventHandler(this.webStraniceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 347);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listProjekti);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listProjekti;
        private System.Windows.Forms.ColumnHeader projekatID;
        private System.Windows.Forms.ColumnHeader projekatNaziv;
        private System.Windows.Forms.ColumnHeader projekatGodina;
        private System.Windows.Forms.ColumnHeader projekatTip;
        private System.Windows.Forms.ColumnHeader projekatZavrsen;
        private System.Windows.Forms.ColumnHeader projekatGrupni;
        private System.Windows.Forms.ColumnHeader projekatPredmet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ucitajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastavnikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem literaturuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projekteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ucitajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem predmeteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nastavnikeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem projekteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem literaturuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem radoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clankoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webStraniceToolStripMenuItem;
    }
}

