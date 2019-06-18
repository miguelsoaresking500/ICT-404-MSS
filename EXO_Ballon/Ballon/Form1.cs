using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ballon
{
    public partial class frmBallon : Form
    {
        public frmBallon()
        {
            InitializeComponent();
        }

        private void pctBallon_Click(object sender, EventArgs e)
        {

        }

        private void frmBallon_Load(object sender, EventArgs e)
        {

        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Random Y = new Random();
            int y = Y.Next(50, 500);
            Random X = new Random();
            int x = X.Next(55, 465);
            pctBallon.SetBounds(x, y, 55, 50);
            pctBallon.Visible = true;
        }
    }
}
