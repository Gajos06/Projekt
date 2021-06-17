using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;


namespace Projekt_w_grupie
{
    public partial class ScoreBoard : Form
    {
        NowyElementDataContext DatabaseDC = new NowyElementDataContext();
        int a1,a2;
        public ScoreBoard()
        {
            InitializeComponent();
            Loadwyniki();
            

        }

        private void Loadwyniki()
        {
        



        }
        
        

        private void ScoreBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}
