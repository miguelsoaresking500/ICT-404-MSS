using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traban
{
    public partial class Form1 : Form
    {
        string total;
        int Base;
        int options;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void rdo_serie_CheckedChanged(object sender, EventArgs e)
        {
         
            int.TryParse(textBox1.Text, out Base);
            
            if (Base < 10000)
                
            {
                MessageBox.Show("intoduisez plus 10000 ");
            }
            
            
            
        }

        private void rdo_nserie_CheckedChanged(object sender, EventArgs e)
        {
            
            int.TryParse(textBox1.Text, out Base);

            if (Base < 10000)

            {
                MessageBox.Show("intoduisez plus 10000 ");
            }
            
            if (rdo_nserie.Checked)
            {
                options = Base + 2240;
            }

        }

        private void chx_taxe_CheckedChanged(object sender, EventArgs e)
        { ;
            
            int.TryParse(textBox1.Text, out Base);
            if (chx_taxe.Checked) 
            {
               // total = Base + (Base /100 * 6.8);
            }
        }

        p
    }
}
