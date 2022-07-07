namespace e_Dnevnik
{
    partial class frmProgramSpecijalizacije
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
            this.dgvPS1 = new System.Windows.Forms.DataGridView();
            this.dgvPS2 = new System.Windows.Forms.DataGridView();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.cbPS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPS1
            // 
            this.dgvPS1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPS1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPS1.Location = new System.Drawing.Point(83, 147);
            this.dgvPS1.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPS1.Name = "dgvPS1";
            this.dgvPS1.RowHeadersWidth = 82;
            this.dgvPS1.RowTemplate.Height = 33;
            this.dgvPS1.Size = new System.Drawing.Size(647, 192);
            this.dgvPS1.TabIndex = 28;
            // 
            // dgvPS2
            // 
            this.dgvPS2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPS2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPS2.Location = new System.Drawing.Point(83, 374);
            this.dgvPS2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPS2.Name = "dgvPS2";
            this.dgvPS2.RowHeadersWidth = 82;
            this.dgvPS2.RowTemplate.Height = 33;
            this.dgvPS2.Size = new System.Drawing.Size(647, 196);
            this.dgvPS2.TabIndex = 29;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnOsvjezi.FlatAppearance.BorderSize = 0;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnOsvjezi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.btnOsvjezi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOsvjezi.Location = new System.Drawing.Point(310, 95);
            this.btnOsvjezi.Margin = new System.Windows.Forms.Padding(2);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(85, 21);
            this.btnOsvjezi.TabIndex = 19;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click_1);
            // 
            // cbPS
            // 
            this.cbPS.FormattingEnabled = true;
            this.cbPS.Items.AddRange(new object[] {
            "Sve provjere"});
            this.cbPS.Location = new System.Drawing.Point(83, 96);
            this.cbPS.Name = "cbPS";
            this.cbPS.Size = new System.Drawing.Size(222, 21);
            this.cbPS.TabIndex = 18;
            this.cbPS.SelectedValueChanged += new System.EventHandler(this.cbPS_SelectedValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(78, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pregled programa specijalizacije";
            // 
            // frmProgramSpecijalizacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.dgvPS2);
            this.Controls.Add(this.dgvPS1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.cbPS);
            this.Name = "frmProgramSpecijalizacije";
            this.Text = "frmProgramSpecijalizacije";
            this.Load += new System.EventHandler(this.frmProgramSpecijalizacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.ComboBox cbPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPS1;
        private System.Windows.Forms.DataGridView dgvPS2;
    }
}