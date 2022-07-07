namespace e_Dnevnik
{
    partial class frmDogadajProvjeraZnanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDogadajProvjeraZnanja));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIspit = new System.Windows.Forms.PictureBox();
            this.cbOcjene = new System.Windows.Forms.ComboBox();
            this.tbPitanja = new System.Windows.Forms.TextBox();
            this.dtpProvjeraZnanja = new System.Windows.Forms.DateTimePicker();
            this.lblSpecijalizant = new System.Windows.Forms.Label();
            this.lblDogadaj = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblPitanja = new System.Windows.Forms.Label();
            this.lblDatumProvjere = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.cbSpecijalizant = new System.Windows.Forms.ComboBox();
            this.cbDogadaj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIspit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbIspit);
            this.panel1.Controls.Add(this.cbOcjene);
            this.panel1.Controls.Add(this.tbPitanja);
            this.panel1.Controls.Add(this.dtpProvjeraZnanja);
            this.panel1.Controls.Add(this.lblSpecijalizant);
            this.panel1.Controls.Add(this.lblDogadaj);
            this.panel1.Controls.Add(this.lblOcjena);
            this.panel1.Controls.Add(this.lblPitanja);
            this.panel1.Controls.Add(this.lblDatumProvjere);
            this.panel1.Controls.Add(this.btnZatvori);
            this.panel1.Controls.Add(this.cbSpecijalizant);
            this.panel1.Controls.Add(this.cbDogadaj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1709, 857);
            this.panel1.TabIndex = 21;
            // 
            // pbIspit
            // 
            this.pbIspit.Image = ((System.Drawing.Image)(resources.GetObject("pbIspit.Image")));
            this.pbIspit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbIspit.InitialImage")));
            this.pbIspit.Location = new System.Drawing.Point(74, 217);
            this.pbIspit.Margin = new System.Windows.Forms.Padding(6);
            this.pbIspit.Name = "pbIspit";
            this.pbIspit.Size = new System.Drawing.Size(446, 396);
            this.pbIspit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIspit.TabIndex = 26;
            this.pbIspit.TabStop = false;
            // 
            // cbOcjene
            // 
            this.cbOcjene.FormattingEnabled = true;
            this.cbOcjene.Items.AddRange(new object[] {
            "1 - nedovoljan",
            "2 - dovoljan",
            "3 - dobar ",
            "4 - vrlo dobar",
            "5 - odličan"});
            this.cbOcjene.Location = new System.Drawing.Point(752, 398);
            this.cbOcjene.Margin = new System.Windows.Forms.Padding(6);
            this.cbOcjene.Name = "cbOcjene";
            this.cbOcjene.Size = new System.Drawing.Size(310, 33);
            this.cbOcjene.TabIndex = 25;
            // 
            // tbPitanja
            // 
            this.tbPitanja.Location = new System.Drawing.Point(752, 304);
            this.tbPitanja.Margin = new System.Windows.Forms.Padding(6);
            this.tbPitanja.Multiline = true;
            this.tbPitanja.Name = "tbPitanja";
            this.tbPitanja.Size = new System.Drawing.Size(396, 69);
            this.tbPitanja.TabIndex = 24;
            // 
            // dtpProvjeraZnanja
            // 
            this.dtpProvjeraZnanja.Location = new System.Drawing.Point(752, 206);
            this.dtpProvjeraZnanja.Margin = new System.Windows.Forms.Padding(6);
            this.dtpProvjeraZnanja.Name = "dtpProvjeraZnanja";
            this.dtpProvjeraZnanja.Size = new System.Drawing.Size(396, 31);
            this.dtpProvjeraZnanja.TabIndex = 23;
            // 
            // lblSpecijalizant
            // 
            this.lblSpecijalizant.AutoSize = true;
            this.lblSpecijalizant.Location = new System.Drawing.Point(576, 588);
            this.lblSpecijalizant.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpecijalizant.Name = "lblSpecijalizant";
            this.lblSpecijalizant.Size = new System.Drawing.Size(140, 25);
            this.lblSpecijalizant.TabIndex = 22;
            this.lblSpecijalizant.Text = "Specijalizant:";
            // 
            // lblDogadaj
            // 
            this.lblDogadaj.AutoSize = true;
            this.lblDogadaj.Location = new System.Drawing.Point(576, 498);
            this.lblDogadaj.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDogadaj.Name = "lblDogadaj";
            this.lblDogadaj.Size = new System.Drawing.Size(98, 25);
            this.lblDogadaj.TabIndex = 22;
            this.lblDogadaj.Text = "Događaj:";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(576, 404);
            this.lblOcjena.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(86, 25);
            this.lblOcjena.TabIndex = 22;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // lblPitanja
            // 
            this.lblPitanja.AutoSize = true;
            this.lblPitanja.Location = new System.Drawing.Point(576, 310);
            this.lblPitanja.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPitanja.Name = "lblPitanja";
            this.lblPitanja.Size = new System.Drawing.Size(84, 25);
            this.lblPitanja.TabIndex = 22;
            this.lblPitanja.Text = "Pitanja:";
            // 
            // lblDatumProvjere
            // 
            this.lblDatumProvjere.AutoSize = true;
            this.lblDatumProvjere.Location = new System.Drawing.Point(576, 217);
            this.lblDatumProvjere.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDatumProvjere.Name = "lblDatumProvjere";
            this.lblDatumProvjere.Size = new System.Drawing.Size(164, 25);
            this.lblDatumProvjere.TabIndex = 22;
            this.lblDatumProvjere.Text = "Datum provjere:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnZatvori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnZatvori.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZatvori.Location = new System.Drawing.Point(974, 702);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(232, 40);
            this.btnZatvori.TabIndex = 20;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // cbSpecijalizant
            // 
            this.cbSpecijalizant.FormattingEnabled = true;
            this.cbSpecijalizant.Location = new System.Drawing.Point(752, 583);
            this.cbSpecijalizant.Margin = new System.Windows.Forms.Padding(6);
            this.cbSpecijalizant.Name = "cbSpecijalizant";
            this.cbSpecijalizant.Size = new System.Drawing.Size(310, 33);
            this.cbSpecijalizant.TabIndex = 18;
            // 
            // cbDogadaj
            // 
            this.cbDogadaj.FormattingEnabled = true;
            this.cbDogadaj.Location = new System.Drawing.Point(752, 492);
            this.cbDogadaj.Margin = new System.Windows.Forms.Padding(6);
            this.cbDogadaj.Name = "cbDogadaj";
            this.cbDogadaj.Size = new System.Drawing.Size(310, 33);
            this.cbDogadaj.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(64, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Provjera znanja";
            // 
            // frmDogadaj_ProvjeraZnanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 857);
            this.Controls.Add(this.panel1);
            this.Name = "frmDogadaj_ProvjeraZnanja";
            this.Text = "frmDogadaj_ProvjeraZnanja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIspit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbIspit;
        private System.Windows.Forms.ComboBox cbOcjene;
        private System.Windows.Forms.TextBox tbPitanja;
        private System.Windows.Forms.DateTimePicker dtpProvjeraZnanja;
        private System.Windows.Forms.Label lblSpecijalizant;
        private System.Windows.Forms.Label lblDogadaj;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblPitanja;
        private System.Windows.Forms.Label lblDatumProvjere;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ComboBox cbSpecijalizant;
        private System.Windows.Forms.ComboBox cbDogadaj;
        private System.Windows.Forms.Label label1;
    }
}