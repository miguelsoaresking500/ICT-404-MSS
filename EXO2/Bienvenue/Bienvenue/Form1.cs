//Title : Bonjour Qui?
//Author : Miguel Soares
//Date : 09.05.2019
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
            Bienvenue.Enabled = false; //desactive le boutton Binvenue
        }
        private void TbxName_TextChanged(object sender, EventArgs e)
            {
                Bienvenue.Enabled = true; //active le boutton Binvenue
        }
        private void Bienvenue_Click(object sender, EventArgs e)
        {
            lbl_name.Text = "Bonjour " + TbxName.Text; //afiche bonjour plus le texte ecrit
            TbxName.Text = "";
            Bienvenue.Enabled = false; //desactive le boutton Binvenue
            btn_quitter.Enabled = true;//active le boutton quitter
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
