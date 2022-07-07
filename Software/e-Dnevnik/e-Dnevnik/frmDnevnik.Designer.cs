namespace e_Dnevnik
{
    partial class frmDnevnik
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
            this.lblIspisDnevnika = new System.Windows.Forms.Label();
            this.dgvEvidencijaDnevnihAktivnosti = new System.Windows.Forms.DataGridView();
            this.btnIspisiAktivnosti = new System.Windows.Forms.Button();
            this.dgvEvidencijaProvjeraZnanja = new System.Windows.Forms.DataGridView();
            this.btnIspisiProvjere = new System.Windows.Forms.Button();
            this.btnIspisiBiljeske = new System.Windows.Forms.Button();
            this.dgvEvidencijaBiljeski = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaDnevnihAktivnosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaProvjeraZnanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaBiljeski)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIspisDnevnika
            // 
            this.lblIspisDnevnika.AutoSize = true;
            this.lblIspisDnevnika.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.lblIspisDnevnika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblIspisDnevnika.Location = new System.Drawing.Point(21, 20);
            this.lblIspisDnevnika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIspisDnevnika.Name = "lblIspisDnevnika";
            this.lblIspisDnevnika.Size = new System.Drawing.Size(285, 29);
            this.lblIspisDnevnika.TabIndex = 18;
            this.lblIspisDnevnika.Text = "Ispis izabranih dnevnika";
            // 
            // dgvEvidencijaDnevnihAktivnosti
            // 
            this.dgvEvidencijaDnevnihAktivnosti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEvidencijaDnevnihAktivnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaDnevnihAktivnosti.Location = new System.Drawing.Point(19, 86);
            this.dgvEvidencijaDnevnihAktivnosti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvidencijaDnevnihAktivnosti.Name = "dgvEvidencijaDnevnihAktivnosti";
            this.dgvEvidencijaDnevnihAktivnosti.RowHeadersWidth = 82;
            this.dgvEvidencijaDnevnihAktivnosti.RowTemplate.Height = 33;
            this.dgvEvidencijaDnevnihAktivnosti.Size = new System.Drawing.Size(763, 219);
            this.dgvEvidencijaDnevnihAktivnosti.TabIndex = 19;
            // 
            // btnIspisiAktivnosti
            // 
            this.btnIspisiAktivnosti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIspisiAktivnosti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnIspisiAktivnosti.FlatAppearance.BorderSize = 0;
            this.btnIspisiAktivnosti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspisiAktivnosti.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnIspisiAktivnosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnIspisiAktivnosti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIspisiAktivnosti.Location = new System.Drawing.Point(666, 309);
            this.btnIspisiAktivnosti.Margin = new System.Windows.Forms.Padding(2);
            this.btnIspisiAktivnosti.Name = "btnIspisiAktivnosti";
            this.btnIspisiAktivnosti.Size = new System.Drawing.Size(116, 28);
            this.btnIspisiAktivnosti.TabIndex = 25;
            this.btnIspisiAktivnosti.Text = "Ispiši aktivnosti";
            this.btnIspisiAktivnosti.UseVisualStyleBackColor = false;
            // 
            // dgvEvidencijaProvjeraZnanja
            // 
            this.dgvEvidencijaProvjeraZnanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEvidencijaProvjeraZnanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaProvjeraZnanja.Location = new System.Drawing.Point(19, 361);
            this.dgvEvidencijaProvjeraZnanja.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvidencijaProvjeraZnanja.Name = "dgvEvidencijaProvjeraZnanja";
            this.dgvEvidencijaProvjeraZnanja.RowHeadersWidth = 82;
            this.dgvEvidencijaProvjeraZnanja.RowTemplate.Height = 33;
            this.dgvEvidencijaProvjeraZnanja.Size = new System.Drawing.Size(763, 219);
            this.dgvEvidencijaProvjeraZnanja.TabIndex = 29;
            // 
            // btnIspisiProvjere
            // 
            this.btnIspisiProvjere.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIspisiProvjere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnIspisiProvjere.FlatAppearance.BorderSize = 0;
            this.btnIspisiProvjere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspisiProvjere.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnIspisiProvjere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnIspisiProvjere.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIspisiProvjere.Location = new System.Drawing.Point(666, 584);
            this.btnIspisiProvjere.Margin = new System.Windows.Forms.Padding(2);
            this.btnIspisiProvjere.Name = "btnIspisiProvjere";
            this.btnIspisiProvjere.Size = new System.Drawing.Size(116, 28);
            this.btnIspisiProvjere.TabIndex = 30;
            this.btnIspisiProvjere.Text = "Ispiši provjere";
            this.btnIspisiProvjere.UseVisualStyleBackColor = false;
            // 
            // btnIspisiBiljeske
            // 
            this.btnIspisiBiljeske.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIspisiBiljeske.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnIspisiBiljeske.FlatAppearance.BorderSize = 0;
            this.btnIspisiBiljeske.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspisiBiljeske.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnIspisiBiljeske.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnIspisiBiljeske.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIspisiBiljeske.Location = new System.Drawing.Point(666, 859);
            this.btnIspisiBiljeske.Margin = new System.Windows.Forms.Padding(2);
            this.btnIspisiBiljeske.Name = "btnIspisiBiljeske";
            this.btnIspisiBiljeske.Size = new System.Drawing.Size(116, 28);
            this.btnIspisiBiljeske.TabIndex = 31;
            this.btnIspisiBiljeske.Text = "Ispiši bilješke";
            this.btnIspisiBiljeske.UseVisualStyleBackColor = false;
            // 
            // dgvEvidencijaBiljeski
            // 
            this.dgvEvidencijaBiljeski.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEvidencijaBiljeski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaBiljeski.Location = new System.Drawing.Point(19, 636);
            this.dgvEvidencijaBiljeski.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvidencijaBiljeski.Name = "dgvEvidencijaBiljeski";
            this.dgvEvidencijaBiljeski.RowHeadersWidth = 82;
            this.dgvEvidencijaBiljeski.RowTemplate.Height = 33;
            this.dgvEvidencijaBiljeski.Size = new System.Drawing.Size(763, 219);
            this.dgvEvidencijaBiljeski.TabIndex = 32;
            // 
            // frmDnevnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 903);
            this.Controls.Add(this.dgvEvidencijaBiljeski);
            this.Controls.Add(this.btnIspisiBiljeske);
            this.Controls.Add(this.btnIspisiProvjere);
            this.Controls.Add(this.dgvEvidencijaProvjeraZnanja);
            this.Controls.Add(this.btnIspisiAktivnosti);
            this.Controls.Add(this.dgvEvidencijaDnevnihAktivnosti);
            this.Controls.Add(this.lblIspisDnevnika);
            this.Name = "frmDnevnik";
            this.Text = "frmDnevnik";
            this.Load += new System.EventHandler(this.frmDnevnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaDnevnihAktivnosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaProvjeraZnanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaBiljeski)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIspisDnevnika;
        private System.Windows.Forms.DataGridView dgvEvidencijaDnevnihAktivnosti;
        private System.Windows.Forms.Button btnIspisiAktivnosti;
        private System.Windows.Forms.DataGridView dgvEvidencijaProvjeraZnanja;
        private System.Windows.Forms.Button btnIspisiProvjere;
        private System.Windows.Forms.Button btnIspisiBiljeske;
        private System.Windows.Forms.DataGridView dgvEvidencijaBiljeski;
    }
}