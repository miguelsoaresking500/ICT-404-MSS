namespace WindowsFormsApp1
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
            this.rdo_serie = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbx_taxe = new System.Windows.Forms.CheckBox();
            this.gb_moteur = new System.Windows.Forms.GroupBox();
            this.rdo_nserie = new System.Windows.Forms.RadioButton();
            this.btn_zero = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_totalf = new System.Windows.Forms.Label();
            this.gb_moteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(65, 64);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(37, 13);
            this.lbl_base.TabIndex = 0;
            this.lbl_base.Text = "Base :";
            // 
            // rdo_serie
            // 
            this.rdo_serie.AutoSize = true;
            this.rdo_serie.Location = new System.Drawing.Point(23, 29);
            this.rdo_serie.Name = "rdo_serie";
            this.rdo_serie.Size = new System.Drawing.Size(86, 17);
            this.rdo_serie.TabIndex = 1;
            this.rdo_serie.TabStop = true;
            this.rdo_serie.Text = "1.4 : de série";
            this.rdo_serie.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbx_taxe
            // 
            this.cbx_taxe.AutoSize = true;
            this.cbx_taxe.Location = new System.Drawing.Point(68, 242);
            this.cbx_taxe.Name = "cbx_taxe";
            this.cbx_taxe.Size = new System.Drawing.Size(87, 17);
            this.cbx_taxe.TabIndex = 3;
            this.cbx_taxe.Text = "Taxes (6.8%)";
            this.cbx_taxe.UseVisualStyleBackColor = true;
            // 
            // gb_moteur
            // 
            this.gb_moteur.Controls.Add(this.rdo_nserie);
            this.gb_moteur.Controls.Add(this.rdo_serie);
            this.gb_moteur.Location = new System.Drawing.Point(68, 109);
            this.gb_moteur.Name = "gb_moteur";
            this.gb_moteur.Size = new System.Drawing.Size(200, 100);
            this.gb_moteur.TabIndex = 4;
            this.gb_moteur.TabStop = false;
            this.gb_moteur.Text = "Moteur";
            // 
            // rdo_nserie
            // 
            this.rdo_nserie.AutoSize = true;
            this.rdo_nserie.Location = new System.Drawing.Point(23, 61);
            this.rdo_nserie.Name = "rdo_nserie";
            this.rdo_nserie.Size = new System.Drawing.Size(79, 17);
            this.rdo_nserie.TabIndex = 5;
            this.rdo_nserie.TabStop = true;
            this.rdo_nserie.Text = "1.6 : 2240.-";
            this.rdo_nserie.UseVisualStyleBackColor = true;
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(68, 303);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(200, 23);
            this.btn_zero.TabIndex = 5;
            this.btn_zero.Text = "Remettre le formulaire a zero";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(67, 359);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(37, 13);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total :";
            // 
            // lbl_totalf
            // 
            this.lbl_totalf.AutoSize = true;
            this.lbl_totalf.Location = new System.Drawing.Point(111, 359);
            this.lbl_totalf.Name = "lbl_totalf";
            this.lbl_totalf.Size = new System.Drawing.Size(16, 13);
            this.lbl_totalf.TabIndex = 7;
            this.lbl_totalf.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 409);
            this.Controls.Add(this.lbl_totalf);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.gb_moteur);
            this.Controls.Add(this.cbx_taxe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_base);
            this.Name = "Form1";
            this.Text = "Traban 2000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_moteur.ResumeLayout(false);
            this.gb_moteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.RadioButton rdo_serie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbx_taxe;
        private System.Windows.Forms.GroupBox gb_moteur;
        private System.Windows.Forms.RadioButton rdo_nserie;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_totalf;
    }
}

