namespace EXO_FENETRE
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
            this.Btn_HautGauche = new System.Windows.Forms.Button();
            this.Btn_HautDroite = new System.Windows.Forms.Button();
            this.tn_Stats = new System.Windows.Forms.Button();
            this.Btn_BasDroite = new System.Windows.Forms.Button();
            this.Btn_BasGauche = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Blue = new System.Windows.Forms.Button();
            this.Btn_Rouge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_HautGauche
            // 
            this.Btn_HautGauche.Location = new System.Drawing.Point(12, 12);
            this.Btn_HautGauche.Name = "Btn_HautGauche";
            this.Btn_HautGauche.Size = new System.Drawing.Size(85, 23);
            this.Btn_HautGauche.TabIndex = 0;
            this.Btn_HautGauche.Text = "Haut/Gauche";
            this.Btn_HautGauche.UseVisualStyleBackColor = true;
            this.Btn_HautGauche.Click += new System.EventHandler(this.Btn_HautGauche_Click);
            // 
            // Btn_HautDroite
            // 
            this.Btn_HautDroite.Location = new System.Drawing.Point(292, 12);
            this.Btn_HautDroite.Name = "Btn_HautDroite";
            this.Btn_HautDroite.Size = new System.Drawing.Size(81, 23);
            this.Btn_HautDroite.TabIndex = 1;
            this.Btn_HautDroite.Text = "Haut/Droite";
            this.Btn_HautDroite.UseVisualStyleBackColor = true;
            this.Btn_HautDroite.Click += new System.EventHandler(this.Btn_HautDroite_Click);
            // 
            // tn_Stats
            // 
            this.tn_Stats.Location = new System.Drawing.Point(161, 177);
            this.tn_Stats.Name = "tn_Stats";
            this.tn_Stats.Size = new System.Drawing.Size(75, 23);
            this.tn_Stats.TabIndex = 2;
            this.tn_Stats.Text = "Stats";
            this.tn_Stats.UseVisualStyleBackColor = true;
            this.tn_Stats.Click += new System.EventHandler(this.tn_Stats_Click);
            // 
            // Btn_BasDroite
            // 
            this.Btn_BasDroite.Location = new System.Drawing.Point(292, 308);
            this.Btn_BasDroite.Name = "Btn_BasDroite";
            this.Btn_BasDroite.Size = new System.Drawing.Size(81, 23);
            this.Btn_BasDroite.TabIndex = 3;
            this.Btn_BasDroite.Text = "Bas/Droite";
            this.Btn_BasDroite.UseVisualStyleBackColor = true;
            this.Btn_BasDroite.Click += new System.EventHandler(this.Btn_BasDroite_Click);
            // 
            // Btn_BasGauche
            // 
            this.Btn_BasGauche.Location = new System.Drawing.Point(12, 308);
            this.Btn_BasGauche.Name = "Btn_BasGauche";
            this.Btn_BasGauche.Size = new System.Drawing.Size(85, 23);
            this.Btn_BasGauche.TabIndex = 4;
            this.Btn_BasGauche.Text = "Bas/Gauche";
            this.Btn_BasGauche.UseVisualStyleBackColor = true;
            this.Btn_BasGauche.Click += new System.EventHandler(this.Btn_BasGauche_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(161, 238);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "Quitter";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Blue
            // 
            this.Btn_Blue.Location = new System.Drawing.Point(161, 91);
            this.Btn_Blue.Name = "Btn_Blue";
            this.Btn_Blue.Size = new System.Drawing.Size(75, 23);
            this.Btn_Blue.TabIndex = 6;
            this.Btn_Blue.Text = "Bleu";
            this.Btn_Blue.UseVisualStyleBackColor = true;
            this.Btn_Blue.Click += new System.EventHandler(this.Btn_Blue_Click);
            // 
            // Btn_Rouge
            // 
            this.Btn_Rouge.Location = new System.Drawing.Point(161, 120);
            this.Btn_Rouge.Name = "Btn_Rouge";
            this.Btn_Rouge.Size = new System.Drawing.Size(75, 23);
            this.Btn_Rouge.TabIndex = 7;
            this.Btn_Rouge.Text = "Rouge";
            this.Btn_Rouge.UseVisualStyleBackColor = true;
            this.Btn_Rouge.Click += new System.EventHandler(this.Btn_Rouge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 343);
            this.Controls.Add(this.Btn_Rouge);
            this.Controls.Add(this.Btn_Blue);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_BasGauche);
            this.Controls.Add(this.Btn_BasDroite);
            this.Controls.Add(this.tn_Stats);
            this.Controls.Add(this.Btn_HautDroite);
            this.Controls.Add(this.Btn_HautGauche);
            this.Name = "Form1";
            this.Text = "Fenetre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_HautGauche;
        private System.Windows.Forms.Button Btn_HautDroite;
        private System.Windows.Forms.Button tn_Stats;
        private System.Windows.Forms.Button Btn_BasDroite;
        private System.Windows.Forms.Button Btn_BasGauche;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Blue;
        private System.Windows.Forms.Button Btn_Rouge;
    }
}

