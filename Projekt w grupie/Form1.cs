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
        public Form1()
        {
            InitializeComponent();
            answer_textbox.Hide();
      
        }

        private void LoadBazaPytan()
        {
            question_textBox.Clear();
            foreach (BazaPytan w in DatabaseDC.BazaPytan)
            {
                question_textBox.Text = w.Question.ToString();
                    optionA_btn.Text = w.OptionA.ToString();
                    optionB_btn.Text = w.OptionB.ToString();
                    optionC_btn.Text = w.OptionC.ToString();
                    optionD_btn.Text = w.OptionD.ToString();
                    answer_textbox.Text = w.Answer.ToString();             
            }
        }
        private void autorzy_Click(object sender, EventArgs e)
        {
            string message = "Autorzy:\nBartosz Czerwiński\nKamil Gajewicz\nDamian Sygitowicz";
            MessageBox.Show(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void delay_Tick(object sender, EventArgs e)
        {
            delay.Enabled = true;
        }

        
        public void start_btn_Click(object sender, EventArgs e)
        {
            BazaPytan newQuestion = new BazaPytan();
            LoadBazaPytan();
            newQuestion.OptionA = optionA_btn.Text;
            newQuestion.OptionB = optionB_btn.Text;
            newQuestion.OptionC = optionC_btn.Text;
            newQuestion.OptionD = optionD_btn.Text;      
        }

        private void optionA_btn_Click(object sender, EventArgs e)
        {
            if (optionA_btn.Text == answer_textbox.Text)
            {
                delay.Enabled = true;
                optionA_btn.BackColor = Color.Green;
                btn_disabled();
            }
            else
            {
                delay.Enabled = true;
                optionA_btn.BackColor = Color.Red;
                btn_disabled();
            }
        }

        private void optionB_btn_Click(object sender, EventArgs e)
        {
            if (optionB_btn.Text == answer_textbox.Text)
            {
                delay.Enabled = true;
                optionB_btn.BackColor = Color.Green;
                btn_disabled();
            }
            else
            {
                delay.Enabled = true;
                optionB_btn.BackColor = Color.Red;
                btn_disabled();
            }
        }

        private void optionC_btn_Click(object sender, EventArgs e)
        {
            if (optionC_btn.Text == answer_textbox.Text)
            {
                delay.Enabled = true;
                optionC_btn.BackColor = Color.Green;
                btn_disabled();
            }
            else
            {
                delay.Enabled = true;
                optionC_btn.BackColor = Color.Red;
                btn_disabled();
            }
        }

        private void optionD_btn_Click(object sender, EventArgs e)
        {
            if (optionD_btn.Text == answer_textbox.Text)
            {
                delay.Enabled = true;
                optionD_btn.BackColor = Color.Green;
                btn_disabled();
            }
            else
            {
                delay.Enabled = true;
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
    }
}
