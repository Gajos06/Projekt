﻿using System;
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
    public partial class ScoreBoard : Form
    {
        DatabasewynikiDataContext DatabaseDC = new DatabasewynikiDataContext(); 
        public ScoreBoard()
        {
            InitializeComponent();
            Loadwyniki();

           //listBox1.DisplayMember = "Nazwa";
        }

        private void Loadwyniki()
        {
           foreach (wynik w in DatabaseDC.wyniks)
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
