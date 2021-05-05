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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autorzy_Click(object sender, EventArgs e)
        {
            string message = "Autorzy:\nBartosz Czerwiński\nKamil Gajewicz\nDamian Sygitowicz";
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new gra();
            newForm.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Kutasiarzu
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //KOMENTARZ
        //KOMETARZ NUMER 2
        //co ja tutaj robie
    }
}
