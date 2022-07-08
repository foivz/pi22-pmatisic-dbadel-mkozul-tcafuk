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
            this.btnPogledajDogađaje = new System.Windows.Forms.Button();
            this.dgvMentoriSpecijalizanti = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentoriSpecijalizanti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pnlFilter);
            this.panel1.Controls.Add(this.btnPogledajDogađaje);
            this.panel1.Controls.Add(this.dgvMentoriSpecijalizanti);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
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
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(6);
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
            "Svi",
            "Mentori",
            "Specijalizanti"});
            this.cboxFilter.Location = new System.Drawing.Point(178, 40);
            this.cboxFilter.Margin = new System.Windows.Forms.Padding(6);
            this.cboxFilter.Name = "cboxFilter";
            this.cboxFilter.Size = new System.Drawing.Size(236, 33);
            this.cboxFilter.TabIndex = 18;
            this.cboxFilter.SelectedIndexChanged += new System.EventHandler(this.cboxFilter_SelectedIndexChanged);
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
            // btnPogledajDogađaje
            // 
            this.btnPogledajDogađaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPogledajDogađaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnPogledajDogađaje.FlatAppearance.BorderSize = 0;
            this.btnPogledajDogađaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPogledajDogađaje.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnPogledajDogađaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnPogledajDogađaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPogledajDogađaje.Location = new System.Drawing.Point(1964, 1012);
            this.btnPogledajDogađaje.Margin = new System.Windows.Forms.Padding(4);
            this.btnPogledajDogađaje.Name = "btnPogledajDogađaje";
            this.btnPogledajDogađaje.Size = new System.Drawing.Size(170, 40);
            this.btnPogledajDogađaje.TabIndex = 15;
            this.btnPogledajDogađaje.Text = "Više";
            this.btnPogledajDogađaje.UseVisualStyleBackColor = false;
            this.btnPogledajDogađaje.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvMentoriSpecijalizanti
            // 
            this.dgvMentoriSpecijalizanti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMentoriSpecijalizanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMentoriSpecijalizanti.Location = new System.Drawing.Point(62, 156);
            this.dgvMentoriSpecijalizanti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMentoriSpecijalizanti.Name = "dgvMentoriSpecijalizanti";
            this.dgvMentoriSpecijalizanti.RowHeadersWidth = 82;
            this.dgvMentoriSpecijalizanti.RowTemplate.Height = 33;
            this.dgvMentoriSpecijalizanti.Size = new System.Drawing.Size(2020, 779);
            this.dgvMentoriSpecijalizanti.TabIndex = 0;
            // 
            // frmMentorSpecijalizant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2178, 1108);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Button btnPogledajDogađaje;
        private System.Windows.Forms.DataGridView dgvMentoriSpecijalizanti;
        private System.Windows.Forms.ComboBox cboxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel pnlFilter;
    }
}