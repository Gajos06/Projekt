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
        BazaPytanDataContext DatabaseDC = new BazaPytanDataContext();
        List<int> pytania = new List<int>();
        public Form1()
        {
            InitializeComponent();
            answer_textbox.Hide();
            Id_textBox.Show();
        }

        private void LoadBazaPytan()
        {
            Random rnd = new Random();
            foreach (BazaPytan w in DatabaseDC.BazaPytan)
                if (rnd.Next(3,35) == w.Id) 
                {
                    pytania.Add(w.Id);
                    Id_textBox.Text = w.Id.ToString();
                    question_textBox.Text = w.Question.ToString();
                    optionA_btn.Text = w.OptionA.ToString();
                    optionB_btn.Text = w.OptionB.ToString();
                    optionC_btn.Text = w.OptionC.ToString();
                    optionD_btn.Text = w.OptionD.ToString();
                    answer_textbox.Text = w.Answer.ToString();
                    pytania.Remove(w.Id);
                }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBazaPytan();
        }

        private void optionA_btn_Click(object sender, EventArgs e)
        {
            if (optionA_btn.Text == answer_textbox.Text)
            {

                optionA_btn.BackColor = Color.Green;
                btn_disabled();
            }
            else
            {

                optionA_btn.BackColor = Color.Red;
                btn_disabled();
            }
        }

        private void optionB_btn_Click(object sender, EventArgs e)
        {
            if (optionB_btn.Text == answer_textbox.Text)
            {

                optionB_btn.BackColor = Color.Green;
                btn_disabled();
            }
            else
            {

                optionB_btn.BackColor = Color.Red;
                btn_disabled();
            }
        }

        private void optionC_btn_Click(object sender, EventArgs e)
        {
            if (optionC_btn.Text == answer_textbox.Text)
            {

                optionC_btn.BackColor = Color.Green;
                btn_disabled();
            }
            else
            {

                optionC_btn.BackColor = Color.Red;
                btn_disabled();
            }
        }

        private void optionD_btn_Click(object sender, EventArgs e)
        {
            if (optionD_btn.Text == answer_textbox.Text)
            {

                optionD_btn.BackColor = Color.Green;
                btn_disabled();
            }
            else
            {

                optionD_btn.BackColor = Color.Red;
                btn_disabled();
            }
        }

        private void btn_disabled()
        {
            optionA_btn.Enabled = false;
            optionB_btn.Enabled = false;
            optionC_btn.Enabled = false;
            optionD_btn.Enabled = false;
        }

        private void btn_enabled()
        {
            optionA_btn.Enabled = true;
            optionB_btn.Enabled = true;
            optionC_btn.Enabled = true;
            optionD_btn.Enabled = true;
        }

        private void default_color()
        {
            optionA_btn.BackColor = Color.White;
            optionB_btn.BackColor = Color.White;
            optionC_btn.BackColor = Color.White;
            optionD_btn.BackColor = Color.White;
        }

        private void nextQuestion_btn_Click(object sender, EventArgs e)
        {
            LoadBazaPytan();
            btn_enabled();
            default_color();
        }
    }
}
