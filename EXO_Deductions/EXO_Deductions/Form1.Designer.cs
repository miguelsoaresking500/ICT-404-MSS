namespace EXO_Deductions
{
    partial class Déductions
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
            this.chk_jeune = new System.Windows.Forms.CheckBox();
            this.chk_transport = new System.Windows.Forms.CheckBox();
            this.chk_rabais = new System.Windows.Forms.CheckBox();
            this.btn_calcul = new System.Windows.Forms.Button();
            this.txb_revenu = new System.Windows.Forms.TextBox();
            this.txb_coefficient = new System.Windows.Forms.TextBox();
            this.tbx_deduction = new System.Windows.Forms.TextBox();
            this.tbx_tramsport = new System.Windows.Forms.TextBox();
            this.tbx_rabais = new System.Windows.Forms.TextBox();
            this.lbl_impose = new System.Windows.Forms.Label();
            this.lbl_revenu = new System.Windows.Forms.Label();
            this.lbl_coeficient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_jeune
            // 
            this.chk_jeune.AutoSize = true;
            this.chk_jeune.Location = new System.Drawing.Point(81, 134);
            this.chk_jeune.Name = "chk_jeune";
            this.chk_jeune.Size = new System.Drawing.Size(104, 17);
            this.chk_jeune.TabIndex = 0;
            this.chk_jeune.Text = "Déduction jeune";
            this.chk_jeune.UseVisualStyleBackColor = true;
            this.chk_jeune.CheckedChanged += new System.EventHandler(this.chk_jeune_CheckedChanged);
            // 
            // chk_transport
            // 
            this.chk_transport.AutoSize = true;
            this.chk_transport.Location = new System.Drawing.Point(81, 161);
            this.chk_transport.Name = "chk_transport";
            this.chk_transport.Size = new System.Drawing.Size(119, 17);
            this.chk_transport.TabIndex = 1;
            this.chk_transport.Text = "Déduction transport";
            this.chk_transport.UseVisualStyleBackColor = true;
            this.chk_transport.CheckedChanged += new System.EventHandler(this.chk_transport_CheckedChanged);
            // 
            // chk_rabais
            // 
            this.chk_rabais.AutoSize = true;
            this.chk_rabais.Location = new System.Drawing.Point(81, 187);
            this.chk_rabais.Name = "chk_rabais";
            this.chk_rabais.Size = new System.Drawing.Size(109, 17);
            this.chk_rabais.TabIndex = 2;
            this.chk_rabais.Text = "Rabais fidélité (%)";
            this.chk_rabais.UseVisualStyleBackColor = true;
            this.chk_rabais.CheckedChanged += new System.EventHandler(this.chk_rabais_CheckedChanged);
            // 
            // btn_calcul
            // 
            this.btn_calcul.Location = new System.Drawing.Point(115, 229);
            this.btn_calcul.Name = "btn_calcul";
            this.btn_calcul.Size = new System.Drawing.Size(75, 23);
            this.btn_calcul.TabIndex = 6;
            this.btn_calcul.Text = "Calcul";
            this.btn_calcul.UseVisualStyleBackColor = true;
            this.btn_calcul.Click += new System.EventHandler(this.btn_calcul_Click);
            // 
            // txb_revenu
            // 
            this.txb_revenu.Location = new System.Drawing.Point(154, 38);
            this.txb_revenu.Name = "txb_revenu";
            this.txb_revenu.Size = new System.Drawing.Size(100, 20);
            this.txb_revenu.TabIndex = 1;
            this.txb_revenu.TextChanged += new System.EventHandler(this.txb_revenu_TextChanged);
            // 
            // txb_coefficient
            // 
            this.txb_coefficient.Location = new System.Drawing.Point(206, 76);
            this.txb_coefficient.Name = "txb_coefficient";
            this.txb_coefficient.Size = new System.Drawing.Size(48, 20);
            this.txb_coefficient.TabIndex = 2;
            this.txb_coefficient.TextChanged += new System.EventHandler(this.txb_coefficient_TextChanged);
            // 
            // tbx_deduction
            // 
            this.tbx_deduction.Location = new System.Drawing.Point(206, 132);
            this.tbx_deduction.Name = "tbx_deduction";
            this.tbx_deduction.Size = new System.Drawing.Size(48, 20);
            this.tbx_deduction.TabIndex = 3;
            this.tbx_deduction.Text = "900";
            this.tbx_deduction.TextChanged += new System.EventHandler(this.tbx_deduction_TextChanged);
            // 
            // tbx_tramsport
            // 
            this.tbx_tramsport.Location = new System.Drawing.Point(206, 158);
            this.tbx_tramsport.Name = "tbx_tramsport";
            this.tbx_tramsport.Size = new System.Drawing.Size(48, 20);
            this.tbx_tramsport.TabIndex = 4;
            this.tbx_tramsport.Text = "650";
            this.tbx_tramsport.TextChanged += new System.EventHandler(this.tbx_tramsport_TextChanged);
            // 
            // tbx_rabais
            // 
            this.tbx_rabais.Location = new System.Drawing.Point(206, 184);
            this.tbx_rabais.Name = "tbx_rabais";
            this.tbx_rabais.Size = new System.Drawing.Size(48, 20);
            this.tbx_rabais.TabIndex = 5;
            this.tbx_rabais.Text = "0";
            this.tbx_rabais.TextChanged += new System.EventHandler(this.tbx_rabais_TextChanged);
            // 
            // lbl_impose
            // 
            this.lbl_impose.AutoSize = true;
            this.lbl_impose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_impose.Location = new System.Drawing.Point(77, 273);
            this.lbl_impose.Name = "lbl_impose";
            this.lbl_impose.Size = new System.Drawing.Size(21, 20);
            this.lbl_impose.TabIndex = 9;
            this.lbl_impose.Text = "...";
            this.lbl_impose.Click += new System.EventHandler(this.lbl_impose_Click);
            // 
            // lbl_revenu
            // 
            this.lbl_revenu.AutoSize = true;
            this.lbl_revenu.Location = new System.Drawing.Point(27, 41);
            this.lbl_revenu.Name = "lbl_revenu";
            this.lbl_revenu.Size = new System.Drawing.Size(101, 13);
            this.lbl_revenu.TabIndex = 10;
            this.lbl_revenu.Text = "Revenu annuel brut";
            // 
            // lbl_coeficient
            // 
            this.lbl_coeficient.AutoSize = true;
            this.lbl_coeficient.Location = new System.Drawing.Point(27, 79);
            this.lbl_coeficient.Name = "lbl_coeficient";
            this.lbl_coeficient.Size = new System.Drawing.Size(91, 13);
            this.lbl_coeficient.TabIndex = 11;
            this.lbl_coeficient.Text = "Coefficient familial";
            // 
            // Déductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 302);
            this.Controls.Add(this.lbl_coeficient);
            this.Controls.Add(this.lbl_revenu);
            this.Controls.Add(this.lbl_impose);
            this.Controls.Add(this.tbx_rabais);
            this.Controls.Add(this.tbx_tramsport);
            this.Controls.Add(this.tbx_deduction);
            this.Controls.Add(this.txb_coefficient);
            this.Controls.Add(this.txb_revenu);
            this.Controls.Add(this.btn_calcul);
            this.Controls.Add(this.chk_rabais);
            this.Controls.Add(this.chk_transport);
            this.Controls.Add(this.chk_jeune);
            this.Name = "Déductions";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_jeune;
        private System.Windows.Forms.CheckBox chk_transport;
        private System.Windows.Forms.CheckBox chk_rabais;
        private System.Windows.Forms.Button btn_calcul;
        private System.Windows.Forms.TextBox txb_revenu;
        private System.Windows.Forms.TextBox txb_coefficient;
        private System.Windows.Forms.TextBox tbx_deduction;
        private System.Windows.Forms.TextBox tbx_tramsport;
        private System.Windows.Forms.TextBox tbx_rabais;
        private System.Windows.Forms.Label lbl_impose;
        private System.Windows.Forms.Label lbl_revenu;
        private System.Windows.Forms.Label lbl_coeficient;
    }
}

