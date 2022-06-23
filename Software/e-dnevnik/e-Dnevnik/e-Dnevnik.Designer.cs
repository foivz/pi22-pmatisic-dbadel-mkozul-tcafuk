namespace e_Dnevnik
{
    partial class frmEDnevnik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEDnevnik));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnBiljeske = new System.Windows.Forms.Button();
            this.btnDnevnikAktivnosti = new System.Windows.Forms.Button();
            this.bntSlucajeviBolesnika = new System.Windows.Forms.Button();
            this.btnProvjereZnanja = new System.Windows.Forms.Button();
            this.btnStrucniRadovi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.timerZatvoriMeni = new System.Windows.Forms.Timer(this.components);
            this.pboxResize = new System.Windows.Forms.PictureBox();
            this.pboxHamburger = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHamburger)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pboxResize);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnZatvori);
            this.panel1.Controls.Add(this.pboxHamburger);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panelSideBar.Controls.Add(this.btnStrucniRadovi);
            this.panelSideBar.Controls.Add(this.btnProvjereZnanja);
            this.panelSideBar.Controls.Add(this.bntSlucajeviBolesnika);
            this.panelSideBar.Controls.Add(this.btnDnevnikAktivnosti);
            this.panelSideBar.Controls.Add(this.btnBiljeske);
            this.panelSideBar.Controls.Add(this.btnProfil);
            this.panelSideBar.Controls.Add(this.btnOdjava);
            resources.ApplyResources(this.panelSideBar, "panelSideBar");
            this.panelSideBar.Name = "panelSideBar";
            // 
            // panelBody
            // 
            resources.ApplyResources(this.panelBody, "panelBody");
            this.panelBody.Name = "panelBody";
            // 
            // btnOdjava
            // 
            resources.ApplyResources(this.btnOdjava, "btnOdjava");
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            resources.ApplyResources(this.btnProfil, "btnProfil");
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.UseVisualStyleBackColor = true;
            // 
            // btnBiljeske
            // 
            resources.ApplyResources(this.btnBiljeske, "btnBiljeske");
            this.btnBiljeske.FlatAppearance.BorderSize = 0;
            this.btnBiljeske.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBiljeske.Name = "btnBiljeske";
            this.btnBiljeske.UseVisualStyleBackColor = true;
            // 
            // btnDnevnikAktivnosti
            // 
            this.btnDnevnikAktivnosti.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDnevnikAktivnosti, "btnDnevnikAktivnosti");
            this.btnDnevnikAktivnosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDnevnikAktivnosti.Name = "btnDnevnikAktivnosti";
            this.btnDnevnikAktivnosti.UseVisualStyleBackColor = true;
            this.btnDnevnikAktivnosti.Click += new System.EventHandler(this.btnDnevnikAktivnosti_Click);
            // 
            // bntSlucajeviBolesnika
            // 
            this.bntSlucajeviBolesnika.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.bntSlucajeviBolesnika, "bntSlucajeviBolesnika");
            this.bntSlucajeviBolesnika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.bntSlucajeviBolesnika.Name = "bntSlucajeviBolesnika";
            this.bntSlucajeviBolesnika.UseVisualStyleBackColor = true;
            // 
            // btnProvjereZnanja
            // 
            this.btnProvjereZnanja.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnProvjereZnanja, "btnProvjereZnanja");
            this.btnProvjereZnanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnProvjereZnanja.Name = "btnProvjereZnanja";
            this.btnProvjereZnanja.UseVisualStyleBackColor = true;
            // 
            // btnStrucniRadovi
            // 
            this.btnStrucniRadovi.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnStrucniRadovi, "btnStrucniRadovi");
            this.btnStrucniRadovi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnStrucniRadovi.Name = "btnStrucniRadovi";
            this.btnStrucniRadovi.UseVisualStyleBackColor = true;
            // 
            // btnZatvori
            // 
            resources.ApplyResources(this.btnZatvori, "btnZatvori");
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // timerZatvoriMeni
            // 
            this.timerZatvoriMeni.Interval = 5;
            this.timerZatvoriMeni.Tick += new System.EventHandler(this.timerZatvoriMeni_Tick);
            // 
            // pboxResize
            // 
            resources.ApplyResources(this.pboxResize, "pboxResize");
            this.pboxResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pboxResize.Image = global::e_Dnevnik.Properties.Resources.window_decrease;
            this.pboxResize.Name = "pboxResize";
            this.pboxResize.TabStop = false;
            this.pboxResize.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pboxHamburger
            // 
            this.pboxHamburger.Image = global::e_Dnevnik.Properties.Resources.menu_regular_24;
            resources.ApplyResources(this.pboxHamburger, "pboxHamburger");
            this.pboxHamburger.Name = "pboxHamburger";
            this.pboxHamburger.TabStop = false;
            this.pboxHamburger.Click += new System.EventHandler(this.pboxHamburger_Click);
            // 
            // frmEDnevnik
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "frmEDnevnik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHamburger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button bntSlucajeviBolesnika;
        private System.Windows.Forms.Button btnDnevnikAktivnosti;
        private System.Windows.Forms.Button btnBiljeske;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnStrucniRadovi;
        private System.Windows.Forms.Button btnProvjereZnanja;
        private System.Windows.Forms.PictureBox pboxHamburger;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pboxResize;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Timer timerZatvoriMeni;
    }
}

