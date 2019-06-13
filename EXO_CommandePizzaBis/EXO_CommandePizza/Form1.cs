using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO_CommandePizza
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void Pizza_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Crevettes.Checked == true) { cbx_Jambon.Checked = false; }
        }

        private void btn_commander_Click(object sender, EventArgs e)
        {
            int Table;

            string Pate;
            string Anchois;
            string Câpres;
            string Jambon;
            string Crevettes;


            if (txb_Table.Text == " ")
            {
                MessageBox.Show("Introduisez une table s'il vous plaît");
            }
            else if (int.TryParse(txb_Table.Text, out Table) == false)
            {
                MessageBox.Show("Introduisez une table Valable");
            }
            else
            {
                String Total = String.Format("Pour la {0} ", Table);
                if (rdo_Xfine.Checked == true)
                {
                    Total += "Pâte Extra Fine avec";
                }
                if (rdo_Fine.Checked == true)
                {
                    Total += "Pâte Fine avec";
                }
                if (rdo_Nomale.Checked == true)
                {
                    Total += "Pâte Normale avec";
                }
                if (rdo_Epaisse.Checked == true)
                {
                    Total += "Pâte Epaisse avec";
                }
                if (cbx_Anchois.Checked == true)
                {
                    Total += " Anchois,";
                }

                if (cbx_Câpres.Checked == true)
                {
                    Total += " Câpres,";
                }

                if (cbx_Jambon.Checked == true)
                {
                    Total += " Jambon,";
                }

                if (cbx_Crevettes.Checked == true)
                {
                    Total += " Crevettes  ";
                }

                if (rdo_Maigre.Checked == true)
                {
                    Total += "Mozzerela Maigre";
                }

                if (rdo_Normale.Checked == true)
                {
                    Total += "";
                }
                if (rdo_Bufflone.Checked == true)
                {
                    Total += "Mozzerela Bufflone";
                }

                MessageBox.Show("Commande Envoyé");


            }
        }

        private void rdo_Xfine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_Nomale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pâte_Enter(object sender, EventArgs e)
        {

        }

        private void cbx_Anchois_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Câpres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Jambon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Jambon.Checked == true) { cbx_Crevettes.Checked = false; }
        }

        private void txb_Commande_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdo_Maigre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Maigre.Checked == true)
            {
                rdo_Bufflone.Checked = false;
                rdo_Normale.Checked = false;
            }
        }

        private void rdo_Normale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Normale.Checked == true)
            {
                rdo_Bufflone.Checked = false;
                rdo_Maigre.Checked = false;
            }
        }

        private void rdo_Bufflone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Bufflone.Checked == true)
            {
                rdo_Maigre.Checked = false;
                rdo_Normale.Checked = false;
            }
        }

        private void txb_Table_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Repertoire_Click(object sender, EventArgs e)
        {

        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
    }
}
