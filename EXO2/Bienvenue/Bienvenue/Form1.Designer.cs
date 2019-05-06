namespace Bienvenue
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Bienvenue = new System.Windows.Forms.Button();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre nom";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(46, 108);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(30, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Bienvenue
            // 
            this.Bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenue.Location = new System.Drawing.Point(90, 168);
            this.Bienvenue.Name = "Bienvenue";
            this.Bienvenue.Size = new System.Drawing.Size(182, 50);
            this.Bienvenue.TabIndex = 5;
            this.Bienvenue.Text = "Bienvenu";
            this.Bienvenue.UseVisualStyleBackColor = true;
            this.Bienvenue.Click += new System.EventHandler(this.Bienvenue_Click);
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(193, 53);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(171, 20);
            this.TbxName.TabIndex = 6;
            this.TbxName.TextChanged += new System.EventHandler(this.TbxName_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.Bienvenue);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bonjour Qui?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Bienvenue;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Button button1;
    }
}

