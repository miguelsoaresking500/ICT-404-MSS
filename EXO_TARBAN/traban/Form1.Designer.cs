namespace traban
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_base = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_nserie = new System.Windows.Forms.RadioButton();
            this.rdo_serie = new System.Windows.Forms.RadioButton();
            this.chx_taxe = new System.Windows.Forms.CheckBox();
            this.btn_zero = new System.Windows.Forms.Button();
            this.lbl_tot1 = new System.Windows.Forms.Label();
            this.lbl_tot2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(47, 52);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(54, 20);
            this.lbl_base.TabIndex = 0;
            this.lbl_base.Text = "Base :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_nserie);
            this.groupBox1.Controls.Add(this.rdo_serie);
            this.groupBox1.Location = new System.Drawing.Point(51, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moteur";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdo_nserie
            // 
            this.rdo_nserie.AutoSize = true;
            this.rdo_nserie.Location = new System.Drawing.Point(18, 88);
            this.rdo_nserie.Name = "rdo_nserie";
            this.rdo_nserie.Size = new System.Drawing.Size(116, 24);
            this.rdo_nserie.TabIndex = 1;
            this.rdo_nserie.TabStop = true;
            this.rdo_nserie.Text = "1.6L : 2\'240";
            this.rdo_nserie.UseVisualStyleBackColor = true;
            this.rdo_nserie.CheckedChanged += new System.EventHandler(this.rdo_nserie_CheckedChanged);
            // 
            // rdo_serie
            // 
            this.rdo_serie.AutoSize = true;
            this.rdo_serie.Location = new System.Drawing.Point(18, 46);
            this.rdo_serie.Name = "rdo_serie";
            this.rdo_serie.Size = new System.Drawing.Size(114, 24);
            this.rdo_serie.TabIndex = 0;
            this.rdo_serie.TabStop = true;
            this.rdo_serie.Text = "1.4L : Série";
            this.rdo_serie.UseVisualStyleBackColor = true;
            this.rdo_serie.CheckedChanged += new System.EventHandler(this.rdo_serie_CheckedChanged);
            // 
            // chx_taxe
            // 
            this.chx_taxe.AutoSize = true;
            this.chx_taxe.Location = new System.Drawing.Point(51, 295);
            this.chx_taxe.Name = "chx_taxe";
            this.chx_taxe.Size = new System.Drawing.Size(119, 24);
            this.chx_taxe.TabIndex = 3;
            this.chx_taxe.Text = "Taxe (6.8%)";
            this.chx_taxe.UseVisualStyleBackColor = true;
            this.chx_taxe.CheckedChanged += new System.EventHandler(this.chx_taxe_CheckedChanged);
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(51, 336);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(279, 27);
            this.btn_zero.TabIndex = 4;
            this.btn_zero.Text = "Remettre le formulaire a zero";
            this.btn_zero.UseVisualStyleBackColor = true;
            // 
            // lbl_tot1
            // 
            this.lbl_tot1.AutoSize = true;
            this.lbl_tot1.Location = new System.Drawing.Point(51, 396);
            this.lbl_tot1.Name = "lbl_tot1";
            this.lbl_tot1.Size = new System.Drawing.Size(56, 20);
            this.lbl_tot1.TabIndex = 5;
            this.lbl_tot1.Text = "Total : ";
            // 
            // lbl_tot2
            // 
            this.lbl_tot2.AutoSize = true;
            this.lbl_tot2.Location = new System.Drawing.Point(171, 396);
            this.lbl_tot2.Name = "lbl_tot2";
            this.lbl_tot2.Size = new System.Drawing.Size(21, 20);
            this.lbl_tot2.TabIndex = 6;
            this.lbl_tot2.Text = "...";
            this.lbl_tot2.Click += new System.EventHandler(this.lbl_tot2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.lbl_tot2);
            this.Controls.Add(this.lbl_tot1);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.chx_taxe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_base);
            this.Name = "Form1";
            this.Text = "tarban 2000";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_nserie;
        private System.Windows.Forms.RadioButton rdo_serie;
        private System.Windows.Forms.CheckBox chx_taxe;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Label lbl_tot1;
        private System.Windows.Forms.Label lbl_tot2;
    }
}

