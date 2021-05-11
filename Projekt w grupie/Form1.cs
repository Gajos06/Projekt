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
        public static bool A = false;
        public static bool B = false;
        public static bool C = false;
        public static bool D = false;
        public static bool wygrana = true;
        public int counter = 0;
        BazaPytanDataContext DatabaseDC = new BazaPytanDataContext();
        List<int> pytania = new List<int>();
        Button[] prize = new System.Windows.Forms.Button[15];
        public Form1()
        {
            InitializeComponent();
            add_buttons();
        }



        private void LoadBazaPytan()
        {
            foreach (BazaPytan db in DatabaseDC.BazaPytan)
                pytania.Add(db.Id);
        }


        private void NextQuestion()
        {
            A = false;
            B = false;
            C = false;
            D = false;
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
            name_btn.Text = enterName.nickName;
            LoadBazaPytan();
            answer_textbox.Hide();
            default_color();
            NextQuestion();
            nextQuestion_btn.Enabled = false;
            
        }



        private void optionA_btn_Click(object sender, EventArgs e)
        {
            A = true;
            delay.Enabled = true;
            optionA_btn.BackgroundImage = Properties.Resources.checkpoint;
            btn_disabled();

        }

        private void optionB_btn_Click(object sender, EventArgs e)
        {
            B = true;
            delay.Enabled = true;
            optionB_btn.BackgroundImage = Properties.Resources.checkpoint;
            btn_disabled();
        }

        private void optionC_btn_Click(object sender, EventArgs e)
        {
            C = true;
            delay.Enabled = true;
            optionC_btn.BackgroundImage = Properties.Resources.checkpoint;
            btn_disabled();
        }

        private void optionD_btn_Click(object sender, EventArgs e)
        {
            D = true;
            delay.Enabled = true;
            optionD_btn.BackgroundImage = Properties.Resources.checkpoint;
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

        //delay
        private void delay_Tick(object sender, EventArgs e)
        {          
            //ZAZNACZAM A
            if (A)
            {
                B = false;
                C = false;
                D = false;
                //ODP A
                if (optionA_btn.Text == answer_textbox.Text)
                {
                    optionA_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = true;
                    counter++;
                }

                //ZAZNACZAM A - ODP B
                else if (optionB_btn.Text == answer_textbox.Text)
                {
                    optionA_btn.BackgroundImage = Properties.Resources.wrong;
                    optionB_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
                //ZAZNACZAM A - ODP C
                else if (optionC_btn.Text == answer_textbox.Text)
                {
                    optionA_btn.BackgroundImage = Properties.Resources.wrong;
                    optionC_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
                //ZAZNACZAM A - ODP D
                else if (optionD_btn.Text == answer_textbox.Text)
                {
                    optionA_btn.BackgroundImage = Properties.Resources.wrong;
                    optionD_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
            }
            //ZAZNACZAM B
            if (B)
            {
                A = false;
                C = false;
                D = false;
                //ODP B
                if (optionB_btn.Text == answer_textbox.Text)
                {
                    optionB_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = true;
                    counter++;
                }

                //ZAZNACZAM B - ODPOWIEDZ A
                else if (optionA_btn.Text == answer_textbox.Text)
                {
                    optionB_btn.BackgroundImage = Properties.Resources.wrong;
                    optionA_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
                //ZAZNACZAM B - ODPOWIEDZ C
                else if (optionC_btn.Text == answer_textbox.Text)
                {
                    optionB_btn.BackgroundImage = Properties.Resources.wrong;
                    optionC_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
                //ZAZNACZAM B - ODPOWIEDZ D
                else if (optionD_btn.Text == answer_textbox.Text)
                {
                    optionB_btn.BackgroundImage = Properties.Resources.wrong;
                    optionD_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
            }
            //ZAZNACZAM C
            if (C)
            {
                A = false;
                B = false;
                D = false;
                //ODP C
                if (optionC_btn.Text == answer_textbox.Text)
                {
                    optionC_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = true;
                    counter++;
                }

                //ZAZNACZAM C - ODPOWIEDZ A
                else if (optionA_btn.Text == answer_textbox.Text)
                {
                    optionC_btn.BackgroundImage = Properties.Resources.wrong;
                    optionA_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
                //ZAZNACZAM C - ODPOWIEDZ B
                else if (optionB_btn.Text == answer_textbox.Text)
                {
                    optionC_btn.BackgroundImage = Properties.Resources.wrong;
                    optionB_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
                //ZAZNACZAM C - ODPOWIEDZ D
                else if (optionD_btn.Text == answer_textbox.Text)
                {
                    optionC_btn.BackgroundImage = Properties.Resources.wrong;
                    optionD_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
            }
            //ZAZNACZAM D
            if (D)
            {
                A = false;
                B = false;
                C = false;
                //ODP D
                if (optionD_btn.Text == answer_textbox.Text)
                {
                    optionD_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = true;
                    counter++;
                }

                //ZAZNACZM D - ODPOWIEDZ A
                else if (optionA_btn.Text == answer_textbox.Text)
                {
                    optionD_btn.BackgroundImage = Properties.Resources.wrong;
                    optionA_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
                //ZAZNACZAM D - ODPOWIEDZ B
                else if (optionB_btn.Text == answer_textbox.Text)
                {
                    optionD_btn.BackgroundImage = Properties.Resources.wrong;
                    optionB_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
                //ZAZNACZAM D - ODPOWIEDZ C
                else if (optionC_btn.Text == answer_textbox.Text)
                {
                    optionD_btn.BackgroundImage = Properties.Resources.wrong;
                    optionC_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                }
            }


            delay.Enabled = false;
            schodki();
            if (wygrana == false)
                nextQuestion_btn.Enabled = false;
            else
            {
                nextQuestion_btn.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wyjść?",
                      "Wyjście",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }
        }

        private void fifty_btn_Click(object sender, EventArgs e)
        {
            fifty_btn.BackgroundImage = Properties.Resources._5050Disabled;
        }

        private void audience_btn_Click(object sender, EventArgs e)
        {
            audience_btn.BackgroundImage = Properties.Resources.audienceDisabled;
        }

        private void swap_btn_Click(object sender, EventArgs e)
        {
            swap_btn.BackgroundImage = Properties.Resources.swapDisabled;
        }

        private void add_buttons()
        {
            prize[0] = btn_1;
            prize[1] = btn_2;
            prize[2] = btn_3;
            prize[3] = btn_4;
            prize[4] = btn_5;
            prize[5] = btn_6;
            prize[6] = btn_7;
            prize[7] = btn_8;
            prize[8] = btn_9;
            prize[9] = btn_10;
            prize[10] = btn_11;
            prize[11] = btn_12;
            prize[12] = btn_13;
            prize[13] = btn_14;
            prize[14] = btn_15;
        }

        private void schodki()
        { 
            for(int i=1; i<16; i++)
                if (counter == i)
                    prize[i-1].BackgroundImage = Properties.Resources.prize;
                
        }
    }
}
