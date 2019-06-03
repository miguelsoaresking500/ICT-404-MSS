namespace EXO_CommandePizza
{
    partial class Pizza
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
            this.lbl_Table = new System.Windows.Forms.Label();
            this.cbx_Anchois = new System.Windows.Forms.CheckBox();
            this.txb_Table = new System.Windows.Forms.TextBox();
            this.rdo_Xfine = new System.Windows.Forms.RadioButton();
            this.rdo_Epaisse = new System.Windows.Forms.RadioButton();
            this.rdo_Nomale = new System.Windows.Forms.RadioButton();
            this.rdo_Fine = new System.Windows.Forms.RadioButton();
            this.cbx_Câpres = new System.Windows.Forms.CheckBox();
            this.cbx_Jambon = new System.Windows.Forms.CheckBox();
            this.cbx_Crevettes = new System.Windows.Forms.CheckBox();
            this.lbl_Commande = new System.Windows.Forms.Label();
            this.btn_commander = new System.Windows.Forms.Button();
            this.Pâte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdo_Maigre = new System.Windows.Forms.RadioButton();
            this.rdo_Normale = new System.Windows.Forms.RadioButton();
            this.rdo_Bufflone = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pâte.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Table
            // 
            this.lbl_Table.AutoSize = true;
            this.lbl_Table.Location = new System.Drawing.Point(59, 35);
            this.lbl_Table.Name = "lbl_Table";
            this.lbl_Table.Size = new System.Drawing.Size(34, 13);
            this.lbl_Table.TabIndex = 0;
            this.lbl_Table.Text = "Table";
            // 
            // cbx_Anchois
            // 
            this.cbx_Anchois.AutoSize = true;
            this.cbx_Anchois.Location = new System.Drawing.Point(273, 92);
            this.cbx_Anchois.Name = "cbx_Anchois";
            this.cbx_Anchois.Size = new System.Drawing.Size(64, 17);
            this.cbx_Anchois.TabIndex = 1;
            this.cbx_Anchois.Text = "Anchois";
            this.cbx_Anchois.UseVisualStyleBackColor = true;
            this.cbx_Anchois.CheckedChanged += new System.EventHandler(this.cbx_Anchois_CheckedChanged);
            // 
            // txb_Table
            // 
            this.txb_Table.Location = new System.Drawing.Point(99, 32);
            this.txb_Table.Name = "txb_Table";
            this.txb_Table.Size = new System.Drawing.Size(28, 20);
            this.txb_Table.TabIndex = 2;
            this.txb_Table.TextChanged += new System.EventHandler(this.txb_Table_TextChanged);
            // 
            // rdo_Xfine
            // 
            this.rdo_Xfine.AutoSize = true;
            this.rdo_Xfine.Location = new System.Drawing.Point(22, 14);
            this.rdo_Xfine.Name = "rdo_Xfine";
            this.rdo_Xfine.Size = new System.Drawing.Size(69, 17);
            this.rdo_Xfine.TabIndex = 3;
            this.rdo_Xfine.TabStop = true;
            this.rdo_Xfine.Text = "Extra-fine";
            this.rdo_Xfine.UseVisualStyleBackColor = true;
            this.rdo_Xfine.CheckedChanged += new System.EventHandler(this.rdo_Xfine_CheckedChanged);
            // 
            // rdo_Epaisse
            // 
            this.rdo_Epaisse.AutoSize = true;
            this.rdo_Epaisse.Location = new System.Drawing.Point(22, 83);
            this.rdo_Epaisse.Name = "rdo_Epaisse";
            this.rdo_Epaisse.Size = new System.Drawing.Size(62, 17);
            this.rdo_Epaisse.TabIndex = 5;
            this.rdo_Epaisse.TabStop = true;
            this.rdo_Epaisse.Text = "Epaisse";
            this.rdo_Epaisse.UseVisualStyleBackColor = true;
            // 
            // rdo_Nomale
            // 
            this.rdo_Nomale.AutoSize = true;
            this.rdo_Nomale.Location = new System.Drawing.Point(22, 60);
            this.rdo_Nomale.Name = "rdo_Nomale";
            this.rdo_Nomale.Size = new System.Drawing.Size(64, 17);
            this.rdo_Nomale.TabIndex = 6;
            this.rdo_Nomale.TabStop = true;
            this.rdo_Nomale.Text = "Normale";
            this.rdo_Nomale.UseVisualStyleBackColor = true;
            this.rdo_Nomale.CheckedChanged += new System.EventHandler(this.rdo_Nomale_CheckedChanged);
            // 
            // rdo_Fine
            // 
            this.rdo_Fine.AutoSize = true;
            this.rdo_Fine.Location = new System.Drawing.Point(22, 37);
            this.rdo_Fine.Name = "rdo_Fine";
            this.rdo_Fine.Size = new System.Drawing.Size(45, 17);
            this.rdo_Fine.TabIndex = 7;
            this.rdo_Fine.TabStop = true;
            this.rdo_Fine.Text = "Fine";
            this.rdo_Fine.UseVisualStyleBackColor = true;
            // 
            // cbx_Câpres
            // 
            this.cbx_Câpres.AutoSize = true;
            this.cbx_Câpres.Location = new System.Drawing.Point(273, 114);
            this.cbx_Câpres.Name = "cbx_Câpres";
            this.cbx_Câpres.Size = new System.Drawing.Size(59, 17);
            this.cbx_Câpres.TabIndex = 8;
            this.cbx_Câpres.Text = "Câpres";
            this.cbx_Câpres.UseVisualStyleBackColor = true;
            this.cbx_Câpres.CheckedChanged += new System.EventHandler(this.cbx_Câpres_CheckedChanged);
            // 
            // cbx_Jambon
            // 
            this.cbx_Jambon.AutoSize = true;
            this.cbx_Jambon.Location = new System.Drawing.Point(274, 137);
            this.cbx_Jambon.Name = "cbx_Jambon";
            this.cbx_Jambon.Size = new System.Drawing.Size(63, 17);
            this.cbx_Jambon.TabIndex = 9;
            this.cbx_Jambon.Text = "Jambon";
            this.cbx_Jambon.UseVisualStyleBackColor = true;
            this.cbx_Jambon.CheckedChanged += new System.EventHandler(this.cbx_Jambon_CheckedChanged);
            // 
            // cbx_Crevettes
            // 
            this.cbx_Crevettes.AutoSize = true;
            this.cbx_Crevettes.Location = new System.Drawing.Point(274, 159);
            this.cbx_Crevettes.Name = "cbx_Crevettes";
            this.cbx_Crevettes.Size = new System.Drawing.Size(71, 17);
            this.cbx_Crevettes.TabIndex = 10;
            this.cbx_Crevettes.Text = "Crevettes";
            this.cbx_Crevettes.UseVisualStyleBackColor = true;
            this.cbx_Crevettes.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // lbl_Commande
            // 
            this.lbl_Commande.AutoSize = true;
            this.lbl_Commande.Location = new System.Drawing.Point(62, 199);
            this.lbl_Commande.Name = "lbl_Commande";
            this.lbl_Commande.Size = new System.Drawing.Size(60, 13);
            this.lbl_Commande.TabIndex = 11;
            this.lbl_Commande.Text = "Commande";
            // 
            // btn_commander
            // 
            this.btn_commander.Location = new System.Drawing.Point(235, 194);
            this.btn_commander.Name = "btn_commander";
            this.btn_commander.Size = new System.Drawing.Size(110, 23);
            this.btn_commander.TabIndex = 12;
            this.btn_commander.Text = "commander";
            this.btn_commander.UseVisualStyleBackColor = true;
            this.btn_commander.Click += new System.EventHandler(this.btn_commander_Click);
            // 
            // Pâte
            // 
            this.Pâte.Controls.Add(this.rdo_Xfine);
            this.Pâte.Controls.Add(this.rdo_Fine);
            this.Pâte.Controls.Add(this.rdo_Nomale);
            this.Pâte.Controls.Add(this.rdo_Epaisse);
            this.Pâte.Location = new System.Drawing.Point(31, 77);
            this.Pâte.Name = "Pâte";
            this.Pâte.Size = new System.Drawing.Size(122, 110);
            this.Pâte.TabIndex = 13;
            this.Pâte.TabStop = false;
            this.Pâte.Text = "Pâte";
            this.Pâte.Enter += new System.EventHandler(this.Pâte_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(31, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 59);
            this.label1.TabIndex = 14;
            this.label1.Text = "...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdo_Maigre
            // 
            this.rdo_Maigre.AutoSize = true;
            this.rdo_Maigre.Location = new System.Drawing.Point(22, 36);
            this.rdo_Maigre.Name = "rdo_Maigre";
            this.rdo_Maigre.Size = new System.Drawing.Size(57, 17);
            this.rdo_Maigre.TabIndex = 15;
            this.rdo_Maigre.TabStop = true;
            this.rdo_Maigre.Text = "Maigre";
            this.rdo_Maigre.UseVisualStyleBackColor = true;
            this.rdo_Maigre.CheckedChanged += new System.EventHandler(this.rdo_Maigre_CheckedChanged);
            // 
            // rdo_Normale
            // 
            this.rdo_Normale.AutoSize = true;
            this.rdo_Normale.Location = new System.Drawing.Point(22, 59);
            this.rdo_Normale.Name = "rdo_Normale";
            this.rdo_Normale.Size = new System.Drawing.Size(64, 17);
            this.rdo_Normale.TabIndex = 16;
            this.rdo_Normale.TabStop = true;
            this.rdo_Normale.Text = "Normale";
            this.rdo_Normale.UseVisualStyleBackColor = true;
            this.rdo_Normale.CheckedChanged += new System.EventHandler(this.rdo_Normale_CheckedChanged);
            // 
            // rdo_Bufflone
            // 
            this.rdo_Bufflone.AutoSize = true;
            this.rdo_Bufflone.Location = new System.Drawing.Point(22, 82);
            this.rdo_Bufflone.Name = "rdo_Bufflone";
            this.rdo_Bufflone.Size = new System.Drawing.Size(64, 17);
            this.rdo_Bufflone.TabIndex = 17;
            this.rdo_Bufflone.TabStop = true;
            this.rdo_Bufflone.Text = "Bufflone";
            this.rdo_Bufflone.UseVisualStyleBackColor = true;
            this.rdo_Bufflone.CheckedChanged += new System.EventHandler(this.rdo_Bufflone_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Maigre);
            this.groupBox1.Controls.Add(this.rdo_Normale);
            this.groupBox1.Controls.Add(this.rdo_Bufflone);
            this.groupBox1.Location = new System.Drawing.Point(159, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 110);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mozzarela";
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pâte);
            this.Controls.Add(this.btn_commander);
            this.Controls.Add(this.lbl_Commande);
            this.Controls.Add(this.cbx_Crevettes);
            this.Controls.Add(this.cbx_Jambon);
            this.Controls.Add(this.cbx_Câpres);
            this.Controls.Add(this.txb_Table);
            this.Controls.Add(this.cbx_Anchois);
            this.Controls.Add(this.lbl_Table);
            this.Name = "Pizza";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Pizza_Load);
            this.Pâte.ResumeLayout(false);
            this.Pâte.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Table;
        private System.Windows.Forms.CheckBox cbx_Anchois;
        private System.Windows.Forms.TextBox txb_Table;
        private System.Windows.Forms.RadioButton rdo_Xfine;
        private System.Windows.Forms.RadioButton rdo_Epaisse;
        private System.Windows.Forms.RadioButton rdo_Nomale;
        private System.Windows.Forms.RadioButton rdo_Fine;
        private System.Windows.Forms.CheckBox cbx_Câpres;
        private System.Windows.Forms.CheckBox cbx_Jambon;
        private System.Windows.Forms.CheckBox cbx_Crevettes;
        private System.Windows.Forms.Label lbl_Commande;
        private System.Windows.Forms.Button btn_commander;
        private System.Windows.Forms.GroupBox Pâte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_Maigre;
        private System.Windows.Forms.RadioButton rdo_Normale;
        private System.Windows.Forms.RadioButton rdo_Bufflone;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

