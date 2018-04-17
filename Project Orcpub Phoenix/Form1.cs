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
    public partial class Creation1 : Form
    {
        public Creation1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            cboxRace.SelectedIndex = -1;
            cboxClass.SelectedIndex = -1;
        }

        private void cboxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            ASI s= new ASI ();
            s.Show();
            this.Hide();

        }
    }
}
