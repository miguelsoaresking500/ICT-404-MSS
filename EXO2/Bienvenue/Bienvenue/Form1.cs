using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Bienvenue.Enabled = false;
        }
        private void TbxName_TextChanged(object sender, EventArgs e)
            {
                Bienvenue.Enabled = true;
            }
        private void Bienvenue_Click(object sender, EventArgs e)
        {
            lbl_name.Text = "Bonjour " + TbxName.Text;
            Bienvenue.Enabled = false;
            TbxName.Text = "";
        }

    
    }
}
