using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Orcpub_Phoenix
{
    public partial class ASI : Form
    {
        public ASI()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Creation1 s = new Creation1();
            s.Show();
            this.Hide();
        }

        private void lblDex_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nudStr_ValueChanged(object sender, EventArgs e)
        {
            nudStr.Minimum = 8;
            nudStr.Maximum = 15;
     
        }

        private void nudDex_ValueChanged(object sender, EventArgs e)
        {
            nudDex.Minimum = 8;
            nudDex.Maximum = 15;
        }

        private void nudCon_ValueChanged(object sender, EventArgs e)
        {
            nudCon.Minimum = 8;
            nudCon.Maximum = 15;
        }

        private void nudInt_ValueChanged(object sender, EventArgs e)
        {
            nudInt.Minimum = 8;
            nudInt.Maximum = 15;
        }

        private void nudWis_ValueChanged(object sender, EventArgs e)
        {
            nudWis.Minimum = 8;
            nudWis.Maximum = 15;
        }

        private void nudCha_ValueChanged(object sender, EventArgs e)
        {
            nudWis.Minimum = 8;
            nudWis.Maximum = 15;
        }
    }
}
