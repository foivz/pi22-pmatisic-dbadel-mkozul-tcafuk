namespace e_Dnevnik
{
    partial class frmMentorSpecijalizant
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.cboxFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvMentoriSpecijalizanti = new System.Windows.Forms.DataGridView();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentoriSpecijalizanti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pnlFilter);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.dgvMentoriSpecijalizanti);
            this.panel1.Controls.Add(this.btnUredi);
            this.panel1.Controls.Add(this.btnObriši);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2178, 1108);
            this.panel1.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblTitle.Location = new System.Drawing.Point(66, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(477, 58);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Popis specijalizanata";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilter.Controls.Add(this.cboxFilter);
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Location = new System.Drawing.Point(1658, 67);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(424, 79);
            this.pnlFilter.TabIndex = 20;
            this.pnlFilter.Visible = false;
            // 
            // cboxFilter
            // 
            this.cboxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxFilter.BackColor = System.Drawing.Color.White;
            this.cboxFilter.FormattingEnabled = true;
            this.cboxFilter.Items.AddRange(new object[] {
            "Mentori",
            "Specijalizanti"});
            this.cboxFilter.Location = new System.Drawing.Point(178, 40);
            this.cboxFilter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboxFilter.Name = "cboxFilter";
            this.cboxFilter.Size = new System.Drawing.Size(236, 33);
            this.cboxFilter.TabIndex = 18;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(94, 40);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(104, 31);
            this.lblFilter.TabIndex = 19;
            this.lblFilter.Text = "Filtriraj:";
            this.lblFilter.Click += new System.EventHandler(this.lblFilter_Click);
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
            this.btnDodaj.Location = new System.Drawing.Point(1964, 1012);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(170, 40);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj aktivnost";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dgvMentoriSpecijalizanti
            // 
            this.dgvMentoriSpecijalizanti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMentoriSpecijalizanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMentoriSpecijalizanti.Location = new System.Drawing.Point(62, 156);
            this.dgvMentoriSpecijalizanti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMentoriSpecijalizanti.Name = "dgvMentoriSpecijalizanti";
            this.dgvMentoriSpecijalizanti.RowHeadersWidth = 82;
            this.dgvMentoriSpecijalizanti.RowTemplate.Height = 33;
            this.dgvMentoriSpecijalizanti.Size = new System.Drawing.Size(2020, 779);
            this.dgvMentoriSpecijalizanti.TabIndex = 0;
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
            this.btnUredi.Location = new System.Drawing.Point(1764, 1012);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(170, 40);
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
            this.btnObriši.Location = new System.Drawing.Point(1564, 1012);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(170, 40);
            this.btnObriši.TabIndex = 13;
            this.btnObriši.Text = "Obriši aktivnost";
            this.btnObriši.UseVisualStyleBackColor = false;
            // 
            // frmMentorSpecijalizant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2178, 1108);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMentorSpecijalizant";
            this.Text = "frmMentorSpecijalizant";
            this.Load += new System.EventHandler(this.frmMentorSpecijalizant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentoriSpecijalizanti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvMentoriSpecijalizanti;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.ComboBox cboxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel pnlFilter;
    }
}