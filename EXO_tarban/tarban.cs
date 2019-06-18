using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double totals;
        double totalns;
        int valeur;
        int nserie = 2240;
        double taxe = 6.8;
        public Form1()
        {
            InitializeComponent();



        }
        private void Form1_Load(object sender, EventArgs e)
            {




        }
      


        private void calculprix()
        {
            int.TryParse(tbx_base.Text, out valeur);
            if (valeur < 10000)
            {
                MessageBox.Show("introduisez plus de 10'000-.");
            }
            if (rdo_serie.Checked)
            {
                totals= valeur;

                if (cbx_taxe.Checked)
                {
                    totals = totals + (totals / taxe);
                    lbl_totalf.Text = totals.ToString("C2");
                }
                lbl_totalf.Text = totals.ToString("C2");
            }
            if (rdo_nserie.Checked)
            { 
                totalns = nserie + valeur;

                if (cbx_taxe.Checked)
                {
                    totalns = totalns + (totalns / taxe);
                   
                }
                lbl_totalf.Text = totalns.ToString("C2");
            }


           
            
            
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void rdo_serie_CheckedChanged(object sender, EventArgs e)
        {


            calculprix();
        }

        private void lbl_totalf_Click(object sender, EventArgs e)
        {
            
           
        }

        private void rdo_nserie_CheckedChanged(object sender, EventArgs e)
        {
            calculprix();
        }

        private void cbx_taxe_CheckedChanged(object sender, EventArgs e)
        {
            calculprix();
        }

        private void tbx_base_TextChanged(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            
            
            rdo_nserie.Checked = false;
            rdo_serie.Checked = false;
            cbx_taxe.Checked = false;
            lbl_totalf.Text ="";
            tbx_base.Clear();
        }
    }
}
