namespace Source
{
    partial class PrikaziPredmet
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
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKatedra = new System.Windows.Forms.TextBox();
            this.txtSemestar = new System.Windows.Forms.TextBox();
            this.txtNastavnik = new System.Windows.Forms.TextBox();
            this.lbSifra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifra
            // 
            this.txtSifra.Enabled = false;
            this.txtSifra.Location = new System.Drawing.Point(12, 24);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 0;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 74);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtKatedra
            // 
            this.txtKatedra.Location = new System.Drawing.Point(12, 124);
            this.txtKatedra.Name = "txtKatedra";
            this.txtKatedra.Size = new System.Drawing.Size(100, 20);
            this.txtKatedra.TabIndex = 2;
            // 
            // txtSemestar
            // 
            this.txtSemestar.Location = new System.Drawing.Point(168, 24);
            this.txtSemestar.Name = "txtSemestar";
            this.txtSemestar.Size = new System.Drawing.Size(100, 20);
            this.txtSemestar.TabIndex = 3;
            // 
            // txtNastavnik
            // 
            this.txtNastavnik.Location = new System.Drawing.Point(168, 74);
            this.txtNastavnik.Name = "txtNastavnik";
            this.txtNastavnik.Size = new System.Drawing.Size(100, 20);
            this.txtNastavnik.TabIndex = 4;
            // 
            // lbSifra
            // 
            this.lbSifra.AutoSize = true;
            this.lbSifra.Location = new System.Drawing.Point(12, 9);
            this.lbSifra.Name = "lbSifra";
            this.lbSifra.Size = new System.Drawing.Size(28, 13);
            this.lbSifra.TabIndex = 5;
            this.lbSifra.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Katedra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Semestar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nastavnik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Azuriraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrikaziPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 168);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSifra);
            this.Controls.Add(this.txtNastavnik);
            this.Controls.Add(this.txtSemestar);
            this.Controls.Add(this.txtKatedra);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Name = "PrikaziPredmet";
            this.Text = "PrikaziPredmete";
            this.Load += new System.EventHandler(this.PrikaziPredmete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKatedra;
        private System.Windows.Forms.TextBox txtSemestar;
        private System.Windows.Forms.TextBox txtNastavnik;
        private System.Windows.Forms.Label lbSifra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}