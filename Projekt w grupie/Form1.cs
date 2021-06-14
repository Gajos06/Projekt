using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
//test
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
        public static int timeCounter = 60;
        public static double pkt;
        public static double suma_pkt = 0.0;
        public Form1()
        {
            
           


            InitializeComponent();
            add_buttons();
            label_timer.Text = "";
            label_pkt.Text = pkt.ToString();
            wygrana1000.SoundLocation = "wygrana1000.wav";
            wygrana2000.SoundLocation = "wygrana2000.wav";
            przegrana.SoundLocation = "Lose.wav";
            wygrana500.SoundLocation = "wygrana500.wav";
            pol_na_pol.SoundLocation = "50-50.wav";
            
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
            timer1.Enabled = true;
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            pkt = 0;
            suma_pkt = 0;
            timeCounter = 60;
            timer1.Enabled = true;
            label_pkt.Text = pkt.ToString();
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
            swap_btn.Enabled = false;
            fifty_btn.Enabled = false;
            audience_btn.Enabled = false;


        }

        private void btn_enabled()
        {
            optionA_btn.Enabled = true;
            optionB_btn.Enabled = true;
            optionC_btn.Enabled = true;
            optionD_btn.Enabled = true;


            {
                if (swap_btn.Tag == "11")
                {
                    swap_btn.Enabled = false;
                }
                else
                    swap_btn.Enabled = true;
            }
            {
                if ((fifty_btn.Tag == "11"))
                {
                    fifty_btn.Enabled = false;
                }
                else
                    fifty_btn.Enabled = true;
            }
            {
                if ((audience_btn.Tag == "11"))
                    audience_btn.Enabled = false;
                else
                    audience_btn.Enabled = true;
            }
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
            timer1.Enabled = true;
            timeCounter = 60;
            nextQuestion_btn.Enabled = false;
            label_timer.Text = "";
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
                    MuzykaWygrana();
                    counter++;
                }

                //ZAZNACZAM A - ODP B
                else if (optionB_btn.Text == answer_textbox.Text)
                {
                    optionA_btn.BackgroundImage = Properties.Resources.wrong;
                    optionB_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
                //ZAZNACZAM A - ODP C
                else if (optionC_btn.Text == answer_textbox.Text)
                {
                    optionA_btn.BackgroundImage = Properties.Resources.wrong;
                    optionC_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
                //ZAZNACZAM A - ODP D
                else if (optionD_btn.Text == answer_textbox.Text)
                {
                    optionA_btn.BackgroundImage = Properties.Resources.wrong;
                    optionD_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
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
                    MuzykaWygrana();
                    counter++;

                }

                //ZAZNACZAM B - ODPOWIEDZ A
                else if (optionA_btn.Text == answer_textbox.Text)
                {
                    optionB_btn.BackgroundImage = Properties.Resources.wrong;
                    optionA_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
                //ZAZNACZAM B - ODPOWIEDZ C
                else if (optionC_btn.Text == answer_textbox.Text)
                {
                    optionB_btn.BackgroundImage = Properties.Resources.wrong;
                    optionC_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
                //ZAZNACZAM B - ODPOWIEDZ D
                else if (optionD_btn.Text == answer_textbox.Text)
                {
                    optionB_btn.BackgroundImage = Properties.Resources.wrong;
                    optionD_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
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
                    MuzykaWygrana();
                    counter++;
                }

                //ZAZNACZAM C - ODPOWIEDZ A
                else if (optionA_btn.Text == answer_textbox.Text)
                {
                    optionC_btn.BackgroundImage = Properties.Resources.wrong;
                    optionA_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
                //ZAZNACZAM C - ODPOWIEDZ B
                else if (optionB_btn.Text == answer_textbox.Text)
                {
                    optionC_btn.BackgroundImage = Properties.Resources.wrong;
                    optionB_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
                //ZAZNACZAM C - ODPOWIEDZ D
                else if (optionD_btn.Text == answer_textbox.Text)
                {
                    optionC_btn.BackgroundImage = Properties.Resources.wrong;
                    optionD_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
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
                    MuzykaWygrana();
                    counter++;
                }

                //ZAZNACZM D - ODPOWIEDZ A
                else if (optionA_btn.Text == answer_textbox.Text)
                {
                    optionD_btn.BackgroundImage = Properties.Resources.wrong;
                    optionA_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
                //ZAZNACZAM D - ODPOWIEDZ B
                else if (optionB_btn.Text == answer_textbox.Text)
                {
                    optionD_btn.BackgroundImage = Properties.Resources.wrong;
                    optionB_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
                //ZAZNACZAM D - ODPOWIEDZ C
                else if (optionC_btn.Text == answer_textbox.Text)
                {
                    optionD_btn.BackgroundImage = Properties.Resources.wrong;
                    optionC_btn.BackgroundImage = Properties.Resources.correct;
                    wygrana = false;
                    MuzykaPrzegrana();
                }
            }



            
            delay.Enabled = false;
            schodki();                       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void fifty_btn_Click(object sender, EventArgs e)
        {
            fifty_btn.BackgroundImage = Properties.Resources._5050Disabled;
            pol_na_pol.Play();
            fifty_btn.Enabled = false;
            fifty_btn.Tag = "11";
            Random rnd = new Random();
            if (optionA_btn.Text == answer_textbox.Text)
            {

                int randomNumber = rnd.Next(1, 3);
                if (randomNumber == 1)
                {
                    optionC_btn.Enabled = false;
                    optionD_btn.Enabled = false;
                }
                if (randomNumber == 2)
                {
                    optionB_btn.Enabled = false;
                    optionD_btn.Enabled = false;
                }
                if (randomNumber == 3)
                {
                    optionB_btn.Enabled = false;
                    optionC_btn.Enabled = false;
                }





            }
            if (optionB_btn.Text == answer_textbox.Text)
            {


                int randomNumber = rnd.Next(1, 3);
                if (randomNumber == 1)
                {
                    optionA_btn.Enabled = false;
                    optionC_btn.Enabled = false;
                }
                if (randomNumber == 2)
                {
                    optionA_btn.Enabled = false;
                    optionD_btn.Enabled = false;
                }
                if (randomNumber == 3)
                {
                    optionC_btn.Enabled = false;
                    optionD_btn.Enabled = false;
                }




            }
            if (optionC_btn.Text == answer_textbox.Text)
            {




                int randomNumber = rnd.Next(1, 3);
                if (randomNumber == 1)
                {
                    optionA_btn.Enabled = false;
                    optionB_btn.Enabled = false;
                }
                if (randomNumber == 2)
                {
                    optionA_btn.Enabled = false;
                    optionD_btn.Enabled = false;
                }
                if (randomNumber == 3)
                {
                    optionB_btn.Enabled = false;
                    optionD_btn.Enabled = false;
                }




            }
            if (optionD_btn.Text == answer_textbox.Text)
            {


                int randomNumber = rnd.Next(1, 3);
                if (randomNumber == 1)
                {
                    optionA_btn.Enabled = false;
                    optionB_btn.Enabled = false;
                }
                if (randomNumber == 2)
                {
                    optionA_btn.Enabled = false;
                    optionC_btn.Enabled = false;
                }
                if (randomNumber == 3)
                {
                    optionB_btn.Enabled = false;
                    optionC_btn.Enabled = false;
                }




            }
        }

        private void audience_btn_Click(object sender, EventArgs e)
        {
            audience_btn.BackgroundImage = Properties.Resources.audienceDisabled;
            audience_btn.Enabled = false;
            audience_btn.Tag = "11";
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 3);
            int randomOne = rnd.Next(1, 15 + 15);
            int randomTwo = rnd.Next(1, 15 + 5);
            int randomThree = rnd.Next(1, 15);
            int WidowniaA = 0;
            int WidowniaB = 0;
            int WidowniaC = 0;
            int WidowniaD = 0;

            
            
            




            if (optionA_btn.Text == answer_textbox.Text)
            {
                WidowniaA += randomOne;


                if (randomNumber == 1)
                {
                    WidowniaB += randomTwo;
                    WidowniaC += randomThree;
                    WidowniaD += randomThree;
                }
                if (randomNumber == 2)
                {
                    WidowniaC += randomTwo;
                    WidowniaD += randomThree;
                    WidowniaB += randomThree;
                }
                if (randomNumber == 3)
                {
                    WidowniaD += randomTwo;
                    WidowniaB += randomThree;
                    WidowniaC += randomThree;
                }
            }
            if (optionB_btn.Text == answer_textbox.Text)
            {
                WidowniaB += randomOne;

                if (randomNumber == 1)
                {
                    WidowniaA += randomTwo;
                    WidowniaC += randomThree;
                    WidowniaD += randomThree;
                }
                if (randomNumber == 2)
                {
                    WidowniaC += randomTwo;
                    WidowniaD += randomThree;
                    WidowniaA += randomThree;
                }
                if (randomNumber == 3)
                {
                    WidowniaD += randomTwo;
                    WidowniaA += randomThree;
                    WidowniaC += randomThree;
                }



            }
            if (optionC_btn.Text == answer_textbox.Text)
            {
                WidowniaC += randomOne;

                if (randomNumber == 1)
                {
                    WidowniaA += randomTwo;
                    WidowniaB += randomThree;
                    WidowniaD += randomThree;
                }
                if (randomNumber == 2)
                {
                    WidowniaA += randomTwo;
                    WidowniaD += randomThree;
                    WidowniaB += randomThree;
                }
                if (randomNumber == 3)
                {
                    WidowniaD += randomTwo;
                    WidowniaB += randomThree;
                    WidowniaA += randomThree;
                }





            }
            if (optionD_btn.Text == answer_textbox.Text)
            {
                WidowniaD += randomOne;

                if (randomNumber == 1)
                {
                    WidowniaB += randomTwo;
                    WidowniaC += randomThree;
                    WidowniaA += randomThree;
                }
                if (randomNumber == 2)
                {
                    WidowniaC += randomTwo;
                    WidowniaA += randomThree;
                    WidowniaB += randomThree;
                }
                if (randomNumber == 3)
                {
                    WidowniaA += randomTwo;
                    WidowniaB += randomThree;
                    WidowniaC += randomThree;
                }




            }

            Widownia Audience = new Widownia(WidowniaA, WidowniaB, WidowniaC, WidowniaD);
            Audience.Show();
        }

        private void swap_btn_Click(object sender, EventArgs e)
        {
            swap_btn.BackgroundImage = Properties.Resources.swapDisabled;
            swap_btn.Enabled = false;
            swap_btn.Tag = "11";
            NextQuestion();
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
            if(wygrana == true)
            {
                nextQuestion_btn.Enabled = true;
                for (int i = 1; i < 16; i++)
                    if (counter == i)
                    {
                        prize[i - 1].BackgroundImage = Properties.Resources.prize;
                        pkt += Math.Pow(i, 2) * 100;
                        suma_pkt += pkt;
                    }
            }
            else
                nextQuestion_btn.Enabled = false;


            label_pkt.Text = suma_pkt.ToString();
        }

        System.Media.SoundPlayer wygrana1000 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer wygrana2000 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer przegrana = new System.Media.SoundPlayer();
        System.Media.SoundPlayer wygrana500 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer pol_na_pol = new System.Media.SoundPlayer();



        private void MuzykaWygrana()
        {
            if (counter == 0 || counter == 1 || counter == 2 || counter == 3 || counter == 5 || counter == 6 || counter == 9)
            {
                wygrana500.Play();
            }


            if (counter == 4 || counter == 8)
            {
                wygrana1000.Play();
            }
            if (counter == 10 || counter == 11 || counter == 12)
            {
                wygrana2000.Play();
            }
        }

        private void MuzykaPrzegrana()
        {
            przegrana.Play();
            Form2 okno = new Form2(suma_pkt);
            okno.Show();
            timeCounter = 1000;
            this.Hide();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCounter--;
            if (timeCounter == 0)
            {
                timer1.Stop();
                MuzykaPrzegrana();

            }
            if (A == true || B == true || C == true || D == true)
            {
                timer1.Stop();
                pkt = timeCounter * 10;
            }
            label_timer.Text = timeCounter.ToString();
        }
    }
}
