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
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMentori = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPocetnDogdaji = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProfilDnevnik2 = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPocetnaAktivnosti = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPocetnaAktivnosti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.dgvPocetnaAktivnosti);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 410);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 291);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.70782F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.292181F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 119);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(505, 18);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 15, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 69);
            this.panel6.TabIndex = 2;
            this.panel6.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel7.Controls.Add(this.lblMentori);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 33);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(227, 36);
            this.panel7.TabIndex = 0;
            this.panel7.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // lblMentori
            // 
            this.lblMentori.AutoSize = true;
            this.lblMentori.BackColor = System.Drawing.Color.Transparent;
            this.lblMentori.ForeColor = System.Drawing.Color.White;
            this.lblMentori.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMentori.Location = new System.Drawing.Point(10, 11);
            this.lblMentori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMentori.Name = "lblMentori";
            this.lblMentori.Size = new System.Drawing.Size(110, 13);
            this.lblMentori.TabIndex = 0;
            this.lblMentori.Text = "Specijalizanti i mentori";
            this.lblMentori.Click += new System.EventHandler(this.btnMentoriSpecijalizant_click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(261, 18);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 15, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 69);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 36);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Provjere znanja";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPocetnDogdaji);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(17, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 15, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 69);
            this.panel2.TabIndex = 0;
            // 
            // btnPocetnDogdaji
            // 
            this.btnPocetnDogdaji.BackColor = System.Drawing.Color.Silver;
            this.btnPocetnDogdaji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPocetnDogdaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetnDogdaji.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPocetnDogdaji.Location = new System.Drawing.Point(0, 0);
            this.btnPocetnDogdaji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPocetnDogdaji.Name = "btnPocetnDogdaji";
            this.btnPocetnDogdaji.Size = new System.Drawing.Size(227, 33);
            this.btnPocetnDogdaji.TabIndex = 1;
            this.btnPocetnDogdaji.UseVisualStyleBackColor = false;
            this.btnPocetnDogdaji.Click += new System.EventHandler(this.btnPocetnDnevnik_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnProfilDnevnik2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 36);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prregled događaja";
            // 
            // btnProfilDnevnik2
            // 
            this.btnProfilDnevnik2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnProfilDnevnik2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProfilDnevnik2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilDnevnik2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProfilDnevnik2.Location = new System.Drawing.Point(0, 0);
            this.btnProfilDnevnik2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfilDnevnik2.Name = "btnProfilDnevnik2";
            this.btnProfilDnevnik2.Size = new System.Drawing.Size(227, 36);
            this.btnProfilDnevnik2.TabIndex = 2;
            this.btnProfilDnevnik2.UseVisualStyleBackColor = false;
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
            this.btnDodaj.Location = new System.Drawing.Point(598, 268);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 21);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Otvori";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dgvPocetnaAktivnosti
            // 
            this.dgvPocetnaAktivnosti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPocetnaAktivnosti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.dgvPocetnaAktivnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPocetnaAktivnosti.Location = new System.Drawing.Point(68, 36);
            this.dgvPocetnaAktivnosti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPocetnaAktivnosti.Name = "dgvPocetnaAktivnosti";
            this.dgvPocetnaAktivnosti.RowHeadersWidth = 82;
            this.dgvPocetnaAktivnosti.RowTemplate.Height = 33;
            this.dgvPocetnaAktivnosti.Size = new System.Drawing.Size(615, 228);
            this.dgvPocetnaAktivnosti.TabIndex = 0;
            // 
            // frmPocetnaModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 410);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPocetnaModerator";
            this.Text = "frmPocetnaModerator";
            this.Load += new System.EventHandler(this.frmPocetnaModerator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPocetnaAktivnosti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPocetnaAktivnosti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMentori;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPocetnDogdaji;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfilDnevnik2;
        private System.Windows.Forms.Label label4;
    }
}