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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDnevneAktivnosti = new System.Windows.Forms.Button();
            this.btnSlucajeviBolesnika = new System.Windows.Forms.Button();
            this.btnProvjereZnanja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetaljno = new System.Windows.Forms.Button();
            this.dgvDogađaji = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogađaji)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDetaljno);
            this.panel1.Controls.Add(this.dgvDogađaji);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2178, 1108);
            this.panel1.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDnevneAktivnosti, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSlucajeviBolesnika, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProvjereZnanja, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 62);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btnDnevneAktivnosti
            // 
            this.btnDnevneAktivnosti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDnevneAktivnosti.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnevneAktivnosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDnevneAktivnosti.Location = new System.Drawing.Point(355, 3);
            this.btnDnevneAktivnosti.Name = "btnDnevneAktivnosti";
            this.btnDnevneAktivnosti.Size = new System.Drawing.Size(170, 56);
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
            this.btnSlucajeviBolesnika.Location = new System.Drawing.Point(179, 3);
            this.btnSlucajeviBolesnika.Name = "btnSlucajeviBolesnika";
            this.btnSlucajeviBolesnika.Size = new System.Drawing.Size(170, 56);
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
            this.btnProvjereZnanja.Size = new System.Drawing.Size(170, 56);
            this.btnProvjereZnanja.TabIndex = 0;
            this.btnProvjereZnanja.Text = "Provjere znanja";
            this.btnProvjereZnanja.UseVisualStyleBackColor = false;
            this.btnProvjereZnanja.Click += new System.EventHandler(this.btnProvjereZnanja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(66, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 58);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prikaz događaja";
            // 
            // btnDetaljno
            // 
            this.btnDetaljno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetaljno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnDetaljno.FlatAppearance.BorderSize = 0;
            this.btnDetaljno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetaljno.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnDetaljno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnDetaljno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDetaljno.Location = new System.Drawing.Point(1881, 862);
            this.btnDetaljno.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetaljno.Name = "btnDetaljno";
            this.btnDetaljno.Size = new System.Drawing.Size(213, 69);
            this.btnDetaljno.TabIndex = 15;
            this.btnDetaljno.Text = "Detaljno o događaju";
            this.btnDetaljno.UseVisualStyleBackColor = false;
            this.btnDetaljno.Click += new System.EventHandler(this.btnDetaljno_Click);
            // 
            // dgvDogađaji
            // 
            this.dgvDogađaji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDogađaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogađaji.Location = new System.Drawing.Point(74, 207);
            this.dgvDogađaji.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDogađaji.Name = "dgvDogađaji";
            this.dgvDogađaji.RowHeadersWidth = 82;
            this.dgvDogađaji.RowTemplate.Height = 33;
            this.dgvDogađaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDogađaji.Size = new System.Drawing.Size(2020, 622);
            this.dgvDogađaji.TabIndex = 0;
            this.dgvDogađaji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDogađaji_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Popis događaja";
            // 
            // frmDogadaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2178, 1108);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDogadaji";
            this.Text = "frmDogadaji";
            this.Load += new System.EventHandler(this.frmDogadaji_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogađaji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetaljno;
        private System.Windows.Forms.DataGridView dgvDogađaji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnProvjereZnanja;
        private System.Windows.Forms.Button btnSlucajeviBolesnika;
        private System.Windows.Forms.Button btnDnevneAktivnosti;
    }
}