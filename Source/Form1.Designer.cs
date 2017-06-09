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
            this.button1 = new System.Windows.Forms.Button();
            this.listProjekti = new System.Windows.Forms.ListView();
            this.projekatID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatGodina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatZavrsen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatGrupni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekatPredmet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
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
            this.listProjekti.Location = new System.Drawing.Point(93, 12);
            this.listProjekti.Name = "listProjekti";
            this.listProjekti.Size = new System.Drawing.Size(362, 237);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 261);
            this.Controls.Add(this.listProjekti);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

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
    }
}

