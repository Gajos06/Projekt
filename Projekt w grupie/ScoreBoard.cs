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



             var lista = DatabaseDC.wyniki.OrderByDescending(w => w.Punktacja).ToList();
            try
            {
                guzik1.Text = lista[0].Nazwa_użytkownika;
                guzik1o.Text = lista[0].Punktacja;
                Numer1.Enabled = true;
            }
            catch { }

            try
            {
                guzik2.Text = lista[1].Nazwa_użytkownika;
                guzik2o.Text = lista[1].Punktacja;
                Numer2.Enabled = true;
            }
            catch { }
            try
            {
                guzik3.Text = lista[2].Nazwa_użytkownika;
                guzik3o.Text = lista[2].Punktacja;
                Numer3.Enabled = true;
            }
            catch { }
            try
            {
                guzik4.Text = lista[3].Nazwa_użytkownika;
                guzik4o.Text = lista[3].Punktacja;
                Numer4.Enabled = true;
            }
            catch { }
            try
            {
                guzik5.Text = lista[4].Nazwa_użytkownika;
                guzik5o.Text = lista[4].Punktacja;
                Numer5.Enabled = true;
            }
            catch { }
            try
            {
                guzik6.Text = lista[5].Nazwa_użytkownika;
                guzik6o.Text = lista[5].Punktacja;
                Numer6.Enabled = true;

            }
            catch { }
            try
            {
                guzik7.Text = lista[6].Nazwa_użytkownika;
                guzik7o.Text = lista[6].Punktacja;
                Numer7.Enabled = true;

            }
            catch { }


            
            







        }
        
        

        private void ScoreBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}
