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

        }

        private void btn_commander_Click(object sender, EventArgs e)
        {
            int Table;
            string Total;
            if(txb_Table.Text==" ")
            {
                MessageBox.Show("Introduisez une table s'il vous plaît");
            }
            else if(int.TryParse(txb_Table.Text, out Table)==false)
            {
                MessageBox.Show("Introduisez une table Valable");
            }
            else
            {
            String.Total = String.Format("Pour la {0} ", Table);
            if(rdo_Xfine.Checked == true)
                {
                    Total = String.Format("Pour la{0}: {1}", Table, rdo_Xfine);
                }

            }
        }
    }
}
