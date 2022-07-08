namespace e_Dnevnik
{
    partial class frmZaboravljenaLozinka
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
            this.labelUnos = new System.Windows.Forms.Label();
            this.textBoxUnos = new System.Windows.Forms.TextBox();
            this.buttonPodnesi = new System.Windows.Forms.Button();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.labelPrijava = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnos
            // 
            this.labelUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUnos.AutoSize = true;
            this.labelUnos.Location = new System.Drawing.Point(243, 184);
            this.labelUnos.Name = "labelUnos";
            this.labelUnos.Size = new System.Drawing.Size(300, 13);
            this.labelUnos.TabIndex = 1;
            this.labelUnos.Text = "Unesite e-mail Vašeg korisničkog računa za oporavak lozinke:";
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnos.Location = new System.Drawing.Point(246, 210);
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(297, 20);
            this.textBoxUnos.TabIndex = 2;
            // 
            // buttonPodnesi
            // 
            this.buttonPodnesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPodnesi.Location = new System.Drawing.Point(306, 265);
            this.buttonPodnesi.Name = "buttonPodnesi";
            this.buttonPodnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonPodnesi.TabIndex = 3;
            this.buttonPodnesi.Text = "Podnesi";
            this.buttonPodnesi.UseVisualStyleBackColor = true;
            this.buttonPodnesi.Click += new System.EventHandler(this.buttonPodnesi_Click);
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNatrag.Location = new System.Drawing.Point(405, 265);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(75, 23);
            this.buttonNatrag.TabIndex = 4;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // labelPrijava
            // 
            this.labelPrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrijava.AutoSize = true;
            this.labelPrijava.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrijava.Location = new System.Drawing.Point(278, 111);
            this.labelPrijava.Name = "labelPrijava";
            this.labelPrijava.Size = new System.Drawing.Size(227, 29);
            this.labelPrijava.TabIndex = 5;
            this.labelPrijava.Text = "Oporavak lozinke";
            // 
            // frmZaboravljenaLozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrijava);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.buttonPodnesi);
            this.Controls.Add(this.textBoxUnos);
            this.Controls.Add(this.labelUnos);
            this.Name = "frmZaboravljenaLozinka";
            this.Text = "frmZaboravljenaLozinka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUnos;
        private System.Windows.Forms.TextBox textBoxUnos;
        private System.Windows.Forms.Button buttonPodnesi;
        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.Label labelPrijava;
    }
}