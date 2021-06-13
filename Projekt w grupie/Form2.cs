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
    public partial class Form2 : Form
    {
        public Form2(double suma_pkt)
        {
            InitializeComponent();
            button2.Text = suma_pkt.ToString();
            button3.Text = enterName.nickName;
        }

        private void nextQuestion_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 gra = new Form1();
            gra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
