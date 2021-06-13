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
    public partial class MainMenu : Form
    {
        BazaPytanDataContext DatabaseDC = new BazaPytanDataContext();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć aplikację?",
                      "Wyjście",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Credits autorzy = new Credits();
            this.Hide();
            autorzy.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScoreBoard tablicaWynikow = new ScoreBoard();
            this.Hide();
            tablicaWynikow.Show();
        }

        public void start_btn_Click(object sender, EventArgs e)
        {
            enterName name = new enterName();
            this.Hide();
            name.Show();

            
        }
    }
}
