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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void Credits_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}
