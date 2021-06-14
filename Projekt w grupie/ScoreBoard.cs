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


namespace Projekt_w_grupie
{
    public partial class ScoreBoard : Form
    {
        NowyElementDataContext DatabaseDC = new NowyElementDataContext(); 
        public ScoreBoard()
        {
            InitializeComponent();
            Loadwyniki();
            //ArrayList list = new ArrayList();
            //foreach (object o in list)
            //{
            //    list.Add(o);
            //}
            //list.Sort();
            //list.Reverse();
            //listBox1.Items.Clear();
            //foreach (object o in list)
            //{
            //    listBox1.Items.Add(o);
            //}

        }

        private void Loadwyniki()
        {
            foreach (wyniki w in DatabaseDC.wyniki)
            {
                listBox1.Items.Add(w);
            }
        }

        private void ScoreBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}
