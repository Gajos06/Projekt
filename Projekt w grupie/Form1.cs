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
        }



        private void LoadBazaPytan()
        {
            foreach (BazaPytan db in DatabaseDC.BazaPytan)
                pytania.Add(db.Id);
        }


        private void NextQuestion()
        {
            int index = 0;
            Random rand = new Random();
            int rnd = rand.Next(pytania.Count);

            foreach (BazaPytan db in DatabaseDC.BazaPytan)
            {
                if (rnd == db.Id)
                    do
                    {
                        index = pytania.IndexOf(db.Id);
                        question_textBox.Text = db.Question.ToString();
                        optionA_btn.Text = db.OptionA.ToString();
                        optionB_btn.Text = db.OptionB.ToString();
                        optionC_btn.Text = db.OptionC.ToString();
                        optionD_btn.Text = db.OptionD.ToString();
                        answer_textbox.Text = db.Answer.ToString();
                        pytania.Remove(db.Id);
                    }
                    while (pytania.Contains(db.Id));

            }
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            LoadBazaPytan();
            answer_textbox.Hide();
            default_color();
            NextQuestion();
            nextQuestion_btn.Enabled = false;
        }



        private void optionA_btn_Click(object sender, EventArgs e)
        {
            delay.Enabled = true;
            optionA_btn.BackgroundImage = Properties.Resources.prize;            
            btn_disabled();
            
        }

        private void optionB_btn_Click(object sender, EventArgs e)
        {
            delay.Enabled = true;
            optionB_btn.BackgroundImage = Properties.Resources.prize;
            btn_disabled();
        }

        private void optionC_btn_Click(object sender, EventArgs e)
        {
            delay.Enabled = true;
            optionC_btn.BackgroundImage = Properties.Resources.prize;
            btn_disabled();
        }

        private void optionD_btn_Click(object sender, EventArgs e)
        {
            delay.Enabled = true;
            optionD_btn.BackgroundImage = Properties.Resources.prize;
            btn_disabled();
        }

        private void btn_disabled()
        {
            optionA_btn.Enabled = false;
            optionB_btn.Enabled = false;
            optionC_btn.Enabled = false;
            optionD_btn.Enabled = false;
            nextQuestion_btn.Enabled = false;
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
            optionA_btn.BackgroundImage = Properties.Resources.newbutton;
            optionB_btn.BackgroundImage = Properties.Resources.newbutton;
            optionC_btn.BackgroundImage = Properties.Resources.newbutton;
            optionD_btn.BackgroundImage = Properties.Resources.newbutton;
        }

        private void nextQuestion_btn_Click(object sender, EventArgs e)
        {
            NextQuestion();
            btn_enabled();
            default_color();
            delay.Enabled = false;
            nextQuestion_btn.Enabled = false;
        }

       
        private void delay_Tick(object sender, EventArgs e)
        {
            if (optionA_btn.Text == answer_textbox.Text)
                optionA_btn.BackgroundImage = Properties.Resources.correct;
            
            if (optionB_btn.Text == answer_textbox.Text)
                optionB_btn.BackgroundImage = Properties.Resources.correct;
          
            if (optionC_btn.Text == answer_textbox.Text)
                optionC_btn.BackgroundImage = Properties.Resources.correct;
           
            if (optionD_btn.Text == answer_textbox.Text)
                optionD_btn.BackgroundImage = Properties.Resources.correct;

         
            
        }

        private void btn_Checker()
        {

        }
    }
}
