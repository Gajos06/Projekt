using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_w_grupie
{
    public partial class gra : Form
    {
        public gra()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
        }
     
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
