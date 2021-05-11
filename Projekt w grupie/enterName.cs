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
    public partial class enterName : Form
    {
        public static string nickName;
        public enterName()
        {
            InitializeComponent();
        }

        private void enterName_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toShort = "Wprowadź co najmniej 4 znaki";
            if(name_textBox.TextLength < 4)
            {
                MessageBox.Show(toShort);
            }
            else
            {
                nickName = name_textBox.Text;
                Form1 gra = new Form1();
                this.Hide();
                gra.Show();             
            }
                
        }

        private void name_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Ok_btn.PerformClick();
        }
    }
}
