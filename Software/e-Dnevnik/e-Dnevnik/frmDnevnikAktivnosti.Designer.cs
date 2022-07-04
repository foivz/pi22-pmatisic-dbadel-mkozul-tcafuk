namespace e_Dnevnik
{
    partial class frmDnevnikAktivnosti
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1394, 531);
            this.dataGridView1.TabIndex = 0;
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
            this.btnObriši.Location = new System.Drawing.Point(938, 763);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(170, 40);
            this.btnObriši.TabIndex = 13;
            this.btnObriši.Text = "Obriši aktivnost";
            this.btnObriši.UseVisualStyleBackColor = false;
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
            this.btnUredi.Location = new System.Drawing.Point(1138, 763);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(170, 40);
            this.btnUredi.TabIndex = 14;
            this.btnUredi.Text = "Uredi aktivnost";
            this.btnUredi.UseVisualStyleBackColor = false;
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
            this.btnDodaj.Location = new System.Drawing.Point(1338, 763);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(170, 40);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj aktivnost";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnUredi);
            this.panel1.Controls.Add(this.btnObriši);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1551, 860);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dnevnik aktivnosti";
            // 
            // frmDnevnikAktivnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 860);
            this.Controls.Add(this.panel1);
            this.Name = "frmDnevnikAktivnosti";
            this.Text = "frmDnevnikAktivnosti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}