namespace e_Dnevnik
{
    partial class frmDogadaji
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
            this.dgvDogađaji = new System.Windows.Forms.DataGridView();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogađaji)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.dgvDogađaji);
            this.panel1.Controls.Add(this.btnUredi);
            this.panel1.Controls.Add(this.btnObriši);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 576);
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
            this.label1.Size = new System.Drawing.Size(354, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Popis događaja";
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
            this.btnDodaj.Location = new System.Drawing.Point(982, 526);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 21);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj aktivnost";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dgvDogađaji
            // 
            this.dgvDogađaji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDogađaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogađaji.Location = new System.Drawing.Point(31, 81);
            this.dgvDogađaji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDogađaji.Name = "dgvDogađaji";
            this.dgvDogađaji.RowHeadersWidth = 82;
            this.dgvDogađaji.RowTemplate.Height = 33;
            this.dgvDogađaji.Size = new System.Drawing.Size(1010, 405);
            this.dgvDogađaji.TabIndex = 0;
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
            this.btnUredi.Location = new System.Drawing.Point(882, 526);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(85, 21);
            this.btnUredi.TabIndex = 14;
            this.btnUredi.Text = "Uredi aktivnost";
            this.btnUredi.UseVisualStyleBackColor = false;
            // 
            // btnObriši
            // 
            this.btnObriši.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObriši.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnObriši.FlatAppearance.BorderSize = 0;
            this.btnObriši.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObriši.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnObriši.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnObriši.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnObriši.Location = new System.Drawing.Point(782, 526);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(85, 21);
            this.btnObriši.TabIndex = 13;
            this.btnObriši.Text = "Obriši aktivnost";
            this.btnObriši.UseVisualStyleBackColor = false;
            // 
            // frmDogadaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 576);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDogadaji";
            this.Text = "frmDogadaji";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogađaji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvDogađaji;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObriši;
    }
}