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
        private int Strcount;
        private int Dexcount;
        private int Concount;
        private int Wiscount;
        private int Intcount;
        private int Chacount;

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
                int Strcount = Convert.ToInt32(nudStr.Value);

            }

            private void nudDex_ValueChanged(object sender, EventArgs e)
            {
                nudDex.Minimum = 8;
                nudDex.Maximum = 15;
                int Dexcount = Convert.ToInt32(nudDex.Value);
            }

            private void nudCon_ValueChanged(object sender, EventArgs e)
            {
                nudCon.Minimum = 8;
                nudCon.Maximum = 15;
                int Concount = Convert.ToInt32(nudCon.Value);
            }

            private void nudInt_ValueChanged(object sender, EventArgs e)
            {
                nudInt.Minimum = 8;
                nudInt.Maximum = 15;
                int Intcount = Convert.ToInt32(nudInt.Value);
            }

            private void nudWis_ValueChanged(object sender, EventArgs e)
            {
                nudWis.Minimum = 8;
                nudWis.Maximum = 15;
                int Wiscount = Convert.ToInt32(nudWis.Value);
            }  
    
        private void nudCha_ValueChanged(object sender, EventArgs e)
        {
            nudWis.Minimum = 8;
            nudWis.Maximum = 15;
            int Chacount = Convert.ToInt32(nudCha.Value);
        }
        
        public void pointCount()
        {
            /*
             Racial modifiers add on after point buy calculation is done
             Max points is 27
             8 - 0
             9 - 1
            10 - 2
            11 - 3
            12 - 4
            13 - 5
            14 - 7
            15 - 9
      */
            int Totalcount = Strcount + Dexcount + Concount + Wiscount + Intcount + Chacount;
            if count = 8
                point = 0
            if count = 9
                point = 1
            if count = 10
                point = 2
            if count = 11
                point = 3
            if count = 12
                point = 4
            if count = 13
                point = 5
            if count = 14
                point = 7
            if count = 15
                point = 9
        }
    }
}
