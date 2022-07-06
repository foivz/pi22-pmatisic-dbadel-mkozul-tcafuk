namespace e_Dnevnik
{
    partial class frmPocetnaModerator
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
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMentori = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProfilDnevnik2 = new System.Windows.Forms.Button();
            this.btnPogledajDogadaj = new System.Windows.Forms.Button();
            this.dgvPocetnaAktivnosti = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDnevneAktivnosti = new System.Windows.Forms.Button();
            this.btnSlucajeviBolesnika = new System.Windows.Forms.Button();
            this.btnProvjereZnanja = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPocetnaAktivnosti)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnPogledajDogadaj);
            this.panel1.Controls.Add(this.dgvPocetnaAktivnosti);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 788);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nepotvrđeni događaji";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 559);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.70782F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.292181F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1524, 229);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1010, 35);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 30, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(454, 132);
            this.panel6.TabIndex = 2;
            this.panel6.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::e_Dnevnik.Properties.Resources.specijalizani_img;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(454, 63);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel7.Controls.Add(this.lblMentori);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 63);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(454, 69);
            this.panel7.TabIndex = 0;
            this.panel7.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // lblMentori
            // 
            this.lblMentori.AutoSize = true;
            this.lblMentori.BackColor = System.Drawing.Color.Transparent;
            this.lblMentori.ForeColor = System.Drawing.Color.White;
            this.lblMentori.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMentori.Location = new System.Drawing.Point(20, 21);
            this.lblMentori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMentori.Name = "lblMentori";
            this.lblMentori.Size = new System.Drawing.Size(227, 25);
            this.lblMentori.TabIndex = 0;
            this.lblMentori.Text = "Specijalizanti i mentori";
            this.lblMentori.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(522, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 30, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 132);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::e_Dnevnik.Properties.Resources.provjere_znanja_img;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(454, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 63);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 69);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Provjere znanja";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(34, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 30, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 132);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::e_Dnevnik.Properties.Resources.dogadaji_img;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnProfilDnevnik2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 69);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prregled događaja";
            this.label1.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // btnProfilDnevnik2
            // 
            this.btnProfilDnevnik2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnProfilDnevnik2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProfilDnevnik2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilDnevnik2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProfilDnevnik2.Location = new System.Drawing.Point(0, 0);
            this.btnProfilDnevnik2.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfilDnevnik2.Name = "btnProfilDnevnik2";
            this.btnProfilDnevnik2.Size = new System.Drawing.Size(454, 69);
            this.btnProfilDnevnik2.TabIndex = 2;
            this.btnProfilDnevnik2.UseVisualStyleBackColor = false;
            this.btnProfilDnevnik2.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // btnPogledajDogadaj
            // 
            this.btnPogledajDogadaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPogledajDogadaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnPogledajDogadaj.FlatAppearance.BorderSize = 0;
            this.btnPogledajDogadaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPogledajDogadaj.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnPogledajDogadaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnPogledajDogadaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPogledajDogadaj.Location = new System.Drawing.Point(1196, 515);
            this.btnPogledajDogadaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnPogledajDogadaj.Name = "btnPogledajDogadaj";
            this.btnPogledajDogadaj.Size = new System.Drawing.Size(170, 40);
            this.btnPogledajDogadaj.TabIndex = 16;
            this.btnPogledajDogadaj.Text = "Otvori";
            this.btnPogledajDogadaj.UseVisualStyleBackColor = false;
            this.btnPogledajDogadaj.Click += new System.EventHandler(this.btnPogledajDogadaj_Click);
            // 
            // dgvPocetnaAktivnosti
            // 
            this.dgvPocetnaAktivnosti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPocetnaAktivnosti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.dgvPocetnaAktivnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPocetnaAktivnosti.Location = new System.Drawing.Point(136, 69);
            this.dgvPocetnaAktivnosti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPocetnaAktivnosti.Name = "dgvPocetnaAktivnosti";
            this.dgvPocetnaAktivnosti.RowHeadersWidth = 82;
            this.dgvPocetnaAktivnosti.RowTemplate.Height = 33;
            this.dgvPocetnaAktivnosti.Size = new System.Drawing.Size(1230, 438);
            this.dgvPocetnaAktivnosti.TabIndex = 0;
            this.dgvPocetnaAktivnosti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPocetnaAktivnosti_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnDnevneAktivnosti, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSlucajeviBolesnika, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnProvjereZnanja, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(896, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 33);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // btnDnevneAktivnosti
            // 
            this.btnDnevneAktivnosti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDnevneAktivnosti.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnevneAktivnosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDnevneAktivnosti.Location = new System.Drawing.Point(315, 3);
            this.btnDnevneAktivnosti.Name = "btnDnevneAktivnosti";
            this.btnDnevneAktivnosti.Size = new System.Drawing.Size(152, 27);
            this.btnDnevneAktivnosti.TabIndex = 3;
            this.btnDnevneAktivnosti.Text = "Dnevne aktivnosti";
            this.btnDnevneAktivnosti.UseVisualStyleBackColor = true;
            this.btnDnevneAktivnosti.Click += new System.EventHandler(this.btnDnevneAktivnosti_Click);
            // 
            // btnSlucajeviBolesnika
            // 
            this.btnSlucajeviBolesnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlucajeviBolesnika.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlucajeviBolesnika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnSlucajeviBolesnika.Location = new System.Drawing.Point(159, 3);
            this.btnSlucajeviBolesnika.Name = "btnSlucajeviBolesnika";
            this.btnSlucajeviBolesnika.Size = new System.Drawing.Size(150, 27);
            this.btnSlucajeviBolesnika.TabIndex = 1;
            this.btnSlucajeviBolesnika.Text = "Slučajevi bolesnika";
            this.btnSlucajeviBolesnika.UseVisualStyleBackColor = true;
            this.btnSlucajeviBolesnika.Click += new System.EventHandler(this.btnSlucajeviBolesnika_Click);
            // 
            // btnProvjereZnanja
            // 
            this.btnProvjereZnanja.BackColor = System.Drawing.SystemColors.Control;
            this.btnProvjereZnanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvjereZnanja.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvjereZnanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnProvjereZnanja.Location = new System.Drawing.Point(3, 3);
            this.btnProvjereZnanja.Name = "btnProvjereZnanja";
            this.btnProvjereZnanja.Size = new System.Drawing.Size(150, 27);
            this.btnProvjereZnanja.TabIndex = 0;
            this.btnProvjereZnanja.Text = "Provjere znanja";
            this.btnProvjereZnanja.UseVisualStyleBackColor = false;
            this.btnProvjereZnanja.Click += new System.EventHandler(this.btnProvjereZnanja_Click);
            // 
            // frmPocetnaModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 788);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPocetnaModerator";
            this.Text = "frmPocetnaModerator";
            this.Load += new System.EventHandler(this.frmPocetnaModerator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPocetnaAktivnosti)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPocetnaAktivnosti;
        private System.Windows.Forms.Button btnPogledajDogadaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMentori;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfilDnevnik2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDnevneAktivnosti;
        private System.Windows.Forms.Button btnSlucajeviBolesnika;
        private System.Windows.Forms.Button btnProvjereZnanja;
    }
}