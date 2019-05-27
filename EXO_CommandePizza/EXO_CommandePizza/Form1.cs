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
                    Total += "Pâte Extra Fine";
                }
                if (rdo_Fine.Checked == true)
                {
                    Total += "Pâte Fine";
                }
                if (rdo_Nomale.Checked == true)
                {
                    Total += "Pâte Normale";
                }
                if (rdo_Epaisse.Checked == true)
                {
                    Total += "Pâte Epaisse";
                }
                if (cbx_Anchois.Checked == true)
                {
                    Total += "Pâte Anchois, ";
                }
                else
                {
                    Total += "";

                }
                if (cbx_Câpres.Checked == true)
                {
                    Total += " Câpres, ";
                }
                else
                {
                    Total += "";
                }
                if (cbx_Jambon.Checked == true)
                {
                    Total += " Jambon, ";
                }
                else
                {
                    Total += "";
                }
                if (cbx_Crevettes.Checked == true)
                {
                    Total += " Crevettes  ";
                }
                else
                {
                    Total += "";
                }

                label1.Text = Total;


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
    }
}
