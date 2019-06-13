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
        
        public Form1()
        {
            InitializeComponent();



        }
        private void Form1_Load(object sender, EventArgs e)
            {
                int valeur;
                int total;
                int.TryParse(textBox1.Text, out valeur);
            }
        private void btn_zero_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(valeur < 10000)
            {
                MessageBox.Show("introduisez plud de 10'000-.");
            }
        }

       
    }
}
