namespace e_Dnevnik
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            this.labelPrijava = new System.Windows.Forms.Label();
            this.labelKorime = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.linkLabelZabLozinka = new System.Windows.Forms.LinkLabel();
            this.textBoxKorime = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.buttonSakrij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrijava
            // 
            this.labelPrijava.AutoSize = true;
            this.labelPrijava.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrijava.Location = new System.Drawing.Point(349, 73);
            this.labelPrijava.Name = "labelPrijava";
            this.labelPrijava.Size = new System.Drawing.Size(98, 29);
            this.labelPrijava.TabIndex = 0;
            this.labelPrijava.Text = "Prijava";
            // 
            // labelKorime
            // 
            this.labelKorime.AutoSize = true;
            this.labelKorime.Location = new System.Drawing.Point(230, 151);
            this.labelKorime.Name = "labelKorime";
            this.labelKorime.Size = new System.Drawing.Size(78, 13);
            this.labelKorime.TabIndex = 1;
            this.labelKorime.Text = "Korisničko ime:";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(230, 183);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(47, 13);
            this.labelLozinka.TabIndex = 2;
            this.labelLozinka.Text = "Lozinka:";
            // 
            // linkLabelZabLozinka
            // 
            this.linkLabelZabLozinka.AutoSize = true;
            this.linkLabelZabLozinka.Location = new System.Drawing.Point(349, 235);
            this.linkLabelZabLozinka.Name = "linkLabelZabLozinka";
            this.linkLabelZabLozinka.Size = new System.Drawing.Size(111, 13);
            this.linkLabelZabLozinka.TabIndex = 3;
            this.linkLabelZabLozinka.TabStop = true;
            this.linkLabelZabLozinka.Text = "Zaboravljena lozinka?";
            this.linkLabelZabLozinka.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelZabLozinka_LinkClicked);
            // 
            // textBoxKorime
            // 
            this.textBoxKorime.Location = new System.Drawing.Point(354, 148);
            this.textBoxKorime.Name = "textBoxKorime";
            this.textBoxKorime.Size = new System.Drawing.Size(100, 20);
            this.textBoxKorime.TabIndex = 4;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(354, 180);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(100, 20);
            this.textBoxLozinka.TabIndex = 5;
            // 
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Location = new System.Drawing.Point(268, 272);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(75, 23);
            this.buttonPrijaviSe.TabIndex = 6;
            this.buttonPrijaviSe.Text = "Prijavi se";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            this.buttonPrijaviSe.Click += new System.EventHandler(this.buttonPrijaviSe_Click);
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(466, 272);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(75, 23);
            this.buttonNatrag.TabIndex = 7;
            this.buttonNatrag.Text = "Izađi";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // buttonSakrij
            // 
            this.buttonSakrij.Image = ((System.Drawing.Image)(resources.GetObject("buttonSakrij.Image")));
            this.buttonSakrij.Location = new System.Drawing.Point(460, 180);
            this.buttonSakrij.Name = "buttonSakrij";
            this.buttonSakrij.Size = new System.Drawing.Size(24, 20);
            this.buttonSakrij.TabIndex = 8;
            this.buttonSakrij.UseVisualStyleBackColor = true;
            this.buttonSakrij.Click += new System.EventHandler(this.buttonSakrij_Click);
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSakrij);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.buttonPrijaviSe);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorime);
            this.Controls.Add(this.linkLabelZabLozinka);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorime);
            this.Controls.Add(this.labelPrijava);
            this.Name = "frmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrijava;
        private System.Windows.Forms.Label labelKorime;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.LinkLabel linkLabelZabLozinka;
        private System.Windows.Forms.TextBox textBoxKorime;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonPrijaviSe;
        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.Button buttonSakrij;
    }
}