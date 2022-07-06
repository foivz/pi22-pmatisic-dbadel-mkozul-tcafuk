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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvBiljeske = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.lblCrtica = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiljeske)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCrtica);
            this.panel1.Controls.Add(this.dtpKraj);
            this.panel1.Controls.Add(this.dtpPocetak);
            this.panel1.Controls.Add(this.btnOsvjezi);
            this.panel1.Controls.Add(this.btnSortiraj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.dgvBiljeske);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Evidencija bilješki";
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
            this.btnDodaj.Location = new System.Drawing.Point(667, 402);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 21);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj bilješku";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvBiljeske
            // 
            this.dgvBiljeske.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBiljeske.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiljeske.Location = new System.Drawing.Point(31, 121);
            this.dgvBiljeske.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBiljeske.Name = "dgvBiljeske";
            this.dgvBiljeske.RowHeadersWidth = 82;
            this.dgvBiljeske.RowTemplate.Height = 33;
            this.dgvBiljeske.Size = new System.Drawing.Size(721, 254);
            this.dgvBiljeske.TabIndex = 0;
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
            this.btnObrisi.Location = new System.Drawing.Point(578, 402);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(85, 21);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obriši bilješku";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSortiraj.FlatAppearance.BorderSize = 0;
            this.btnSortiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortiraj.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnSortiraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnSortiraj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSortiraj.Location = new System.Drawing.Point(458, 93);
            this.btnSortiraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(85, 21);
            this.btnSortiraj.TabIndex = 18;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = false;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnOsvjezi.FlatAppearance.BorderSize = 0;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnOsvjezi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnOsvjezi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOsvjezi.Location = new System.Drawing.Point(547, 93);
            this.btnOsvjezi.Margin = new System.Windows.Forms.Padding(2);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(85, 21);
            this.btnOsvjezi.TabIndex = 19;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(31, 94);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetak.TabIndex = 20;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Location = new System.Drawing.Point(253, 94);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(200, 20);
            this.dtpKraj.TabIndex = 20;
            // 
            // lblCrtica
            // 
            this.lblCrtica.AutoSize = true;
            this.lblCrtica.Location = new System.Drawing.Point(237, 97);
            this.lblCrtica.Name = "lblCrtica";
            this.lblCrtica.Size = new System.Drawing.Size(10, 13);
            this.lblCrtica.TabIndex = 21;
            this.lblCrtica.Text = "-";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiljeske)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvBiljeske;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblCrtica;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnSortiraj;
    }
}