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
            this.cbEvidencijaDnevnihAktivnosti = new System.Windows.Forms.CheckBox();
            this.cbEvidencijaProvjeraZnanja = new System.Windows.Forms.CheckBox();
            this.cbEvidencijaBiljeski = new System.Windows.Forms.CheckBox();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.dgvEvidencijaProvjeraZnanja = new System.Windows.Forms.DataGridView();
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
            this.dgvEvidencijaDnevnihAktivnosti.Location = new System.Drawing.Point(26, 86);
            this.dgvEvidencijaDnevnihAktivnosti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvidencijaDnevnihAktivnosti.Name = "dgvEvidencijaDnevnihAktivnosti";
            this.dgvEvidencijaDnevnihAktivnosti.RowHeadersWidth = 82;
            this.dgvEvidencijaDnevnihAktivnosti.RowTemplate.Height = 33;
            this.dgvEvidencijaDnevnihAktivnosti.Size = new System.Drawing.Size(763, 250);
            this.dgvEvidencijaDnevnihAktivnosti.TabIndex = 19;
            // 
            // cbEvidencijaDnevnihAktivnosti
            // 
            this.cbEvidencijaDnevnihAktivnosti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEvidencijaDnevnihAktivnosti.AutoSize = true;
            this.cbEvidencijaDnevnihAktivnosti.Location = new System.Drawing.Point(26, 64);
            this.cbEvidencijaDnevnihAktivnosti.Name = "cbEvidencijaDnevnihAktivnosti";
            this.cbEvidencijaDnevnihAktivnosti.Size = new System.Drawing.Size(164, 17);
            this.cbEvidencijaDnevnihAktivnosti.TabIndex = 22;
            this.cbEvidencijaDnevnihAktivnosti.Text = "Evidencija dnevnih aktivnosti";
            this.cbEvidencijaDnevnihAktivnosti.UseVisualStyleBackColor = true;
            // 
            // cbEvidencijaProvjeraZnanja
            // 
            this.cbEvidencijaProvjeraZnanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEvidencijaProvjeraZnanja.AutoSize = true;
            this.cbEvidencijaProvjeraZnanja.Location = new System.Drawing.Point(26, 358);
            this.cbEvidencijaProvjeraZnanja.Name = "cbEvidencijaProvjeraZnanja";
            this.cbEvidencijaProvjeraZnanja.Size = new System.Drawing.Size(150, 17);
            this.cbEvidencijaProvjeraZnanja.TabIndex = 23;
            this.cbEvidencijaProvjeraZnanja.Text = "Evidencija provjera znanja";
            this.cbEvidencijaProvjeraZnanja.UseVisualStyleBackColor = true;
            // 
            // cbEvidencijaBiljeski
            // 
            this.cbEvidencijaBiljeski.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEvidencijaBiljeski.AutoSize = true;
            this.cbEvidencijaBiljeski.Location = new System.Drawing.Point(26, 647);
            this.cbEvidencijaBiljeski.Name = "cbEvidencijaBiljeski";
            this.cbEvidencijaBiljeski.Size = new System.Drawing.Size(109, 17);
            this.cbEvidencijaBiljeski.TabIndex = 24;
            this.cbEvidencijaBiljeski.Text = "Evidencija bilješki";
            this.cbEvidencijaBiljeski.UseVisualStyleBackColor = true;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIspisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnIspisi.FlatAppearance.BorderSize = 0;
            this.btnIspisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspisi.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnIspisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnIspisi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIspisi.Location = new System.Drawing.Point(673, 24);
            this.btnIspisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(116, 28);
            this.btnIspisi.TabIndex = 25;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = false;
            // 
            // dgvEvidencijaProvjeraZnanja
            // 
            this.dgvEvidencijaProvjeraZnanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEvidencijaProvjeraZnanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaProvjeraZnanja.Location = new System.Drawing.Point(26, 380);
            this.dgvEvidencijaProvjeraZnanja.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvidencijaProvjeraZnanja.Name = "dgvEvidencijaProvjeraZnanja";
            this.dgvEvidencijaProvjeraZnanja.RowHeadersWidth = 82;
            this.dgvEvidencijaProvjeraZnanja.RowTemplate.Height = 33;
            this.dgvEvidencijaProvjeraZnanja.Size = new System.Drawing.Size(763, 250);
            this.dgvEvidencijaProvjeraZnanja.TabIndex = 27;
            // 
            // dgvEvidencijaBiljeski
            // 
            this.dgvEvidencijaBiljeski.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEvidencijaBiljeski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaBiljeski.Location = new System.Drawing.Point(26, 669);
            this.dgvEvidencijaBiljeski.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvidencijaBiljeski.Name = "dgvEvidencijaBiljeski";
            this.dgvEvidencijaBiljeski.RowHeadersWidth = 82;
            this.dgvEvidencijaBiljeski.RowTemplate.Height = 33;
            this.dgvEvidencijaBiljeski.Size = new System.Drawing.Size(763, 250);
            this.dgvEvidencijaBiljeski.TabIndex = 28;
            // 
            // frmDnevnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 940);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.cbEvidencijaBiljeski);
            this.Controls.Add(this.cbEvidencijaProvjeraZnanja);
            this.Controls.Add(this.cbEvidencijaDnevnihAktivnosti);
            this.Controls.Add(this.dgvEvidencijaDnevnihAktivnosti);
            this.Controls.Add(this.lblIspisDnevnika);
            this.Controls.Add(this.dgvEvidencijaProvjeraZnanja);
            this.Controls.Add(this.dgvEvidencijaBiljeski);
            this.Name = "frmDnevnik";
            this.Text = "frmDnevnik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaDnevnihAktivnosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaProvjeraZnanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaBiljeski)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIspisDnevnika;
        private System.Windows.Forms.DataGridView dgvEvidencijaDnevnihAktivnosti;
        private System.Windows.Forms.CheckBox cbEvidencijaDnevnihAktivnosti;
        private System.Windows.Forms.CheckBox cbEvidencijaProvjeraZnanja;
        private System.Windows.Forms.CheckBox cbEvidencijaBiljeski;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.DataGridView dgvEvidencijaProvjeraZnanja;
        private System.Windows.Forms.DataGridView dgvEvidencijaBiljeski;
    }
}