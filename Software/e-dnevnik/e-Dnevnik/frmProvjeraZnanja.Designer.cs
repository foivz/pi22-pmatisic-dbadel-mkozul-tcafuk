namespace e_Dnevnik
{
    partial class frmProvjeraZnanja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProvjeraZnanja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProvjereZnanja = new System.Windows.Forms.DataGridView();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.lblProsjecnaOcjena = new System.Windows.Forms.Label();
            this.tbProsjecnaOcjena = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvjereZnanja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbProsjecnaOcjena);
            this.panel1.Controls.Add(this.lblProsjecnaOcjena);
            this.panel1.Controls.Add(this.btnIzbrisi);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.btnOsvjezi);
            this.panel1.Controls.Add(this.cbProvjeraZnanja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvProvjereZnanja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 468);
            this.panel1.TabIndex = 19;
            // 
            // cbProvjeraZnanja
            // 
            this.cbProvjeraZnanja.FormattingEnabled = true;
            this.cbProvjeraZnanja.Items.AddRange(new object[] {
            "Sve provjere"});
            this.cbProvjeraZnanja.Location = new System.Drawing.Point(37, 91);
            this.cbProvjeraZnanja.Name = "cbProvjeraZnanja";
            this.cbProvjeraZnanja.Size = new System.Drawing.Size(222, 21);
            this.cbProvjeraZnanja.TabIndex = 18;
            this.cbProvjeraZnanja.SelectedValueChanged += new System.EventHandler(this.cbProvjeraZnanja_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Evidencija provjera znanja";
            // 
            // dgvProvjereZnanja
            // 
            this.dgvProvjereZnanja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProvjereZnanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvjereZnanja.Location = new System.Drawing.Point(37, 134);
            this.dgvProvjereZnanja.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProvjereZnanja.Name = "dgvProvjereZnanja";
            this.dgvProvjereZnanja.RowHeadersWidth = 82;
            this.dgvProvjereZnanja.RowTemplate.Height = 33;
            this.dgvProvjereZnanja.Size = new System.Drawing.Size(721, 280);
            this.dgvProvjereZnanja.TabIndex = 0;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnOsvjezi.FlatAppearance.BorderSize = 0;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnOsvjezi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnOsvjezi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOsvjezi.Location = new System.Drawing.Point(264, 90);
            this.btnOsvjezi.Margin = new System.Windows.Forms.Padding(2);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(85, 21);
            this.btnOsvjezi.TabIndex = 19;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnDodaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDodaj.Location = new System.Drawing.Point(642, 418);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 21);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzbrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnIzbrisi.FlatAppearance.BorderSize = 0;
            this.btnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisi.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnIzbrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnIzbrisi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIzbrisi.Location = new System.Drawing.Point(522, 418);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(116, 21);
            this.btnIzbrisi.TabIndex = 21;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // lblProsjecnaOcjena
            // 
            this.lblProsjecnaOcjena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProsjecnaOcjena.AutoSize = true;
            this.lblProsjecnaOcjena.Location = new System.Drawing.Point(578, 102);
            this.lblProsjecnaOcjena.Name = "lblProsjecnaOcjena";
            this.lblProsjecnaOcjena.Size = new System.Drawing.Size(89, 13);
            this.lblProsjecnaOcjena.TabIndex = 22;
            this.lblProsjecnaOcjena.Text = "Prosječna ocjena";
            // 
            // tbProsjecnaOcjena
            // 
            this.tbProsjecnaOcjena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProsjecnaOcjena.Location = new System.Drawing.Point(673, 99);
            this.tbProsjecnaOcjena.Name = "tbProsjecnaOcjena";
            this.tbProsjecnaOcjena.ReadOnly = true;
            this.tbProsjecnaOcjena.Size = new System.Drawing.Size(85, 20);
            this.tbProsjecnaOcjena.TabIndex = 23;
            this.tbProsjecnaOcjena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmProvjeraZnanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.panel1);
            this.Name = "frmProvjeraZnanja";
            this.Text = "frmProvjeraZnanja";
            this.Load += new System.EventHandler(this.frmProvjeraZnanja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvjereZnanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProvjereZnanja;
        private System.Windows.Forms.ComboBox cbProvjeraZnanja;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbProsjecnaOcjena;
        private System.Windows.Forms.Label lblProsjecnaOcjena;
    }
}