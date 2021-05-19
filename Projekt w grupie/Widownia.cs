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
    public partial class Widownia : Form
    {
        public Widownia(int  WidowniaA, int WidowniaB, int WidowniaC, int WidowniaD)
        {
            InitializeComponent();
            progressBarA.Value= WidowniaA;
            progressBarB.Value= WidowniaB;
            progressBarC.Value= WidowniaC;
            progressBarD.Value= WidowniaD;

            


        }

        private void Widownia_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
