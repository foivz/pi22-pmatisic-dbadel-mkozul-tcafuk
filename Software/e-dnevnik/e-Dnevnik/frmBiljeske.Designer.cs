namespace e_Dnevnik
{
    partial class frmBiljeske
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
            this.lblEvidencijaBiljeski = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvEvidencijaBiljeski = new System.Windows.Forms.DataGridView();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaBiljeski)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEvidencijaBiljeski);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.dgvEvidencijaBiljeski);
            this.panel1.Controls.Add(this.btnUredi);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 18;
            // 
            // lblEvidencijaBiljeski
            // 
            this.lblEvidencijaBiljeski.AutoSize = true;
            this.lblEvidencijaBiljeski.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.lblEvidencijaBiljeski.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblEvidencijaBiljeski.Location = new System.Drawing.Point(32, 35);
            this.lblEvidencijaBiljeski.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvidencijaBiljeski.Name = "lblEvidencijaBiljeski";
            this.lblEvidencijaBiljeski.Size = new System.Drawing.Size(222, 29);
            this.lblEvidencijaBiljeski.TabIndex = 17;
            this.lblEvidencijaBiljeski.Text = "Evidencija bilješki";
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
            this.btnDodaj.Location = new System.Drawing.Point(667, 400);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 21);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj aktivnost";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dgvEvidencijaBiljeski
            // 
            this.dgvEvidencijaBiljeski.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvidencijaBiljeski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaBiljeski.Location = new System.Drawing.Point(31, 81);
            this.dgvEvidencijaBiljeski.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvidencijaBiljeski.Name = "dgvEvidencijaBiljeski";
            this.dgvEvidencijaBiljeski.RowHeadersWidth = 82;
            this.dgvEvidencijaBiljeski.RowTemplate.Height = 33;
            this.dgvEvidencijaBiljeski.Size = new System.Drawing.Size(721, 279);
            this.dgvEvidencijaBiljeski.TabIndex = 0;
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnUredi.FlatAppearance.BorderSize = 0;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnUredi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnUredi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUredi.Location = new System.Drawing.Point(567, 400);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(85, 21);
            this.btnUredi.TabIndex = 14;
            this.btnUredi.Text = "Uredi aktivnost";
            this.btnUredi.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnObrisi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnObrisi.Location = new System.Drawing.Point(467, 400);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(85, 21);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obriši aktivnost";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // frmBiljeske
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmBiljeske";
            this.Text = "frmBiljeske";
            this.Load += new System.EventHandler(this.frmBiljeske_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaBiljeski)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEvidencijaBiljeski;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvEvidencijaBiljeski;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
    }
}