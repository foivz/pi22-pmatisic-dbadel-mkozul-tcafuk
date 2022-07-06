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
            this.labelOporavakLozinke = new System.Windows.Forms.Label();
            this.labelUnos = new System.Windows.Forms.Label();
            this.textBoxUnos = new System.Windows.Forms.TextBox();
            this.buttonPodnesi = new System.Windows.Forms.Button();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOporavakLozinke
            // 
            this.labelOporavakLozinke.AutoSize = true;
            this.labelOporavakLozinke.Location = new System.Drawing.Point(336, 79);
            this.labelOporavakLozinke.Name = "labelOporavakLozinke";
            this.labelOporavakLozinke.Size = new System.Drawing.Size(90, 13);
            this.labelOporavakLozinke.TabIndex = 0;
            this.labelOporavakLozinke.Text = "Oporavak lozinke";
            // 
            // labelUnos
            // 
            this.labelUnos.AutoSize = true;
            this.labelUnos.Location = new System.Drawing.Point(237, 141);
            this.labelUnos.Name = "labelUnos";
            this.labelUnos.Size = new System.Drawing.Size(300, 13);
            this.labelUnos.TabIndex = 1;
            this.labelUnos.Text = "Unesite e-mail Vašeg korisničkog računa za oporavak lozinke:";
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Location = new System.Drawing.Point(240, 167);
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(297, 20);
            this.textBoxUnos.TabIndex = 2;
            // 
            // buttonPodnesi
            // 
            this.buttonPodnesi.Location = new System.Drawing.Point(293, 222);
            this.buttonPodnesi.Name = "buttonPodnesi";
            this.buttonPodnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonPodnesi.TabIndex = 3;
            this.buttonPodnesi.Text = "Podnesi";
            this.buttonPodnesi.UseVisualStyleBackColor = true;
            this.buttonPodnesi.Click += new System.EventHandler(this.buttonPodnesi_Click);
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(392, 222);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(75, 23);
            this.buttonNatrag.TabIndex = 4;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // frmZaboravljenaLozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.buttonPodnesi);
            this.Controls.Add(this.textBoxUnos);
            this.Controls.Add(this.labelUnos);
            this.Controls.Add(this.labelOporavakLozinke);
            this.Name = "frmZaboravljenaLozinka";
            this.Text = "frmZaboravljenaLozinka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOporavakLozinke;
        private System.Windows.Forms.Label labelUnos;
        private System.Windows.Forms.TextBox textBoxUnos;
        private System.Windows.Forms.Button buttonPodnesi;
        private System.Windows.Forms.Button buttonNatrag;
    }
}