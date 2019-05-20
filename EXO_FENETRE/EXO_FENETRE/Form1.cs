using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO_FENETRE
{
    public partial class Form1 : Form
    {
        int moves = 0;
        int color = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle src = Screen.GetBounds(this.Bounds);
        }

        private void Btn_HautGauche_Click(object sender, EventArgs e)
        {
            Rectangle src = Screen.GetBounds(this.Bounds);
            this.SetBounds(-6, 0, 401, 382);
            moves++;
        }

        private void Btn_HautDroite_Click(object sender, EventArgs e)
        {
            Rectangle src = Screen.GetBounds(this.Bounds);
            this.SetBounds(1520, 0, 401, 382);
            moves++;
        }

        private void Btn_Blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            color++;
        }

        private void Btn_Rouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            color++;
        }

        private void tn_Stats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(moves + " Déplacement(s) " + "et " + color + " Changement(s) de couleur " );
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_BasGauche_Click(object sender, EventArgs e)
        {
            this.SetBounds(-6, 600, 401, 382);
            moves++;
        }

        private void Btn_BasDroite_Click(object sender, EventArgs e)
        {
            this.SetBounds(1520, 600, 401, 382);
            moves++;
        }
    }
}
