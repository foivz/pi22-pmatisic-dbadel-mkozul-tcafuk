namespace e_Dnevnik
{
    partial class frmDodajProvjeruZnanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajProvjeruZnanja));
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnOdustani);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.cbSpecijalizant);
            this.panel1.Controls.Add(this.cbDogadaj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 20;
            // 
            // pbIspit
            // 
            this.pbIspit.Image = ((System.Drawing.Image)(resources.GetObject("pbIspit.Image")));
            this.pbIspit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbIspit.InitialImage")));
            this.pbIspit.Location = new System.Drawing.Point(37, 113);
            this.pbIspit.Name = "pbIspit";
            this.pbIspit.Size = new System.Drawing.Size(223, 206);
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
            this.cbOcjene.Location = new System.Drawing.Point(376, 207);
            this.cbOcjene.Name = "cbOcjene";
            this.cbOcjene.Size = new System.Drawing.Size(157, 21);
            this.cbOcjene.TabIndex = 25;
            // 
            // tbPitanja
            // 
            this.tbPitanja.Location = new System.Drawing.Point(376, 158);
            this.tbPitanja.Name = "tbPitanja";
            this.tbPitanja.Size = new System.Drawing.Size(360, 20);
            this.tbPitanja.TabIndex = 24;
            this.tbPitanja.Leave += new System.EventHandler(this.tbPitanja_Leave);
            // 
            // dtpProvjeraZnanja
            // 
            this.dtpProvjeraZnanja.Location = new System.Drawing.Point(376, 107);
            this.dtpProvjeraZnanja.Name = "dtpProvjeraZnanja";
            this.dtpProvjeraZnanja.Size = new System.Drawing.Size(200, 20);
            this.dtpProvjeraZnanja.TabIndex = 23;
            // 
            // lblSpecijalizant
            // 
            this.lblSpecijalizant.AutoSize = true;
            this.lblSpecijalizant.Location = new System.Drawing.Point(288, 306);
            this.lblSpecijalizant.Name = "lblSpecijalizant";
            this.lblSpecijalizant.Size = new System.Drawing.Size(69, 13);
            this.lblSpecijalizant.TabIndex = 22;
            this.lblSpecijalizant.Text = "Specijalizant:";
            // 
            // lblDogadaj
            // 
            this.lblDogadaj.AutoSize = true;
            this.lblDogadaj.Location = new System.Drawing.Point(288, 259);
            this.lblDogadaj.Name = "lblDogadaj";
            this.lblDogadaj.Size = new System.Drawing.Size(51, 13);
            this.lblDogadaj.TabIndex = 22;
            this.lblDogadaj.Text = "Događaj:";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(288, 210);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(44, 13);
            this.lblOcjena.TabIndex = 22;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // lblPitanja
            // 
            this.lblPitanja.AutoSize = true;
            this.lblPitanja.Location = new System.Drawing.Point(288, 161);
            this.lblPitanja.Name = "lblPitanja";
            this.lblPitanja.Size = new System.Drawing.Size(42, 13);
            this.lblPitanja.TabIndex = 22;
            this.lblPitanja.Text = "Pitanja:";
            // 
            // lblDatumProvjere
            // 
            this.lblDatumProvjere.AutoSize = true;
            this.lblDatumProvjere.Location = new System.Drawing.Point(288, 113);
            this.lblDatumProvjere.Name = "lblDatumProvjere";
            this.lblDatumProvjere.Size = new System.Drawing.Size(82, 13);
            this.lblDatumProvjere.TabIndex = 22;
            this.lblDatumProvjere.Text = "Datum provjere:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnOdustani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnOdustani.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOdustani.Location = new System.Drawing.Point(291, 369);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(116, 21);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnDodaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDodaj.Location = new System.Drawing.Point(460, 369);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 21);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbSpecijalizant
            // 
            this.cbSpecijalizant.FormattingEnabled = true;
            this.cbSpecijalizant.Location = new System.Drawing.Point(376, 303);
            this.cbSpecijalizant.Name = "cbSpecijalizant";
            this.cbSpecijalizant.Size = new System.Drawing.Size(157, 21);
            this.cbSpecijalizant.TabIndex = 18;
            // 
            // cbDogadaj
            // 
            this.cbDogadaj.FormattingEnabled = true;
            this.cbDogadaj.Location = new System.Drawing.Point(376, 256);
            this.cbDogadaj.Name = "cbDogadaj";
            this.cbDogadaj.Size = new System.Drawing.Size(157, 21);
            this.cbDogadaj.TabIndex = 18;
            this.cbDogadaj.SelectionChangeCommitted += new System.EventHandler(this.cbDogadaj_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Unesi provjeru znanja";
            // 
            // frmDodajProvjeruZnanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmDodajProvjeruZnanja";
            this.Text = "frmDodajProvjeruZnanja";
            this.Load += new System.EventHandler(this.frmDodajProvjeruZnanja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIspit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbDogadaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOcjene;
        private System.Windows.Forms.TextBox tbPitanja;
        private System.Windows.Forms.DateTimePicker dtpProvjeraZnanja;
        private System.Windows.Forms.Label lblDogadaj;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblPitanja;
        private System.Windows.Forms.Label lblDatumProvjere;
        private System.Windows.Forms.PictureBox pbIspit;
        private System.Windows.Forms.Label lblSpecijalizant;
        private System.Windows.Forms.ComboBox cbSpecijalizant;
    }
}