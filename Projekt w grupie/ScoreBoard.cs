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
            if (lista[0] != null)
            {
                guzik1.Text = lista[0].Nazwa_użytkownika;
                guzik1o.Text = lista[0].Punktacja;
            }
            if (lista[1] != null)
            {
                guzik2.Text = lista[1].Nazwa_użytkownika;
                guzik2o.Text = lista[1].Punktacja;
            }
            if (lista[2] != null)
            {
                guzik3.Text = lista[2].Nazwa_użytkownika;
                guzik3o.Text = lista[2].Punktacja;
            }
            if (lista[3] != null)
            {
                guzik4.Text = lista[3].Nazwa_użytkownika;
                guzik4o.Text = lista[3].Punktacja;
            }
            if (lista[4] != null)
            {
                guzik5.Text = lista[4].Nazwa_użytkownika;
                guzik5o.Text = lista[4].Punktacja;
            }
            if(lista[5] != null)
            {
                guzik6.Text = lista[5].Nazwa_użytkownika;
                guzik6o.Text = lista[5].Punktacja;
            }
            if(lista[6] != null)
            {
                guzik7.Text = lista[6].Nazwa_użytkownika;
                guzik7o.Text = lista[6].Punktacja;
            }
        }
        
        

        private void ScoreBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}
