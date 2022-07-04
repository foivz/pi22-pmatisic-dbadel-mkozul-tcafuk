namespace e_Dnevnik
{
    partial class frmZahtjevPolaganjaIspita
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
            this.lblZahtjevPolaganjaIspita = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblZahtjevPolaganjaIspita);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 19;
            // 
            // lblZahtjevPolaganjaIspita
            // 
            this.lblZahtjevPolaganjaIspita.AutoSize = true;
            this.lblZahtjevPolaganjaIspita.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.lblZahtjevPolaganjaIspita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblZahtjevPolaganjaIspita.Location = new System.Drawing.Point(32, 35);
            this.lblZahtjevPolaganjaIspita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZahtjevPolaganjaIspita.Name = "lblZahtjevPolaganjaIspita";
            this.lblZahtjevPolaganjaIspita.Size = new System.Drawing.Size(408, 29);
            this.lblZahtjevPolaganjaIspita.TabIndex = 17;
            this.lblZahtjevPolaganjaIspita.Text = "Predaja zahtjeva za polaganje ispita";
            // 
            // frmZahtjevPolaganjaIspita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmZahtjevPolaganjaIspita";
            this.Text = "frmZahtjevPolaganjaIspita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblZahtjevPolaganjaIspita;
    }
}