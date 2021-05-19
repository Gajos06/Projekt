namespace Projekt_w_grupie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answer_textbox = new System.Windows.Forms.TextBox();
            this.nextQuestion_btn = new System.Windows.Forms.Button();
            this.question_textBox = new System.Windows.Forms.Button();
            this.optionD_btn = new System.Windows.Forms.Button();
            this.optionC_btn = new System.Windows.Forms.Button();
            this.optionB_btn = new System.Windows.Forms.Button();
            this.optionA_btn = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.name_btn = new System.Windows.Forms.Button();
            this.fifty_btn = new System.Windows.Forms.Button();
            this.audience_btn = new System.Windows.Forms.Button();
            this.swap_btn = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_15 = new System.Windows.Forms.Button();
            this.btn_14 = new System.Windows.Forms.Button();
            this.btn_13 = new System.Windows.Forms.Button();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarD = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // answer_textbox
            // 
            this.answer_textbox.Location = new System.Drawing.Point(12, 12);
            this.answer_textbox.Name = "answer_textbox";
            this.answer_textbox.Size = new System.Drawing.Size(100, 20);
            this.answer_textbox.TabIndex = 12;
            // 
            // nextQuestion_btn
            // 
            this.nextQuestion_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.button5;
            this.nextQuestion_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.nextQuestion_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextQuestion_btn.Location = new System.Drawing.Point(528, 168);
            this.nextQuestion_btn.Name = "nextQuestion_btn";
            this.nextQuestion_btn.Size = new System.Drawing.Size(221, 51);
            this.nextQuestion_btn.TabIndex = 14;
            this.nextQuestion_btn.Text = "Nastepne Pytanie";
            this.nextQuestion_btn.UseVisualStyleBackColor = true;
            this.nextQuestion_btn.Click += new System.EventHandler(this.nextQuestion_btn_Click);
            // 
            // question_textBox
            // 
            this.question_textBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.question_textBox.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.button4;
            this.question_textBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.question_textBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.question_textBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.question_textBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.question_textBox.Location = new System.Drawing.Point(22, 223);
            this.question_textBox.Name = "question_textBox";
            this.question_textBox.Size = new System.Drawing.Size(727, 98);
            this.question_textBox.TabIndex = 21;
            this.question_textBox.UseVisualStyleBackColor = false;
            // 
            // optionD_btn
            // 
            this.optionD_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionD_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.newbutton;
            this.optionD_btn.FlatAppearance.BorderSize = 0;
            this.optionD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionD_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionD_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionD_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionD_btn.Location = new System.Drawing.Point(393, 441);
            this.optionD_btn.Name = "optionD_btn";
            this.optionD_btn.Size = new System.Drawing.Size(356, 98);
            this.optionD_btn.TabIndex = 20;
            this.optionD_btn.UseVisualStyleBackColor = false;
            this.optionD_btn.Click += new System.EventHandler(this.optionD_btn_Click);
            // 
            // optionC_btn
            // 
            this.optionC_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionC_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.newbutton;
            this.optionC_btn.FlatAppearance.BorderSize = 0;
            this.optionC_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionC_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionC_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionC_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionC_btn.Location = new System.Drawing.Point(22, 441);
            this.optionC_btn.Name = "optionC_btn";
            this.optionC_btn.Size = new System.Drawing.Size(356, 98);
            this.optionC_btn.TabIndex = 19;
            this.optionC_btn.UseVisualStyleBackColor = false;
            this.optionC_btn.Click += new System.EventHandler(this.optionC_btn_Click);
            // 
            // optionB_btn
            // 
            this.optionB_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionB_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.newbutton;
            this.optionB_btn.FlatAppearance.BorderSize = 0;
            this.optionB_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionB_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionB_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionB_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionB_btn.Location = new System.Drawing.Point(393, 337);
            this.optionB_btn.Name = "optionB_btn";
            this.optionB_btn.Size = new System.Drawing.Size(356, 98);
            this.optionB_btn.TabIndex = 18;
            this.optionB_btn.UseVisualStyleBackColor = false;
            this.optionB_btn.Click += new System.EventHandler(this.optionB_btn_Click);
            // 
            // optionA_btn
            // 
            this.optionA_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionA_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.newbutton;
            this.optionA_btn.FlatAppearance.BorderSize = 0;
            this.optionA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionA_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionA_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionA_btn.Location = new System.Drawing.Point(22, 337);
            this.optionA_btn.Name = "optionA_btn";
            this.optionA_btn.Size = new System.Drawing.Size(356, 98);
            this.optionA_btn.TabIndex = 17;
            this.optionA_btn.UseVisualStyleBackColor = false;
            this.optionA_btn.Click += new System.EventHandler(this.optionA_btn_Click);
            // 
            // delay
            // 
            this.delay.Interval = 3000;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // name_btn
            // 
            this.name_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_btn.Image = global::Projekt_w_grupie.Properties.Resources.general;
            this.name_btn.Location = new System.Drawing.Point(12, 12);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(213, 46);
            this.name_btn.TabIndex = 22;
            this.name_btn.UseVisualStyleBackColor = true;
            // 
            // fifty_btn
            // 
            this.fifty_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fifty_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources._50501;
            this.fifty_btn.FlatAppearance.BorderSize = 0;
            this.fifty_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fifty_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fifty_btn.Location = new System.Drawing.Point(555, 13);
            this.fifty_btn.Name = "fifty_btn";
            this.fifty_btn.Size = new System.Drawing.Size(60, 45);
            this.fifty_btn.TabIndex = 23;
            this.fifty_btn.UseVisualStyleBackColor = false;
            this.fifty_btn.Click += new System.EventHandler(this.fifty_btn_Click);
            // 
            // audience_btn
            // 
            this.audience_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.audience_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.audience;
            this.audience_btn.FlatAppearance.BorderSize = 0;
            this.audience_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audience_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.audience_btn.Location = new System.Drawing.Point(620, 13);
            this.audience_btn.Name = "audience_btn";
            this.audience_btn.Size = new System.Drawing.Size(60, 45);
            this.audience_btn.TabIndex = 24;
            this.audience_btn.UseVisualStyleBackColor = false;
            this.audience_btn.Click += new System.EventHandler(this.audience_btn_Click);
            // 
            // swap_btn
            // 
            this.swap_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.swap_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.swap;
            this.swap_btn.FlatAppearance.BorderSize = 0;
            this.swap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swap_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.swap_btn.Location = new System.Drawing.Point(689, 13);
            this.swap_btn.Name = "swap_btn";
            this.swap_btn.Size = new System.Drawing.Size(60, 45);
            this.swap_btn.TabIndex = 25;
            this.swap_btn.UseVisualStyleBackColor = false;
            this.swap_btn.Click += new System.EventHandler(this.swap_btn_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_1.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_1.Location = new System.Drawing.Point(850, 509);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(255, 30);
            this.btn_1.TabIndex = 26;
            this.btn_1.Text = "100$";
            this.btn_1.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_2.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_2.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_2.Location = new System.Drawing.Point(850, 473);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(255, 30);
            this.btn_2.TabIndex = 27;
            this.btn_2.Text = "200$";
            this.btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_3.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_3.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_3.Location = new System.Drawing.Point(850, 437);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(255, 30);
            this.btn_3.TabIndex = 28;
            this.btn_3.Text = "300$";
            this.btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_4.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_4.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_4.Location = new System.Drawing.Point(850, 401);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(255, 30);
            this.btn_4.TabIndex = 29;
            this.btn_4.Text = "500$";
            this.btn_4.UseVisualStyleBackColor = false;
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_8.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_8.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_8.Location = new System.Drawing.Point(850, 257);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(255, 30);
            this.btn_8.TabIndex = 33;
            this.btn_8.Text = "8 000$";
            this.btn_8.UseVisualStyleBackColor = false;
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_7.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_7.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_7.Location = new System.Drawing.Point(850, 293);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(255, 30);
            this.btn_7.TabIndex = 32;
            this.btn_7.Text = "4 000$";
            this.btn_7.UseVisualStyleBackColor = false;
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_6.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_6.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_6.Location = new System.Drawing.Point(850, 329);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(255, 30);
            this.btn_6.TabIndex = 31;
            this.btn_6.Text = "2 000$";
            this.btn_6.UseVisualStyleBackColor = false;
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_5.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_5.Location = new System.Drawing.Point(850, 365);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(255, 30);
            this.btn_5.TabIndex = 30;
            this.btn_5.Text = "1 000$";
            this.btn_5.UseVisualStyleBackColor = false;
            // 
            // btn_12
            // 
            this.btn_12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_12.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_12.FlatAppearance.BorderSize = 0;
            this.btn_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_12.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_12.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_12.Location = new System.Drawing.Point(850, 113);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(255, 30);
            this.btn_12.TabIndex = 37;
            this.btn_12.Text = "125 000$";
            this.btn_12.UseVisualStyleBackColor = false;
            // 
            // btn_11
            // 
            this.btn_11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_11.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_11.FlatAppearance.BorderSize = 0;
            this.btn_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_11.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_11.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_11.Location = new System.Drawing.Point(850, 149);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(255, 30);
            this.btn_11.TabIndex = 36;
            this.btn_11.Text = "64 000$";
            this.btn_11.UseVisualStyleBackColor = false;
            // 
            // btn_10
            // 
            this.btn_10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_10.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_10.FlatAppearance.BorderSize = 0;
            this.btn_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_10.Location = new System.Drawing.Point(850, 185);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(255, 30);
            this.btn_10.TabIndex = 35;
            this.btn_10.Text = "32 000$";
            this.btn_10.UseVisualStyleBackColor = false;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_9.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_9.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_9.Location = new System.Drawing.Point(850, 221);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(255, 30);
            this.btn_9.TabIndex = 34;
            this.btn_9.Text = "16 000$";
            this.btn_9.UseVisualStyleBackColor = false;
            // 
            // btn_15
            // 
            this.btn_15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_15.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_15.FlatAppearance.BorderSize = 0;
            this.btn_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_15.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_15.Location = new System.Drawing.Point(850, 4);
            this.btn_15.Name = "btn_15";
            this.btn_15.Size = new System.Drawing.Size(255, 30);
            this.btn_15.TabIndex = 40;
            this.btn_15.Text = "1 MILLION $";
            this.btn_15.UseVisualStyleBackColor = false;
            // 
            // btn_14
            // 
            this.btn_14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_14.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_14.FlatAppearance.BorderSize = 0;
            this.btn_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_14.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_14.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_14.Location = new System.Drawing.Point(850, 40);
            this.btn_14.Name = "btn_14";
            this.btn_14.Size = new System.Drawing.Size(255, 30);
            this.btn_14.TabIndex = 39;
            this.btn_14.Text = "500 000$";
            this.btn_14.UseVisualStyleBackColor = false;
            // 
            // btn_13
            // 
            this.btn_13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_13.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_13.FlatAppearance.BorderSize = 0;
            this.btn_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_13.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_13.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_13.Location = new System.Drawing.Point(850, 76);
            this.btn_13.Name = "btn_13";
            this.btn_13.Size = new System.Drawing.Size(255, 30);
            this.btn_13.TabIndex = 38;
            this.btn_13.Text = "250 000$";
            this.btn_13.UseVisualStyleBackColor = false;
            // 
            // progressBarA
            // 
            this.progressBarA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBarA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarA.Location = new System.Drawing.Point(48, 103);
            this.progressBarA.Maximum = 30;
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(100, 12);
            this.progressBarA.TabIndex = 41;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(48, 141);
            this.progressBarC.Maximum = 30;
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(100, 12);
            this.progressBarC.TabIndex = 42;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(48, 123);
            this.progressBarB.Maximum = 30;
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(100, 12);
            this.progressBarB.TabIndex = 44;
            // 
            // progressBarD
            // 
            this.progressBarD.Location = new System.Drawing.Point(48, 159);
            this.progressBarD.Maximum = 30;
            this.progressBarD.Name = "progressBarD";
            this.progressBarD.Size = new System.Drawing.Size(100, 12);
            this.progressBarD.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.backGround3;
            this.ClientSize = new System.Drawing.Size(1110, 550);
            this.Controls.Add(this.progressBarD);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.btn_15);
            this.Controls.Add(this.btn_14);
            this.Controls.Add(this.btn_13);
            this.Controls.Add(this.btn_12);
            this.Controls.Add(this.btn_11);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.swap_btn);
            this.Controls.Add(this.audience_btn);
            this.Controls.Add(this.fifty_btn);
            this.Controls.Add(this.name_btn);
            this.Controls.Add(this.question_textBox);
            this.Controls.Add(this.optionD_btn);
            this.Controls.Add(this.optionC_btn);
            this.Controls.Add(this.optionB_btn);
            this.Controls.Add(this.optionA_btn);
            this.Controls.Add(this.nextQuestion_btn);
            this.Controls.Add(this.answer_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milionerzy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox answer_textbox;
        private System.Windows.Forms.Button nextQuestion_btn;
        private System.Windows.Forms.Button optionA_btn;
        private System.Windows.Forms.Button optionB_btn;
        private System.Windows.Forms.Button optionD_btn;
        private System.Windows.Forms.Button optionC_btn;
        private System.Windows.Forms.Button question_textBox;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.Button name_btn;
        private System.Windows.Forms.Button fifty_btn;
        private System.Windows.Forms.Button audience_btn;
        private System.Windows.Forms.Button swap_btn;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_15;
        private System.Windows.Forms.Button btn_14;
        private System.Windows.Forms.Button btn_13;
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarD;
    }
}

