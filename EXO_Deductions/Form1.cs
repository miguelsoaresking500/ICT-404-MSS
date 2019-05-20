using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EXO_Deductions

{
    public partial class Déductions : Form
    {
        
        public Déductions()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_impose.Visible = false;
            
        }

        private void txb_revenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_coefficient_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_tramsport_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_deduction_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_rabais_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcul_Click(object sender, EventArgs e)
        {                //coversion des types
            
            int revenu = int.Parse(txb_revenu.Text); //variable pour le revenu
            float coefficient = float.Parse(txb_coefficient.Text); //variable pour le coefficient
            int deduction = int.Parse(tbx_deduction.Text); //variable deduction
            int tramsport = int.Parse(tbx_tramsport.Text); //variable transpors
            float rabais = float.Parse(tbx_rabais.Text) / 100; //variable rabais
            lbl_impose.Visible = true;

            if (txb_revenu.Text == "" || txb_coefficient.Text == "")
            {
                MessageBox.Show("intoduisez plus des chiffres ");
            }
            else if (revenu < 20000)
            {
                MessageBox.Show("intoduisez plus de 20'000 ");
            }
            else if (coefficient < 1 || coefficient > 10)
            {
                MessageBox.Show("intoduisez entre 1 et 10!");
            }
            else if{

            }
            else
            {


                //calculs

                float Resultat = revenu / coefficient;
                if (chk_rabais.Checked == true)
                {
                    Resultat = Resultat - (rabais * Resultat);
                }
                if (chk_jeune.Checked == true)
                {
                    Resultat -= deduction;
                }
                if (chk_transport.Checked == true)
                {
                    Resultat -= tramsport;
                }
                //Afficher
                lbl_impose.Text = String.Format("Révenu imposable: Fr.{0:c2}", Resultat);
            }
            
            
        }

        private void lbl_impose_Click(object sender, EventArgs e)
        {
            
        }

        private void chk_jeune_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_transport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_rabais_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
