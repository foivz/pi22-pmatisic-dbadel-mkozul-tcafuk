namespace e_Dnevnik
{
    partial class frmProgramSpecijalizacije
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
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.cbPS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPS1 = new System.Windows.Forms.DataGridView();
            this.dgvPS2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPS1);
            this.panel1.Controls.Add(this.dgvPS2);
            this.panel1.Controls.Add(this.btnIzbrisi);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.btnOsvjezi);
            this.panel1.Controls.Add(this.cbPS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 806);
            this.panel1.TabIndex = 20;
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
            this.btnIzbrisi.Location = new System.Drawing.Point(522, 756);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(116, 21);
            this.btnIzbrisi.TabIndex = 21;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
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
            this.btnDodaj.Location = new System.Drawing.Point(642, 756);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 21);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
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
            // 
            // cbPS
            // 
            this.cbPS.FormattingEnabled = true;
            this.cbPS.Items.AddRange(new object[] {
            "Sve provjere"});
            this.cbPS.Location = new System.Drawing.Point(37, 91);
            this.cbPS.Name = "cbPS";
            this.cbPS.Size = new System.Drawing.Size(222, 21);
            this.cbPS.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pregled programa specijalizacije";
            // 
            // dgvPS1
            // 
            this.dgvPS1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvPS1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPS1.Location = new System.Drawing.Point(19, 156);
            this.dgvPS1.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPS1.Name = "dgvPS1";
            this.dgvPS1.RowHeadersWidth = 82;
            this.dgvPS1.RowTemplate.Height = 33;
            this.dgvPS1.Size = new System.Drawing.Size(763, 250);
            this.dgvPS1.TabIndex = 28;
            // 
            // dgvPS2
            // 
            this.dgvPS2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvPS2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPS2.Location = new System.Drawing.Point(19, 450);
            this.dgvPS2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPS2.Name = "dgvPS2";
            this.dgvPS2.RowHeadersWidth = 82;
            this.dgvPS2.RowTemplate.Height = 33;
            this.dgvPS2.Size = new System.Drawing.Size(763, 250);
            this.dgvPS2.TabIndex = 29;
            // 
            // frmProgramSpecijalizacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 806);
            this.Controls.Add(this.panel1);
            this.Name = "frmProgramSpecijalizacije";
            this.Text = "frmProgramSpecijalizacije";
            this.Load += new System.EventHandler(this.frmProgramSpecijalizacije_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.ComboBox cbPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPS1;
        private System.Windows.Forms.DataGridView dgvPS2;
    }
}