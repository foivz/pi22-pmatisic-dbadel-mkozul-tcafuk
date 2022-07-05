namespace e_Dnevnik
{
    partial class frmProvjeraZnanja
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
            this.cbProvjeraZnanja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrijaviIspit = new System.Windows.Forms.Button();
            this.dgvProvjereZnanja = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvjereZnanja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbProvjeraZnanja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPrijaviIspit);
            this.panel1.Controls.Add(this.dgvProvjereZnanja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 19;
            // 
            // cbProvjeraZnanja
            // 
            this.cbProvjeraZnanja.FormattingEnabled = true;
            this.cbProvjeraZnanja.Location = new System.Drawing.Point(37, 92);
            this.cbProvjeraZnanja.Name = "cbProvjeraZnanja";
            this.cbProvjeraZnanja.Size = new System.Drawing.Size(222, 21);
            this.cbProvjeraZnanja.TabIndex = 18;
            this.cbProvjeraZnanja.SelectedValueChanged += new System.EventHandler(this.cbProvjeraZnanja_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Evidencija provjera znanja";
            // 
            // btnPrijaviIspit
            // 
            this.btnPrijaviIspit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrijaviIspit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnPrijaviIspit.FlatAppearance.BorderSize = 0;
            this.btnPrijaviIspit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijaviIspit.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnPrijaviIspit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnPrijaviIspit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrijaviIspit.Location = new System.Drawing.Point(673, 91);
            this.btnPrijaviIspit.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrijaviIspit.Name = "btnPrijaviIspit";
            this.btnPrijaviIspit.Size = new System.Drawing.Size(85, 21);
            this.btnPrijaviIspit.TabIndex = 15;
            this.btnPrijaviIspit.Text = "Prijavi ispit";
            this.btnPrijaviIspit.UseVisualStyleBackColor = false;
            this.btnPrijaviIspit.Click += new System.EventHandler(this.btnPrijaviIspit_Click);
            // 
            // dgvProvjereZnanja
            // 
            this.dgvProvjereZnanja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProvjereZnanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvjereZnanja.Location = new System.Drawing.Point(37, 134);
            this.dgvProvjereZnanja.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProvjereZnanja.Name = "dgvProvjereZnanja";
            this.dgvProvjereZnanja.RowHeadersWidth = 82;
            this.dgvProvjereZnanja.RowTemplate.Height = 33;
            this.dgvProvjereZnanja.Size = new System.Drawing.Size(721, 279);
            this.dgvProvjereZnanja.TabIndex = 0;
            // 
            // frmProvjeraZnanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmProvjeraZnanja";
            this.Text = "frmProvjeraZnanja";
            this.Load += new System.EventHandler(this.frmProvjeraZnanja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvjereZnanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProvjereZnanja;
        private System.Windows.Forms.Button btnPrijaviIspit;
        private System.Windows.Forms.ComboBox cbProvjeraZnanja;
    }
}